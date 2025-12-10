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
                        FlowLayoutStyles.LoadPendingPostedJob(pendings.Id, pendings.JobPosition, pendings.JobWorkModel, pendings.JobEmploymentType, pendings.JobApplicantsNeeded, pendings.JobAbout, pendings.JobStatus, job_flowlayout, sidebar_panel);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("");
            }
        }

    }
}
