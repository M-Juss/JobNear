using System;
using MongoDB.Driver;
using System.Windows.Forms;
using JobNear.Services;
using JobNear.Styles;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_JobPostingMangement : UserControl
    {
        public Admin_JobPostingMangement()
        {
            InitializeComponent();
            LoadPendingJobPosts();
        }

        private async void LoadPendingJobPosts()
        {
            try
            {
                var pendingPost = await MongoDbServices.JobPosterJobPosting
                    .Find(x => x.JobStatus == "Pending")
                    .ToListAsync();

                if(pendingPost.Count > 0)
                {
                    foreach (var pendings in pendingPost) {

                        string rate;
                        if (pendings.JobHourlyRate == 0)
                        {
                            rate = $"Monthly Salary: ₱{pendings.JobMonthlyRate}";
                        }
                        else rate = $"Hourly Rate: ₱{pendings.JobHourlyRate}";

                        FlowLayoutStyles.LoadPendingPostedJob(pendings.Id, pendings.JobPosition, pendings.JobWorkModel, pendings.JobEmploymentType, rate, pendings.JobApplicantsNeeded, pendings.JobAbout, pendings.JobStatus, job_flowlayout, sidebar_panel);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("");
            }
        }

    }
}
