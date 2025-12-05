using JobNear.Controllers;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            CheckIfSuperAdminOrAdmin();
            SetUpUI();

        }
        private void SetUpUI()
        {
            hideInactiveSubMenu();

            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(dashboard_button, "#3B82F6");
            ButtonStyle.SidebarButton(user_button, "#3B82F6");
            ButtonStyle.SidebarButton(reports_button, "#3B82F6");
            ButtonStyle.SidebarButton(logout_button, "#3B82F6");
            ButtonStyle.SidebarButton(jobseekers_button, "#3B82F6");
            ButtonStyle.SidebarButton(jobposters_button, "#3B82F6");
            ButtonStyle.SidebarButton(settings_button, "#3B82F6");
            ButtonStyle.SidebarButton(manageAdmin_button, "#3B82F6");
            ButtonStyle.SidebarButton(verificationReq_button, "#3B82F6");
            ButtonStyle.SidebarButton(controlSite_button, "#3B82F6");

            AdminDashboardUserControl.Admin_Dashboard admin_Dashboard = new AdminDashboardUserControl.Admin_Dashboard();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Dashboard);
            admin_Dashboard.Dock = DockStyle.Fill;

            subUserManagement.Visible = false;
            subSystemSettings.Visible = false;
        }
        private async void CheckIfSuperAdminOrAdmin()
        {
            try
            {
                var admin = await MongoDbServices.AdminAccount
                    .Find(x => x.Email == Session.CurrentEmail)
                    .FirstOrDefaultAsync();
                if (admin != null)
                {
                    if (admin.Role == "Super Admin")
                    {
                        manageAdmin_button.Visible = true;
                    }
                    else
                    {
                        manageAdmin_button.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking admin role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hideInactiveSubMenu()
        {
            subUserManagement.Visible = false;
            subSystemSettings.Visible = false;
        }
        private void dashboard_button_Click(object sender, EventArgs e)
        {
            hideInactiveSubMenu();
            AdminDashboardUserControl.Admin_Dashboard admin_Dashboard = new AdminDashboardUserControl.Admin_Dashboard();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Dashboard);
            admin_Dashboard.Dock = DockStyle.Fill;

        }

        private void user_button_Click(object sender, EventArgs e)
        {
            subUserManagement.Visible = !subUserManagement.Visible;
        }


        private void logout_button_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }

        private void jobseekers_button_Click(object sender, EventArgs e)
        {
            AdminDashboardUserControl.Admin_JS_UserManagement admin_Jobseeker = new AdminDashboardUserControl.Admin_JS_UserManagement();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Jobseeker);
            admin_Jobseeker.Dock = DockStyle.Fill;
        }

        private void jobposters_button_Click(object sender, EventArgs e)
        {
            AdminDashboardUserControl.Admin_JP_UserManagement admin_Jobposter = new AdminDashboardUserControl.Admin_JP_UserManagement();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Jobposter);
            admin_Jobposter.Dock = DockStyle.Fill;
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            subSystemSettings.Visible = !subSystemSettings.Visible;
        }

        private void reports_button_Click(object sender, EventArgs e)
        {
            AdminDashboardUserControl.Admin_ReportsAndComplaints admin_Reports = new AdminDashboardUserControl.Admin_ReportsAndComplaints();
            hideInactiveSubMenu();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Reports);
            admin_Reports.Dock = DockStyle.Fill;

        }
        private void manageAdmin_button_Click(object sender, EventArgs e)
        {
            AdminDashboardUserControl.Admin_ManageAdmin admin_Manage = new AdminDashboardUserControl.Admin_ManageAdmin();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_Manage);
            admin_Manage.Dock = DockStyle.Fill;

        }

        private void verificationReq_button_Click(object sender, EventArgs e)
        {
            AdminDashboardUserControl.Admin_VerifyRequirement admin_VerifyRequirement = new AdminDashboardUserControl.Admin_VerifyRequirement();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_VerifyRequirement);
            admin_VerifyRequirement.Dock = DockStyle.Fill;
        }

        private async void controlSite_button_Click(object sender, EventArgs e)
        {
            var getControlSite = await MongoDbServices.ControlSiteNotification
                .Find(_ => true)
                .FirstOrDefaultAsync();

            if (getControlSite != null)
            {
                AdminDashboardUserControl.Admin_ControlSiteSettings admin_ControlSiteSettings = new AdminDashboardUserControl.Admin_ControlSiteSettings(getControlSite.Id);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(admin_ControlSiteSettings);
                admin_ControlSiteSettings.Dock = DockStyle.Fill;
            }
            else
            {
                AdminDashboardUserControl.Admin_ControlSiteSettings admin_ControlSiteSettings = new AdminDashboardUserControl.Admin_ControlSiteSettings();
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(admin_ControlSiteSettings);
                admin_ControlSiteSettings.Dock = DockStyle.Fill;
            }

        }

        private void jobnear_button_Click(object sender, EventArgs e)
        {

        }
    }
}
