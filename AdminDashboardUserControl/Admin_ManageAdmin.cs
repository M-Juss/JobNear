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
    public partial class Admin_ManageAdmin : UserControl
    {
        public Admin_ManageAdmin()
        {
            InitializeComponent();

            PanelStyles.RoundedPanel(info_panel, 20, Color.White);
            ButtonStyle.RoundedButton(submit_button, 25, "#3B82F6");
            ButtonStyle.RoundedButton(clear_button, 25, "#3B82F6");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
