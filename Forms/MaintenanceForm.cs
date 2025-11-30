using JobNear.Styles;
using System;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(close_button, 10, "#FF5E64");
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
