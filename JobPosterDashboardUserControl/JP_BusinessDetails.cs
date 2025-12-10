using JobNear.Controllers;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_BusinessDetails : UserControl
    {
        public JP_BusinessDetails(string businessId)
        {
            InitializeComponent();

            LoadSelectedBusiness(businessId);
            status_combo.SelectedIndex = 0;
            SetUpUI();


            edit_button.Click += (s, e) =>
            {
                JP_RegisterBusinessForm jp_registerform = new JP_RegisterBusinessForm(businessId);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(jp_registerform);
                jp_registerform.Dock = DockStyle.Fill;
            };

            post_job_button.Click += async (s, e) =>
            {
                var businessDetails = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == businessId)
                .FirstOrDefaultAsync();

                if (businessDetails != null)
                {
                    if (!businessDetails.Status.Equals("Verified"))
                    {
                        MessageBox.Show("Business must be Verified to post a job!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string mode = "insert";
                        Session.CurrentPostJobFormMode = mode;
                        JobPosterDashboardUserControl.JP_PostJobForm jp_postJob = new JobPosterDashboardUserControl.JP_PostJobForm(Session.CurrentBusinessSelected);
                        sidebar_panel.Controls.Clear();
                        sidebar_panel.Controls.Add(jp_postJob);
                        sidebar_panel.Dock = DockStyle.Fill;
                    }
                }


            };
        }

        private void SetUpUI()
        {
            PanelStyles.RoundedPanel(business_panel, 10, Color.White);
            ButtonStyle.RoundedButton(edit_button, 10, "#3B82F6");
            ButtonStyle.RoundedButton(post_job_button, 10, "#3B82F6");

            UserController.SetSeekerAndBusinesStatus(status_lbl, status_lbl.Text);
            PanelStyles.StyleRoundedLabel(status_lbl, 5);

            joblist_flowlayout.FlowDirection = FlowDirection.TopDown;
            joblist_flowlayout.WrapContents = false;
            joblist_flowlayout.AutoScroll = true;
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
                footer_label.Text = businessDetails.BusinessAddress;
                status_lbl.Text = businessDetails.Status;

                UserController.SetSeekerAndBusinesStatus(status_lbl, businessDetails.Status);
            }
        }

        private async void LoadPostedJobs(string businessId, string status)
        {
            if (status == "All")
            {
                var postJobs = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.BusinessId == businessId)
                .ToListAsync();

                if (postJobs != null)
                {
                    postJobs.ForEach(job =>
                    {
                        FlowLayoutStyles.AddPostJob(
                            job.Id,
                            job.JobPosition,
                            job.JobWorkModel,
                            job.JobEmploymentType,
                            job.JobAbout,
                            job.JobStatus,
                            joblist_flowlayout,
                            sidebar_panel
                        );
                    });
                }
            }

            var postedJobs = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.BusinessId == businessId && x.JobStatus == status)
                .ToListAsync();

            if (postedJobs != null)
            {
                postedJobs.ForEach(job =>
                {
                    FlowLayoutStyles.AddPostJob(
                        job.Id,
                        job.JobPosition,
                        job.JobWorkModel,
                        job.JobEmploymentType,
                        job.JobAbout,
                        job.JobStatus,
                        joblist_flowlayout,
                        sidebar_panel
                    );
                });
            }
        }


        private void prev_lbl_Click(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_MyBusiness jp_myBusiness = new JobPosterDashboardUserControl.JP_MyBusiness();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_myBusiness);
            sidebar_panel.Dock = DockStyle.Fill;
        }

        private void status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = status_combo.SelectedItem.ToString();
            joblist_flowlayout.Controls.Clear();
            LoadPostedJobs(Session.CurrentBusinessSelected, status);
        }

        private void post_job_button_Click(object sender, EventArgs e)
        {

        }
    }
}
