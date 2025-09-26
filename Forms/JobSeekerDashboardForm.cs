using JobNear.JobSeekerDashboardUserControl;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class JobSeekerDashboardForm : Form
    {
        JobSeekerDashboardUserControl.JS_Dashboard js_dashboard = new JobSeekerDashboardUserControl.JS_Dashboard();
        JobSeekerDashboardUserControl.JS_Profile js_profile = new JobSeekerDashboardUserControl.JS_Profile();
        JobSeekerDashboardUserControl.JS_JobBrowse js_jobBrowsing = new JobSeekerDashboardUserControl.JS_JobBrowse();
        JobSeekerDashboardUserControl.JS_JobList js_jobList = new JobSeekerDashboardUserControl.JS_JobList();
        JobSeekerDashboardUserControl.JS_Notifications js_notification = new JobSeekerDashboardUserControl.JS_Notifications();
        JobSeekerDashboardUserControl.UserControlPractice prac = new JobSeekerDashboardUserControl.UserControlPractice();
        public JobSeekerDashboardForm()
        {
            InitializeComponent();
            hideInactiveSubMenu();
            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(profile_button, "#3B82F6");
            ButtonStyle.SidebarButton(seekjob_button, "#3B82F6");
            ButtonStyle.SidebarButton(joblist_sub_button, "#3B82F6");
            ButtonStyle.SidebarButton(job_browsing_sub_button, "#3B82F6");
            ButtonStyle.SidebarButton(notification_button, "#3B82F6");
            ButtonStyle.SidebarButton(logout_button, "#3B82F6");

            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_dashboard);
            js_dashboard.Dock = DockStyle.Fill;

        }

        private void JobSeekerDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void hideInactiveSubMenu()
        {
            subSeekJob.Visible = false;
        }

        private async void seekjob_button_Click(object sender, EventArgs e)
        {
            subSeekJob.Visible = !subSeekJob.Visible; // ✅ toggle visibility in one line
            //try
            //{
            //    var seeker = await MongoDbServices.JobSeekerAccount
            //        .Find(x => x.Email == Session.CurrentEmail)
            //        .FirstOrDefaultAsync();

            //    if (seeker == null)
            //    {
            //        MessageBox.Show("User not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    if (!seeker.IsVerified)
            //    {
            //        MessageBox.Show("Your account is not yet verified.", "Account Not Verified", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        subSeekJob.Visible = !subSeekJob.Visible; // ✅ toggle visibility in one line
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error fetching user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void job_browsing_sub_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_jobBrowsing);
            js_jobBrowsing.Dock = DockStyle.Fill;
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            hideInactiveSubMenu();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_profile);
            js_profile.Dock = DockStyle.Fill;
        }

        private void joblist_sub_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(prac);
            js_jobList.Dock = DockStyle.Fill;
        }

        private void notification_button_Click(object sender, EventArgs e)
        {
            hideInactiveSubMenu();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_notification);
            js_notification.Dock = DockStyle.Fill;
        }

        private void jobnear_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_dashboard);
            js_dashboard.Dock = DockStyle.Fill;
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
