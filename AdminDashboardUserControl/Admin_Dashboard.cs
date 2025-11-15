using JobNear.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_Dashboard : UserControl
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(panel1, 20, Color.White);
            PanelStyles.RoundedPanel(panel2, 20, Color.White);
            PanelStyles.RoundedPanel(panel3, 20, Color.White);
            PanelStyles.RoundedPanel(panel4, 20, Color.White);
            PanelStyles.RoundedPanel(panel5, 20, Color.White);
        }
        

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
