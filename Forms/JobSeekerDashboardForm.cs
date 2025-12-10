using JobNear.Controllers;
using JobNear.JobSeekerDashboardUserControl;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class JobSeekerDashboardForm : Form
    {

        public JobSeekerDashboardForm()
        {
            InitializeComponent();
            SetUpUI();
        }

        private void SetUpUI()
        {
            hideInactiveSubMenu();
            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(profile_button, "#3B82F6");
            ButtonStyle.SidebarButton(seekjob_button, "#3B82F6");
            ButtonStyle.SidebarButton(joblist_sub_button, "#3B82F6");
            ButtonStyle.SidebarButton(job_browsing_sub_button, "#3B82F6");
            ButtonStyle.SidebarButton(application_button, "#3B82F6");
            ButtonStyle.SidebarButton(logout_button, "#3B82F6");
            ButtonStyle.SidebarButton(notification_button, "#3B82F6");

            Session.CurrentSidebarPanel = sidebar_panel;

            JobSeekerDashboardUserControl.JS_Dashboard js_dashboard = new JobSeekerDashboardUserControl.JS_Dashboard();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_dashboard);
            js_dashboard.Dock = DockStyle.Fill;
        }
        private void hideInactiveSubMenu()
        {
            subSeekJob.Visible = false;
        }

        private async void seekjob_button_Click(object sender, EventArgs e)
        {
            try
            {
                var seeker = await MongoDbServices.JobSeekerAccount
                    .Find(x => x.Email == Session.CurrentEmail)
                    .FirstOrDefaultAsync();

                if (seeker == null)
                {
                    MessageBox.Show("User not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (seeker.Status != "Verified")
                {
                    MessageBox.Show("Your account is not yet verified.", "Account Not Verified", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    subSeekJob.Visible = !subSeekJob.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void job_browsing_sub_button_Click(object sender, EventArgs e)
        {
            JobSeekerDashboardUserControl.JS_JobBrowse js_jobBrowsing = new JobSeekerDashboardUserControl.JS_JobBrowse();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_jobBrowsing);
            js_jobBrowsing.Dock = DockStyle.Fill;
            Session.CurrentSeekJobSelected = "jobbrowse";
        }

        private void profile_button_Click(object sender, EventArgs e)
        {

            JobSeekerDashboardUserControl.JS_Profile js_profile = new JobSeekerDashboardUserControl.JS_Profile();
            hideInactiveSubMenu();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_profile);
            js_profile.Dock = DockStyle.Fill;
        }

        private void joblist_sub_button_Click(object sender, EventArgs e)
        {
            JobSeekerDashboardUserControl.JS_JobList js_jobList = new JobSeekerDashboardUserControl.JS_JobList();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_jobList);
            js_jobList.Dock = DockStyle.Fill;

            Session.CurrentSeekJobSelected = "joblist";
        }



        private void jobnear_button_Click(object sender, EventArgs e)
        {
            JobSeekerDashboardUserControl.JS_Notifications js_notification = new JobSeekerDashboardUserControl.JS_Notifications();
            JobSeekerDashboardUserControl.JS_Dashboard js_dashboard = new JobSeekerDashboardUserControl.JS_Dashboard();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_dashboard);
            js_dashboard.Dock = DockStyle.Fill;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }

        private void notification_button_Click(object sender, EventArgs e)
        {
            JobSeekerDashboardUserControl.JS_Notifications js_notification = new JobSeekerDashboardUserControl.JS_Notifications();
            hideInactiveSubMenu();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_notification);
            js_notification.Dock = DockStyle.Fill;
        }

        private void application_button_Click(object sender, EventArgs e)
        {
            JS_MyApplication jS_MyApplication = new JS_MyApplication();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jS_MyApplication);
            jS_MyApplication.Dock = DockStyle.Fill;
        }
    }
}
