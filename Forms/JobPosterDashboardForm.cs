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
    public partial class JobPosterDashboardForm : Form
    {
        private JobPosterDashboardUserControl.JP_RegisterBusinessForm register_business_panel = new JobPosterDashboardUserControl.JP_RegisterBusinessForm();
        private JobPosterDashboardUserControl.JP_PostJobForm post_job_panel = new JobPosterDashboardUserControl.JP_PostJobForm();
        private JobPosterDashboardUserControl.JP_Notifications notification_panel = new JobPosterDashboardUserControl.JP_Notifications();
        private JobPosterDashboardUserControl.JP_Dashboard dashboard_panel = new JobPosterDashboardUserControl.JP_Dashboard();
        private JobPosterDashboardUserControl.JP_MyBusiness my_business_panel = new JobPosterDashboardUserControl.JP_MyBusiness();
        private JobPosterDashboardUserControl.JP_BusinessDetails business_details_ = new JobPosterDashboardUserControl.JP_BusinessDetails();
        
        public JobPosterDashboardForm()
        {
            InitializeComponent();
            JP_main_panel.Controls.Add(register_business_panel);
            JP_main_panel.Controls.Add(post_job_panel);
            JP_main_panel.Controls.Add(notification_panel);
            JP_main_panel.Controls.Add(dashboard_panel);
            JP_main_panel.Controls.Add(business_details_);
            JP_main_panel.Controls.Add(my_business_panel);

            register_business_panel.Dock = DockStyle.Fill;
            register_business_panel.Hide();

            post_job_panel.Dock = DockStyle.Fill;
            post_job_panel.Hide();

            my_business_panel.Dock = DockStyle.Fill;
            my_business_panel.Hide();

            notification_panel.Dock = DockStyle.Fill;
            notification_panel.Hide();

            business_details_.Dock = DockStyle.Fill;
            business_details_.Hide();

            dashboard_panel.Dock = DockStyle.Fill;
            dashboard_panel.Show();  
        }

        private void business_button_Click(object sender, EventArgs e)
        {
            ShowPanel(register_business_panel);
        }
   
        private void view_business_button_Click(object sender, EventArgs e)
        {
            ShowPanel(my_business_panel);
        }

        private void notification_button_Click(object sender, EventArgs e)
        {
            ShowPanel(notification_panel);
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            ShowPanel(dashboard_panel);
        }

        private void ShowPanel(Control panel_to_show)
        {
            foreach (Control control in JP_main_panel.Controls)
            {
                control.Hide();
            }
            panel_to_show.BringToFront();
            panel_to_show.Show();
        }

        
    }
}
