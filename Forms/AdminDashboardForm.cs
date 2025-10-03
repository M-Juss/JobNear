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
        AdminDashboardUserControl.Admin_UserManagement admin_Users = new AdminDashboardUserControl.Admin_UserManagement();
        AdminDashboardUserControl.Admin_SystemSettings admin_Settings = new AdminDashboardUserControl.Admin_SystemSettings();
        public AdminDashboardForm()
        {
            InitializeComponent();
            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(dashboard_button, "#3B82F6");
            ButtonStyle.SidebarButton(user_button, "#3B82F6");
            ButtonStyle.SidebarButton(settings_button, "#3B82F6");
            ButtonStyle.SidebarButton(logout_button, "#3B82F6");
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            side_panel.Controls.Clear();
            side_panel.Controls.Add(admin_Dashboard);
            admin_Dashboard.Dock = DockStyle.Fill;
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            side_panel.Controls.Clear();
            side_panel.Controls.Add(admin_Users);
            admin_Users.Dock = DockStyle.Fill;
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            side_panel.Controls.Clear();
            side_panel.Controls.Add(admin_Settings);
            admin_Settings.Dock = DockStyle.Fill;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }
    }
}
