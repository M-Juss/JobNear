using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_JobList : UserControl
    {
        public JS_JobList()
        {
            InitializeComponent();
            LoadPostedJobs();
        }

        public async void LoadPostedJobs()
        {

            var jobs = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.JobStatus == "Active")
                .ToListAsync();

            if (jobs != null)
            {

                jobs.ForEach(job =>
                {
                    FlowLayoutStyles.LoadActivePostedJob(
                        job.Id,
                        job.JobPosition,
                        job.JobWorkModel,
                        job.JobEmploymentType,
                        job.JobAbout,
                        job.JobStatus,
                        job.JobAddress,
                        postedjob_flowlayout,
                        sidebar_panel
                    );
                });
            }

        }
        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
