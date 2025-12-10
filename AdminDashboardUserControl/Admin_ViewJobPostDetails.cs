using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_ViewJobPostDetails : UserControl
    {
        public Admin_ViewJobPostDetails(string jobId)
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(status_panel, 20, Color.White);
            PanelStyles.RoundedPanel(job_panel, 20, Color.White);
            ButtonStyle.RoundedButton(submit_button, 10, "#10B981");
            ButtonStyle.RoundedButton(cancel_button, 10, "#495057");
            LoadJobDetails(jobId);
        }

        private async void LoadJobDetails(string jobId)
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
                jobinfo_label.Text = $"{job.JobWorkModel} | {job.JobEmploymentType}";
                rate_lbl.Text = rate;

                about_label.Text = job.JobAbout;
                responsibilities_label.Text = job.JobResponsibilities;
                preffered_label.Text = job.JobPreferredQualification;
                minimum_label.Text = job.JobMinimumQualification;

                applicants_lbl.Text = $"Number of applicants needed: {job.JobApplicantsNeeded}";
            }
        }

        private void cancel_button_Click(object sender, System.EventArgs e)
        {
            Admin_JobPostingMangement admin_JobPostingMangement = new Admin_JobPostingMangement();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_JobPostingMangement);
            admin_JobPostingMangement.Dock = DockStyle.Fill;
        }

        private async void submit_button_Click(object sender, System.EventArgs e)
        {
            string status = status_combo.SelectedItem.ToString();

            string key = "Admin";
            DateTime date = DateTime.Now;
            string remarks = remarks_richtext.Text.ToString().ToLower();

            var getJob = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == Session.CurrentPostedJobSelected)
                .FirstOrDefaultAsync();

            var getBusiness = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == getJob.BusinessId)
                .FirstOrDefaultAsync();

            switch (status.ToLower())
            {
                case "active":
                    string activeMessage = $"The job {jobtitle_label.Text} that you submitted has been successfully activated and is now visible to applicants.";
                    string activeType = "success";

                    var activeNotif = new UserNotificationModel
                    {
                        NotificationId = getBusiness.BusinessId,
                        Key = key,
                        HeaderMessage = activeMessage,
                        Remarks = remarks,
                        Type = activeType,
                        Date = date
                    };

                    await MongoDbServices.UserNotification.InsertOneAsync(activeNotif);

                    var getPostedJob = Builders<JobPosterJobPostingModel>.Filter.Eq(x => x.Id, Session.CurrentPostedJobSelected);

                    if (getPostedJob != null)
                    {
                        var updateJob = Builders<JobPosterJobPostingModel>.Update
                            .Set(x => x.JobStatus, status);

                        await MongoDbServices.JobPosterJobPosting.UpdateOneAsync(getPostedJob, updateJob);
                        MessageBox.Show($"Job {jobtitle_label.Text} status has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sidebar_panel.Controls.Clear();
                        sidebar_panel.Controls.Add(new Admin_JobPostingMangement());
                        sidebar_panel.Dock = DockStyle.Fill;

                    }
                    else MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    break;
                case "rejected":
                    string rejectedMessage = $"After careful review, your job {jobtitle_label.Text} has not been approved for publication. Please revise and resubmit if appropriate.”";
                    string rejectedType = "error";

                    var rejectedNotif = new UserNotificationModel
                    {
                        NotificationId = getBusiness.BusinessId,
                        Key = key,
                        HeaderMessage = rejectedMessage,
                        Remarks = remarks,
                        Type = rejectedMessage,
                        Date = date
                    };

                    await MongoDbServices.UserNotification.InsertOneAsync(rejectedNotif);

                    var getPostJob = Builders<JobPosterJobPostingModel>.Filter.Eq(x => x.Id, Session.CurrentPostedJobSelected);

                    if (getPostJob != null)
                    {
                        var updateJob = Builders<JobPosterJobPostingModel>.Update
                            .Set(x => x.JobStatus, status);

                        await MongoDbServices.JobPosterJobPosting.UpdateOneAsync(getPostJob, updateJob);
                        MessageBox.Show($"Job {jobtitle_label.Text} status has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sidebar_panel.Controls.Clear();
                        sidebar_panel.Controls.Add(new Admin_JobPostingMangement());
                        sidebar_panel.Dock = DockStyle.Fill;

                    }
                    else MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }
        }
    }
}
