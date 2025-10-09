using JobNear.Controllers;
using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver.Core.Authentication;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Profile : UserControl
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private Timer debounceTimer;
        private Dictionary<string, (double lat, double lon)> suggestionData = new Dictionary<string, (double lat, double lon)>();

        private double selectedLat;
        private double selectedLon;

        private bool isEditing = false;


        private GeoaptifyAutocompeteAPIServices geoServices = new GeoaptifyAutocompeteAPIServices();
        public JS_Profile()
        {
            InitializeComponent();

            this.Load += AccountForm_Load;

            SetProfileEditable(isEditing);

            ButtonStyle.RoundedButton(upload_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(attach_file, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(draft_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(review_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(edit_btn,25, "#3B82F6");

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;

            debounceTimer = new Timer();
            debounceTimer.Interval = 300;
            debounceTimer.Tick += DebounceTimer_Tick;

            address_input.Leave += Address_input_Leave;

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


        private void address_input_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
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


        private void review_button_Click(object sender, EventArgs e)
        {
            UpdateProfileData(false, "pending");
        }

        private void draft_button_Click(object sender, EventArgs e)
        {
            UpdateProfileData(isDraft: true, status: "incomplete");
        }

        public async void UpdateProfileData(bool isDraft, string status)
        {

            TextBoxValidatorController.ValidateEmail(email_input);
            TextBoxValidatorController.ValidatePhoneNumber(phone_input);
            TextBoxValidatorController.AllowOnlyNumbers(age_input);
            TextBoxValidatorController.AllowOnlyNumbers(phone_input);

            if (string.IsNullOrEmpty(firstname_input.Text) || string.IsNullOrEmpty(lastname_input.Text) || string.IsNullOrEmpty(middlename_input.Text) ||
                string.IsNullOrEmpty(age_input.Text) || string.IsNullOrEmpty(phone_input.Text) || string.IsNullOrEmpty(email_input.Text)
                || string.IsNullOrEmpty(address_input.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (profile_picture.Image == null)
            {
                MessageBox.Show("Please upload a profile picture", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (image_flowlayout.Controls.Count == 0)
            {
                MessageBox.Show("Please attach at least one supporting document", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (selectedLon == 0 & selectedLon == 0)
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
                    if (ctrl is Panel panel && panel.Tag != null)
                    {
                        string filePath = panel.Tag.ToString();
                        if (File.Exists(filePath))
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

                bool response = await MongoDbServices.UpdateJobSeekerProfileAsync(Session.CurrentUserId, Session.CurrentEmail, phone_input.Text, lastname_input.Text, firstname_input.Text, middlename_input.Text,
                    sex_combo.Text, birthdate_picker.Text, short.Parse(age_input.Text), address_input.Text, selectedLat, selectedLon, imageResponse,
                    supportingDocuments, isDraft, status);

                if (response)
                {
                    MessageBox.Show(isDraft ? "Profile updated successfully as draft" : "Profile updated successfully and ready for review", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void AccountForm_Load(object sender, EventArgs e)
        {
            var seeker = await MongoDbServices.LoadCurrentSeekerData();

            if (seeker != null)
            {
                firstname_input.Text = seeker.Firstname;
                lastname_input.Text = seeker.Lastname;
                middlename_input.Text = seeker.Middlename;
                sex_combo.Text = seeker.Sex;
                birthdate_picker.Value = seeker.Birthdate;
                age_input.Text = seeker.Age.ToString();
                phone_input.Text = seeker.Phone;
                email_input.Text = seeker.Email;
                address_input.Text = seeker.Address;
                profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(seeker.ProfilePicture);

                if (seeker.SupportingDocuments != null)
                {
                    foreach (var doc in seeker.SupportingDocuments)
                    {
                        FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, 785);
                    }
                }

                UserController.UpdateAccountStatus(status_label, seeker.Status);
            }
        }


        private void SetProfileEditable(bool isEditable)
        {
            foreach (Control c in sidebar_panel.Controls)
            {
                if (c is System.Windows.Forms.TextBox tb)
                {
                    tb.ReadOnly = !isEditable;
                    tb.BackColor = isEditable ? Color.White : Color.LightGray; // visual cue
                }
                else if (c is System.Windows.Forms.ComboBox cb)
                {
                    cb.Enabled = isEditable;
                }
                else if (c is DateTimePicker dtp)
                {
                    dtp.Enabled = isEditable;
                }
                else if (c is System.Windows.Forms.Button btn && (btn == upload_button || btn == attach_file || btn == draft_button || btn == review_button))
                {
                    btn.Enabled = isEditable;
                }
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                SetProfileEditable(true);
                edit_btn.Text = "Cancel";
                isEditing = true;
            }
            else
            {
                SetProfileEditable(false);
                edit_btn.Text = "Edit";
                isEditing = false;
            }

        }
    }
}

