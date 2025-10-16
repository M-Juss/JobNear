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
    public partial class JP_Notifications : UserControl
    {
        private JobPosterDashboardForm JP_parent_form;
        public JP_Notifications(JobPosterDashboardForm parent_form)
        {
            InitializeComponent();
            JP_parent_form = parent_form;
        }

        private void JP_Notifications_Load(object sender, EventArgs e)
        {

        }
    }
}
