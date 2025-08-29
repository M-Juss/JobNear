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

namespace JobNear.Forms
{
    public partial class JobNearAdminForm_ : Form
    {
        public JobNearAdminForm_()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(login_btn, 50, "#10B981");
        }

        private void JobNearAdminForm__Load(object sender, EventArgs e)
        {

        }
    }
}
