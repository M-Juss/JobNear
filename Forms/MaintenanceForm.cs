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

namespace JobNear.Forms
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(add_button, 10, "#10B981");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
