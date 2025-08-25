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
            TextBoxValidator.SetPassword(password_input);
            TextBoxValidator.AllowOnlyNumbers(phone_input);
        }

    }
}
