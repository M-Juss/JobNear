using JobNear.Controllers;
using JobNear.JobPosterDashboardUserControl;
using JobNear.Styles;
using System;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class JobPosterDashboardForm : Form
    {
        JobPosterDashboardUserControl.JP_Dashboard jp_dashboard;
        public JobPosterDashboardForm()
        {
            InitializeComponent();
            SetUpUI();
        }
        private void SetUpUI()
        {
            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(dashboard_button, "#3B82F6");
            ButtonStyle.SidebarButton(business_button, "#3B82F6");
            ButtonStyle.SidebarButton(view_business_button, "#3B82F6");
            ButtonStyle.SidebarButton(review_button, "#3B82F6");
            ButtonStyle.SidebarButton(log_out_button, "#3B82F6");

            jp_dashboard = new JobPosterDashboardUserControl.JP_Dashboard();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_dashboard);
            jp_dashboard.Dock = DockStyle.Fill;
        }
        private void business_button_Click(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_RegisterBusinessForm jp_register = new JobPosterDashboardUserControl.JP_RegisterBusinessForm();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_register);
            jp_register.Dock = DockStyle.Fill;
        }

        private void view_business_button_Click(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_MyBusiness jp_myBusiness = new JobPosterDashboardUserControl.JP_MyBusiness();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_myBusiness);
            jp_myBusiness.Dock = DockStyle.Fill;
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            jp_dashboard = new JobPosterDashboardUserControl.JP_Dashboard();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_dashboard);
            jp_dashboard.Dock = DockStyle.Fill;
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }

        private void notification_button_Click_1(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_Notifications jp_notifications = new JobPosterDashboardUserControl.JP_Notifications();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_notifications);
            jp_notifications.Dock = DockStyle.Fill;
        }

        private void review_button_Click(object sender, EventArgs e)
        {
            JP_ReviewApplication jP_ReviewApplication = new JP_ReviewApplication();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jP_ReviewApplication);
            jP_ReviewApplication.Dock = DockStyle.Fill;
        }
    }
}
