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
using JobNear.JobSeekerDashboardUserControl;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_TermsAndPolicy : UserControl
    {
        public Admin_TermsAndPolicy()
        {
            InitializeComponent();
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
