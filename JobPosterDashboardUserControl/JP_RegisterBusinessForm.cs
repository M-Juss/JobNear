using JobNear.Forms;
using JobNear.JobSeekerDashboardUserControl;
using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_RegisterBusinessForm : UserControl
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private Timer debounceTimer;
        private Dictionary<string, (double lat, double lon)> suggestionData = new Dictionary<string, (double lat, double lon)>();

        private double selectedLat;
        private double selectedLon;

        private GeoaptifyAutocompeteAPIServices geoServices = new GeoaptifyAutocompeteAPIServices();

        public JP_RegisterBusinessForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(attach_file, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(draft_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(review_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(upload_button, 25, "#FFFFFF");

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;

            debounceTimer = new Timer();
            debounceTimer.Interval = 300;
            debounceTimer.Tick += DebounceTimer_Tick;

            address_input.Leave += Address_input_Leave;
            address_input.TextChanged += Address_input_TextChanged;

        }

        private async void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();

            suggestionData = await geoServices.GetSuggestionsAsync(address_input.Text);
            geoServices.ApplyAutoComplete(address_input, suggestionData);
        }

        private void Address_input_Leave(object sender, EventArgs e)
        {
            if (suggestionData != null && suggestionData.ContainsKey(address_input.Text))
            {
                var coords = suggestionData[address_input.Text];
                selectedLat = coords.lat;
                selectedLon = coords.lon;
            }
            else
            {
                selectedLat = 0;
                selectedLon = 0;
            }
        }
        private void Address_input_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void review_button_Click(object sender, EventArgs e)
        {
            InsertBusinessDetails(false, "pending");
        }

        private async void InsertBusinessDetails(bool isDraft, string status)
        {
            TextBoxValidatorController.ValidateEmail(email_input);
            TextBoxValidatorController.ValidatePhoneNumber(phone_input);
            TextBoxValidatorController.AllowOnlyNumbers(phone_input);

            if (string.IsNullOrEmpty(name_input.Text) || string.IsNullOrEmpty(industry_input.Text) ||
                string.IsNullOrEmpty(description_richbox.Text) || string.IsNullOrEmpty(address_input.Text) ||
                string.IsNullOrEmpty(email_input.Text) || string.IsNullOrEmpty(phone_input.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (profile_picture.Image == null)
            {
                MessageBox.Show("Please upload a profile picture", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (image_flowlayout.Controls.Count == 0)
            {
                MessageBox.Show("Please attach at least one supporting document", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedLat == 0 && selectedLon == 0)
            {
                var result = await geoServices.GetSuggestionsAsync(address_input.Text);
                if (result.Any())
                {
                    var firstEntry = result.First();
                    selectedLat = firstEntry.Value.lat;
                    selectedLon = firstEntry.Value.lon;
                }
                else
                {
                    MessageBox.Show("Could not determine location for this address. Coordinates set to 0,0.",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

                List<SupportingDocument> supportingDocuments = new List<SupportingDocument>();

                foreach (Control ctrl in image_flowlayout.Controls)
                {
                    if (ctrl is Panel panel)
                    {
                        if (panel.Tag is SupportingDocument existingDoc)
                        {
                            supportingDocuments.Add(existingDoc);
                        }
                        else if (panel.Tag is string filePath && File.Exists(filePath))
                        {
                            supportingDocuments.Add(new SupportingDocument
                            {
                                FileName = Path.GetFileName(filePath),
                                FileContent = File.ReadAllBytes(filePath)
                            });
                        }
                    }
                }

                byte[] imageResponse = ConvertDataTypeServices.ConvertImageToBytes(profile_picture.Image);

                bool response = await MongoDbServices.InsertBusinessApplicationAsync(
                    Session.CurrentUserId,
                    name_input.Text,
                    industry_input.Text,
                    description_richbox.Text,
                    email_input.Text,
                    phone_input.Text,
                    website_input.Text,
                    address_input.Text,
                    selectedLat,
                    selectedLon,
                    imageResponse,
                    supportingDocuments,
                    isDraft,
                    status
                    );

                if (response)
                {
                    string res = MessageBox.Show(
                        isDraft ? "Business inserted successfully as a draft" : "Business registered successfully and ready for review",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    ).ToString();

                    if (res == "OK")
                    {
                        name_input.Clear();
                        industry_input.SelectedIndex = -1;
                        description_richbox.Clear();
                        address_input.Clear();
                        email_input.Clear();
                        phone_input.Clear();
                        website_input.Clear();
                        profile_picture.Image = null;
                        image_flowlayout.Controls.Clear();

                    }
                    else return;
                }
                else
                {
                    MessageBox.Show("Failed to register business. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profile_picture.Image = Image.FromFile(ofd.FileName);
            }
            else
            {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attach_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);

                    string savePath = Path.Combine(Application.StartupPath, "SupportingDocs");
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);

                    string destPath = Path.Combine(savePath, fileName);
                    File.Copy(filePath, destPath, true);

                    FlowLayoutStyles.AddFileItem(destPath, image_flowlayout, 785);
                }
            }
        }

        private void JP_RegisterBusinessForm_Load(object sender, EventArgs e)
        {

        }

    }
}
