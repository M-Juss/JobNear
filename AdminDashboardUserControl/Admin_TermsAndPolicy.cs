using JobNear.JobPosterDashboardUserControl;
using JobNear.JobSeekerDashboardUserControl;
using JobNear.Styles;
using System;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_TermsAndPolicy : UserControl
    {
        public Admin_TermsAndPolicy()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(back_button, 10, "#495057");

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUserType == "admin")
            {
                Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(admin_Dashboard);
                admin_Dashboard.Dock = DockStyle.Fill;
            }
            else if (Session.CurrentUserType == "poster")
            {
                JP_Dashboard jP_Dashboard = new JP_Dashboard();
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(jP_Dashboard);
                jP_Dashboard.Dock = DockStyle.Fill;
            }
            else if (Session.CurrentUserType == "seeker")
            {
                JS_Dashboard jS_Dashboard = new JS_Dashboard();
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(jS_Dashboard);
                jS_Dashboard.Dock = DockStyle.Fill;
            }
        }
    }
}
