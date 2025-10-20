using JobNear.Forms;
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
        //private JobPosterDashboardForm JP_parent_form;
        public JP_BusinessDetails(JobPosterDashboardForm parent_form)
        {
            InitializeComponent();
            //JP_parent_form = parent_form;
        }
        private void post_job_button_Click(object sender, EventArgs e)
        {
            //JP_parent_form.ShowPanel(JP_parent_form.post_job_form_panel);          
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            //JP_parent_form.ShowPanel(JP_parent_form.my_business_panel);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }
    }
}
