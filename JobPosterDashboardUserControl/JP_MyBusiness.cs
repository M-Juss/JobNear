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
    public partial class JP_MyBusiness : UserControl
    {
        private JobPosterDashboardUserControl.JP_BusinessDetails business_details = new JobPosterDashboardUserControl.JP_BusinessDetails();
        public JP_MyBusiness()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Visible = true;
        }

        private void Sample_panel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(business_details);
            business_details.Dock = DockStyle.Fill;

            Console.Write("Working");
        }
    }
}
