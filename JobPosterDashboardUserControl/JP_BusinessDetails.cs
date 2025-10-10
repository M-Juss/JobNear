using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_BusinessDetails : UserControl
    {
        JobPosterDashboardUserControl.JP_PostJobForm post_job_form = new JobPosterDashboardUserControl.JP_PostJobForm();
        public JP_BusinessDetails()
        {
            InitializeComponent();
            
        }

        private void post_job_button_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(post_job_form);
            post_job_form.Dock = DockStyle.Fill;
            post_job_form.BringToFront();
            post_job_form.Visible = true;            
        }
    }
}
