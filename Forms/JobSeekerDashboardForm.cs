using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;

namespace JobNear.Forms
{
    public partial class JobSeekerDashboardForm : Form
    {
        JobSeekerDashboardUserControl.JS_Dashboard js_dashboard = new JobSeekerDashboardUserControl.JS_Dashboard();
        JobSeekerDashboardUserControl.JS_Profile js_profile = new JobSeekerDashboardUserControl.JS_Profile();
        JobSeekerDashboardUserControl.JS_JobBrowse js_jobBrowsing = new JobSeekerDashboardUserControl.JS_JobBrowse();
        JobSeekerDashboardUserControl.JS_JobList js_jobList = new JobSeekerDashboardUserControl.JS_JobList();
        JobSeekerDashboardUserControl.JS_Notifications js_notification = new JobSeekerDashboardUserControl.JS_Notifications();
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
        }

        private void JobSeekerDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void hideInactiveSubMenu()
        {
            subSeekJob.Visible = false;
        }

        private void seekjob_button_Click(object sender, EventArgs e)
        {
            if (subSeekJob.Visible == false)
            {
                subSeekJob.Visible = true;
            }
            else
            {
                subSeekJob.Visible = false;
            }
        }

        private void job_browsing_sub_button_Click(object sender, EventArgs e)
        {
            hideInactiveSubMenu();
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
            sidebar_panel.Controls.Add(js_jobList);
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
    }
}
