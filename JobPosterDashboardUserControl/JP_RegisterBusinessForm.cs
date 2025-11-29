using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            SetUpRegisterBusinessForm();
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(address_panel, 20, Color.White);
            PanelStyles.RoundedPanel(supporting_panel, 20, Color.White);

            cancel_button.Visible = false;
            update_button.Visible = false;
        }

        public JP_RegisterBusinessForm(string businessId)
        {
            InitializeComponent();
            SetUpRegisterBusinessForm();
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(address_panel, 20, Color.White);
            PanelStyles.RoundedPanel(supporting_panel, 20, Color.White);

            LoadEditBusinessDetails(businessId);
            review_button.Visible = false;

        }
        private async void LoadEditBusinessDetails(string businessId)
        {
            try
            {
                header_label.Text = "Edit Business Details";

                var businessDetails = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Id == businessId)
                    .FirstOrDefaultAsync();

                if (businessDetails != null)
                {
                    name_input.Text = businessDetails.BusinessName;
                    industry_input.Text = businessDetails.BusinessIndustry;
                    description_richbox.Text = businessDetails.BusinessDescription;
                    address_input.Text = businessDetails.BusinessAddress;
                    email_input.Text = businessDetails.BusinessEmail;
                    phone_input.Text = businessDetails.BusinessContact;
                    website_input.Text = businessDetails.BusinessSite;
                    profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);

                    if (businessDetails.SupportingDocuments != null)
                    {
                        foreach (var doc in businessDetails.SupportingDocuments)
                        {
                            FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, 726);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading business details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private async void InsertBusinessDetails(string status)
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
                    status
                    );

                if (response)
                {
                    string res = MessageBox.Show(
                        "Business registered successfully and ready for review",
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

        private async void UpdateBusinessDetails(string status) {
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
                    return;
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

            bool response = await MongoDbServices.UpdateBusinessAsync(
                Session.CurrentBusinessSelected,
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
                status
                );

                if (response)
                {
                var checkJobPosts = await MongoDbServices.JobPosterJobPosting
                    .Find(x => x.BusinessId == Session.CurrentBusinessSelected)
                    .ToListAsync();

                if (checkJobPosts != null && checkJobPosts.Count > 0)
                {
                    foreach (var jobPost in checkJobPosts)
                    {
                        var jobPostFilter = Builders<JobPosterJobPostingModel>.Filter.Eq(x => x.Id, jobPost.Id);

                        var updateJobPost = Builders<JobPosterJobPostingModel>.Update
                            .Set(x => x.IsBusinessOnReview, true);

                        await MongoDbServices.JobPosterJobPosting.UpdateOneAsync(jobPostFilter, updateJobPost);
                    }
                }

                string res = MessageBox.Show(
                    "Business updated successfully and ready for review",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ).ToString();

                if (res == "OK")
                {
                    JobPosterDashboardUserControl.JP_MyBusiness jp_myBusiness = new JobPosterDashboardUserControl.JP_MyBusiness();
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(jp_myBusiness);
                    jp_myBusiness.Dock = DockStyle.Fill;

                }
                else
                {
                    MessageBox.Show("Failed to update business. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Failed to register business. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void review_button_Click_1(object sender, EventArgs e)
        {
            InsertBusinessDetails("Pending");
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            UpdateBusinessDetails("Pending");
        }
        private void upload_button_Click_1(object sender, EventArgs e)
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
        private void SetUpRegisterBusinessForm()
        {
            ButtonStyle.RoundedButton(attach_file, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(cancel_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(review_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(upload_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(update_button, 25, "#FFFFFF");

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;

            debounceTimer = new Timer();
            debounceTimer.Interval = 300;
            debounceTimer.Tick += DebounceTimer_Tick;

            address_input.Leave += Address_input_Leave;
            address_input.TextChanged += Address_input_TextChanged;
        }
        private void attach_file_Click_1(object sender, EventArgs e)
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

                    FlowLayoutStyles.AddFileItem(destPath, image_flowlayout, 726);
                }
            }
        }
        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_BusinessDetails jp_businessDeets = new JobPosterDashboardUserControl.JP_BusinessDetails(Session.CurrentBusinessSelected);
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_businessDeets);
            jp_businessDeets.Dock = DockStyle.Fill;
        }

        private void label4_Click(object sender, EventArgs e)
        {







        }

        private void description_richbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
