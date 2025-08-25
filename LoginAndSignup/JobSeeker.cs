using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear
{
    public partial class JobSeeker : Form
    {
        public JobSeeker()
        {
            InitializeComponent();
            password_input.PasswordChar = '*';

        }

        private void phone_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) {
                e.Handled = true;
            }

        }
    }
}
