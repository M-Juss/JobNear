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
        JobPosterDashboardUserControl.JP_Business business_panel = new JobPosterDashboardUserControl.JP_Business();
        JobPosterDashboardUserControl.JP_PostJobForm post_job_panel = new JobPosterDashboardUserControl.JP_PostJobForm();
        JobPosterDashboardUserControl.JP_Notifications notification_panel = new JobPosterDashboardUserControl.JP_Notifications();
        public JobPosterDashboardForm()
        {
            InitializeComponent();
        }

        private void business_button_Click(object sender, EventArgs e)
        {
            JP_main_panel.Controls.Clear();
            JP_main_panel.Controls.Add(business_panel);
            business_panel.Dock = DockStyle.Fill;
        }

        private void job_button_Click(object sender, EventArgs e)
        {
            JP_main_panel.Controls.Clear();
            JP_main_panel.Controls.Add(post_job_panel);
            post_job_panel.Dock = DockStyle.Fill;
        }

        private void notification_button_Click(object sender, EventArgs e)
        {
            JP_main_panel.Controls.Clear();
            JP_main_panel.Controls.Add(notification_panel);
            notification_panel.Dock = DockStyle.Fill;
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            // i still dont have any ideas
        }
    }
}
