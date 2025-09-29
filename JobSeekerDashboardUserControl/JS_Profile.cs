using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using JobNear.Services;
using JobNear.Controllers;
using MongoDB.Driver.Core.Authentication;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Profile : UserControl
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private Timer debounceTimer;
        private Dictionary<string, (double lat, double lon)> suggestionData = new Dictionary<string, (double lat, double lon)>();

        private GeoaptifyAutocompeteAPIServices geoServices = new GeoaptifyAutocompeteAPIServices();
        public JS_Profile()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(upload_button, 25 , "#FFFFFF");
            ButtonStyle.RoundedButton(attach_file, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(draft_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(review_button, 25, "#FFFFFF");

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;

            debounceTimer = new Timer();
            debounceTimer.Interval = 300; // 3 seconds
            debounceTimer.Tick += DebounceTimer_Tick;

        }

        private async void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();

            suggestionData = await geoServices.GetSuggestionsAsync(address_input.Text);

            geoServices.ApplyAutoComplete(address_input, suggestionData);
        }


        private void email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void upload_button_Click(object sender, EventArgs e)
        {            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profile_picture.Image = Image.FromFile(ofd.FileName);
            }
            else {
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

                    FlowLayoutStyles.AddFileItem(destPath, image_flowlayout);

                    List<string> filePaths = new List<string>();

                    foreach (Control ctrl in image_flowlayout.Controls)
                    {
                        if (ctrl is Panel panel && panel.Tag != null)
                        {
                            filePaths.Add(panel.Tag.ToString());
                        }
                    }
                    Console.WriteLine(string.Join(", ", filePaths));
                }
            }
        }


        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void address_input_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();

        }

        private async void review_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname_input.Text) || string.IsNullOrEmpty(lastname_input.Text) || string.IsNullOrEmpty(middlename_input.Text) ||
                string.IsNullOrEmpty(age_input.Text) || string.IsNullOrEmpty(phone_input.Text) || string.IsNullOrEmpty(email_input.Text)
                || string.IsNullOrEmpty(address_input.Text)) {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                TextBoxValidatorController.ValidateEmail(email_input);
                TextBoxValidatorController.ValidatePhoneNumber(phone_input);
                TextBoxValidatorController.AllowOnlyNumbers(age_input);
                TextBoxValidatorController.AllowOnlyNumbers(phone_input);
            }
            if (profile_picture.Image == null)
            {
                MessageBox.Show("Please upload a profile picture", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (image_flowlayout.Controls.Count == 0)
            {
                MessageBox.Show("Please attach at least one supporting document", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
