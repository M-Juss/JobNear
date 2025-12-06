using JobNear.Controllers;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ViewJobList : UserControl
    {
        public JS_ViewJobList(string id)
        {
            InitializeComponent();

            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(job_panel, 20, Color.White);
            PanelStyles.StyleRoundedLabel(apply_label, 5, ColorTranslator.FromHtml("#10B981"), Color.White);

            LoadJobDetails(id);
            LoadBusinessDetails(id);
        }

        public async void LoadBusinessDetails(string businessId)
        {

            var job = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == businessId)
                .FirstOrDefaultAsync();

            if (job != null)
            {
                var businessDetails = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Id == job.BusinessId)
                    .FirstOrDefaultAsync();

                if (businessDetails != null)
                {
                    Session.CurrentBusinessSelected = businessDetails.Id;
                    company_logo_picturebox.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);
                    name_label.Text = businessDetails.BusinessName;
                    description_label.Text = businessDetails.BusinessDescription;
                    footer_label.Text = businessDetails.BusinessAddress;
                }
            }

        }
        public async void LoadJobDetails(string jobId)
        {
            var job = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == jobId)
                .FirstOrDefaultAsync();

            if (job != null)
            {
                Session.CurrentPostedJobSelected = job.Id;

                string rate;
                if (job.JobHourlyRate == 0)
                {
                    rate = $"Monthly Salary: ₱{job.JobMonthlyRate}";
                }
                else rate = $"Hourly Rate: ₱{job.JobHourlyRate}";

                jobtitle_label.Text = job.JobPosition;
                jobinfo_label.Text = $"{job.JobWorkModel} | {job.JobEmploymentType} | {rate} ";

                about_label.Text = job.JobAbout;
                responsibilities_label.Text = job.JobResponsibilities;
                preffered_label.Text = job.JobPreferredQualification;
                minimum_label.Text = job.JobMinimumQualification;

                applicants_lbl.Text = $"Number of applicants needed: {job.JobApplicantsNeeded}";

            }
        }

        private void prev_lbl_Click(object sender, EventArgs e)
        {
            if (Session.CurrentSeekJobSelected == "joblist")
            {
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(new JS_JobList());
                new JS_JobList().Dock = DockStyle.Fill;
            }
            else if (Session.CurrentSeekJobSelected == "jobbrowse")
            {
                JS_ViewBusiness jS_ViewBusiness = new JS_ViewBusiness(Session.CurrentBusinessSelected);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(jS_ViewBusiness);
                jS_ViewBusiness.Dock = DockStyle.Fill;
            }
        }

        private void business_panel_Click(object sender, EventArgs e)
        {
            JS_ViewBusinessProfile jS_ViewBusinessProfile = new JS_ViewBusinessProfile("joblist");
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jS_ViewBusinessProfile);
            jS_ViewBusinessProfile.Dock = DockStyle.Fill;
        }

        private async void apply_label_Click(object sender, EventArgs e)
        {
            var getJobApplicationInformation = await MongoDbServices.JobApplication
                .Find(x => x.JobId == Session.CurrentPostedJobSelected && x.SeekerId == Session.CurrentUserId && x.Status == "Pending" && x.isSubmissionActive == true)
                .FirstOrDefaultAsync();

            if (getJobApplicationInformation != null) {
                MessageBox.Show("You currently have active proposal in this job. Please check Business response.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            JS_JobApplication jS_JobApplication = new JS_JobApplication(Session.CurrentPostedJobSelected);
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jS_JobApplication);
            jS_JobApplication.Dock = DockStyle.Fill;
        }
    }
}
