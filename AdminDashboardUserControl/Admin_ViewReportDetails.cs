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

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_ViewReportDetails : UserControl
    {
        public Admin_ViewReportDetails()
        {
            InitializeComponent();
            PanelStyles.StyleRoundedLabel(complainant_lbl, 5, Color.Green, Color.White);
            PanelStyles.StyleRoundedLabel(complainee_lbl, 5, Color.Orange, Color.White);
            PanelStyles.RoundedPanel(complainant_panel, 15, Color.WhiteSmoke, Color.LightGray);
            PanelStyles.RoundedPanel(complainee_panel, 15, Color.WhiteSmoke, Color.LightGray);
            PanelStyles.RoundedPanel(details_panel, 15, Color.WhiteSmoke, Color.LightGray);

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
