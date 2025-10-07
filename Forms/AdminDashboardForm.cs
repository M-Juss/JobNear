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
using JobNear.Controllers;
using JobNear.Controller;

namespace JobNear.Forms
{
    public partial class AdminDashboardForm : Form
    {
        AdminDashboardUserControl.Admin_Dashboard admin_Dashboard = new AdminDashboardUserControl.Admin_Dashboard();
        AdminDashboardUserControl.Admin_JS_UserManagement admin_Jobseeker = new AdminDashboardUserControl.Admin_JS_UserManagement();
        AdminDashboardUserControl.Admin_JP_UserManagement admin_Jobposter = new AdminDashboardUserControl.Admin_JP_UserManagement();
        AdminDashboardUserControl.Admin_SystemSettings admin_Settings = new AdminDashboardUserControl.Admin_SystemSettings();
        public AdminDashboardForm()
        {
            InitializeComponent();

            hideInactiveSubMenu();

            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(dashboard_button, "#3B82F6");
            ButtonStyle.SidebarButton(user_button, "#3B82F6");
            ButtonStyle.SidebarButton(settings_button, "#3B82F6");
            ButtonStyle.SidebarButton(logout_button, "#3B82F6");
            ButtonStyle.SidebarButton(jobseekers_button, "#3B82F6");
            ButtonStyle.SidebarButton(jobposters_button, "#3B82F6");

            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Dashboard);
            admin_Dashboard.Dock = DockStyle.Fill;

            subUserManagement.Visible = false;
        }

        private void hideInactiveSubMenu()
        {
            subUserManagement.Visible = false;
        }
        private void dashboard_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Dashboard);
            admin_Dashboard.Dock = DockStyle.Fill;
            hideInactiveSubMenu();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            subUserManagement.Visible = !subUserManagement.Visible;
        }


        private void settings_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Settings);
            admin_Settings.Dock = DockStyle.Fill;
            hideInactiveSubMenu();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }

        private void jobseekers_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Jobseeker);
            admin_Jobseeker.Dock = DockStyle.Fill;
        }

        private void jobposters_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Jobposter);
            admin_Jobposter.Dock = DockStyle.Fill;
        }
    }
}
