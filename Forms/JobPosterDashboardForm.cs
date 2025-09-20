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
    }
}
