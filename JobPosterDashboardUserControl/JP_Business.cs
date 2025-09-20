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
    public partial class JP_Business : UserControl
    {
        public JP_Business()
        {
            InitializeComponent();
        }

        private void add_business_button_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new JobPosterDashboardUserControl.JP_RegisterBusinessForm());
            this.Dock = DockStyle.Fill;
        }
    }
}
