using JobNear.Controllers;
using JobNear.JobPosterDashboardUserControl;
using JobNear.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.JobPosterDashboardUserControl;

namespace JobNear.Forms
{
    public partial class JobPosterDashboardForm : Form
    {
        JobPosterDashboardUserControl.JP_Dashboard jp_dashboard;
        public JobPosterDashboardForm()
        {
            InitializeComponent();

            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(dashboard_button, "#3B82F6");
            ButtonStyle.SidebarButton(business_button, "#3B82F6");
            ButtonStyle.SidebarButton(view_business_button, "#3B82F6");
            ButtonStyle.SidebarButton(notification_button, "#3B82F6");
            ButtonStyle.SidebarButton(log_out_button, "#3B82F6");

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

        private void notification_button_Click(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_Notifications jp_notifications = new JobPosterDashboardUserControl.JP_Notifications();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_notifications);
            jp_notifications.Dock = DockStyle.Fill;
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_dashboard);
            jp_dashboard.Dock = DockStyle.Fill;
        }


        private void log_out_button_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }

        private void JobPosterDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
