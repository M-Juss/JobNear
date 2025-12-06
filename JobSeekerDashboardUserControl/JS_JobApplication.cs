using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
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

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;

            PanelStyles.RoundedPanel(job_panel, 20, Color.White);
            PanelStyles.RoundedPanel(details_panel, 20, Color.White);
            ButtonStyle.RoundedButton(attach_file, 25, "#F5F5F5");
            TextboxStyles.RoundedTextBoxShadow(description_input, 10, "#FFFFFF", 1);
            ButtonStyle.RoundedButton(submit_button, 10, "#10B981");


        }

        private async void LoadJobDetails() {
            try
            {
                var job = await MongoDbServices.JobPosterJobPosting
                    .Find(x => x.Id == Session.CurrentPostedJobSelected)
                    .FirstOrDefaultAsync();

                if (job != null) {
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
            catch (Exception ex) { 
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
    }
}
