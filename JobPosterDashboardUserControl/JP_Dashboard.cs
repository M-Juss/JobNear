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
    public partial class JP_Dashboard : UserControl
    {
        private JobPosterDashboardForm JP_parent_form;
        public JP_Dashboard(JobPosterDashboardForm parent_form)
        {
            InitializeComponent();
            JP_parent_form = parent_form;
        }
    }
}
