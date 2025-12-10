using JobNear.Controllers;
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
    public partial class JS_JobApplication : UserControl
    {
        public JS_JobApplication(string jobId)
        {
            InitializeComponent();
            LoadJobDetails();
            back_button.Visible = false;
            status_label.Visible = false;
            documents_lbl.Visible = false;
            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;
            SetUpUI();

        }

        public JS_JobApplication(string applicationId, string type)
        {
            InitializeComponent();
            LoadJobDetails();
            LoadApplicationDetails(applicationId);
            submit_button.Visible = false;
            prev_lbl.Visible = false;
            attach_file.Visible = false;
            SetUpUI();

        }

        private void SetUpUI()
        {
            PanelStyles.RoundedPanel(job_panel, 20, Color.White);
            PanelStyles.RoundedPanel(details_panel, 20, Color.White);
            ButtonStyle.RoundedButton(attach_file, 25, "#F5F5F5");
            TextboxStyles.RoundedTextBoxShadow(coverletter_input, 10, "#FFFFFF", 1);
            ButtonStyle.RoundedButton(submit_button, 10, "#10B981");
            ButtonStyle.RoundedButton(back_button, 10, "#495057");
        }
        private async void LoadApplicationDetails(string applicationId)
        {
            var getApplicationDetails = await MongoDbServices.JobApplication
                 .Find(x => x.Id == applicationId)
                 .FirstOrDefaultAsync();

            if (getApplicationDetails != null)
            {

                if (getApplicationDetails.Status == "To Review")
                {
                    UserController.SetJobApplicationStatus(status_label, "Submitted");
                }
                else UserController.SetJobApplicationStatus(status_label, getApplicationDetails.Status);

                coverletter_input.Text = getApplicationDetails.CoverLetter;

                if (getApplicationDetails.SupportingDocuments != null)
                {
                    foreach (var doc in getApplicationDetails.SupportingDocuments)
                    {
                        FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, image_flowlayout.Width - 20, "No");
                    }
                }

            }
        }
        private async void LoadJobDetails()
        {
            try
            {
                var job = await MongoDbServices.JobPosterJobPosting
                    .Find(x => x.Id == Session.CurrentPostedJobSelected)
                    .FirstOrDefaultAsync();

                if (job != null)
                {
                    string rate;
                    if (job.JobHourlyRate == 0)
                    {
                        rate = $"Monthly Salary: ₱{job.JobMonthlyRate}";
                    }
                    else rate = $"Hourly Rate: ₱{job.JobHourlyRate}";

                    jobtitle_label.Text = job.JobPosition;
                    jobinfo_label.Text = $"{job.JobWorkModel} | {job.JobEmploymentType} ";
                    rate_lbl.Text = rate;

                    about_lbl.Text = job.JobAbout;

                    applicants_lbl.Text = $"Number of applicants needed: {job.JobApplicantsNeeded}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load job details" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prev_lbl_Click(object sender, EventArgs e)
        {
            JobSeekerDashboardUserControl.JS_ViewJobList activeJobDetails = new JobSeekerDashboardUserControl.JS_ViewJobList(Session.CurrentPostedJobSelected);
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(activeJobDetails);
            activeJobDetails.Dock = DockStyle.Fill;
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
            if (string.IsNullOrEmpty(coverletter_input.Text))
            {
                MessageBox.Show("Cover letter is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            bool result = await MongoDbServices.InsertJobApplication(Session.CurrentPostedJobSelected, Session.CurrentUserId, coverletter_input.Text.Trim(), supportingDocuments);

            if (result)
            {
                string res = MessageBox.Show(
                    "Job application submitted successfully and ready for review",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                ).ToString();

                if (res == "OK")
                {
                    JobSeekerDashboardUserControl.JS_JobList js_jobList = new JobSeekerDashboardUserControl.JS_JobList();
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(js_jobList);
                    js_jobList.Dock = DockStyle.Fill;

                    Session.CurrentSeekJobSelected = "joblist";
                }
            }
            else
            {
                MessageBox.Show("Failed to submit job application. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            JS_MyApplication jS_MyApplication = new JS_MyApplication();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jS_MyApplication);
            jS_MyApplication.Dock = DockStyle.Fill;
        }

        private void job_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void job_panel_MouseClick(object sender, MouseEventArgs e)
        {
            JobSeekerDashboardUserControl.JS_ViewJobList activeJobDetails = new JobSeekerDashboardUserControl.JS_ViewJobList(Session.CurrentPostedJobSelected, "view");
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(activeJobDetails);
            activeJobDetails.Dock = DockStyle.Fill;
        }
    }
}
