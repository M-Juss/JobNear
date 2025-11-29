using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ReportBusiness : UserControl
    {
        public JS_ReportBusiness(string businessSpecificId)
        {
            InitializeComponent();
            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(info_panel, 20, Color.White);
            TextboxStyles.RoundedTextBoxShadow(subject_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(description_input, 10, "#FFFFFF", 1);

            LoadSelectedBusiness(businessSpecificId);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private async void LoadSelectedBusiness(string businessId)
        {
            var businessDetails = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == businessId)
                .FirstOrDefaultAsync();

            if (businessDetails != null)
            {
                company_logo_picturebox.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);
                name_label.Text = businessDetails.BusinessName;
                description_label.Text = businessDetails.BusinessDescription;
                footer_label.Text = $"{businessDetails.BusinessAddress} | {businessDetails.BusinessEmail} | {businessDetails.BusinessContact}";
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

                    FlowLayoutStyles.AddFileItem(destPath, image_flowlayout, image_flowlayout.Width - 20);
                }
            }
        }

        private async void submit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subject_input.Text) || string.IsNullOrEmpty(description_input.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (image_flowlayout.Controls.Count == 0)
            {
                MessageBox.Show("Please attach at least one supporting document", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

            bool response = await MongoDbServices.InsertReportAsync(Session.CurrentUserId, Session.CurrentBusinessSelected, subject_input.Text.Trim(), description_input.Text.Trim(), supportingDocuments);
            if (response)
            {
                string result = MessageBox.Show(
                   "Your report has been successfully submitted. Its status is currently pending and awaiting review. Please check your notifications for updates regarding your report",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ).ToString();

                if (result == "OK")
                {

                    JobSeekerDashboardUserControl.JS_ViewBusiness view = new JobSeekerDashboardUserControl.JS_ViewBusiness(Session.CurrentBusinessSelected);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(view);
                    view.Dock = DockStyle.Fill;
                }
            }
            else
            {
                MessageBox.Show("Failed to insert report. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
