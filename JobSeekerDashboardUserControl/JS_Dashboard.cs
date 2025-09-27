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
    public partial class JS_Dashboard : UserControl
    {
        public JS_Dashboard()
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(panel1, 20, Color.White);
            PanelStyles.RoundedPanel(panel2, 20, Color.White);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
