using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ViewJobList : UserControl
    {
        public JS_ViewJobList(string id)
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(job_panel, 20, Color.White);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
