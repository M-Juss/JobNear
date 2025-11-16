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
            PanelStyles.RoundedPanel(registered_panel, 20, Color.White);
            PanelStyles.RoundedPanel(seekers_panel, 20, Color.White);
            PanelStyles.RoundedPanel(seekers_panel, 20, Color.White);
            PanelStyles.RoundedPanel(active_panel, 20, Color.White);
            PanelStyles.RoundedPanel(verified_panel, 20, Color.White);
            PanelStyles.RoundedPanel(pending_panel, 20, Color.White);
            PanelStyles.RoundedPanel(complaints_panel, 20, Color.White);
        }
        

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
