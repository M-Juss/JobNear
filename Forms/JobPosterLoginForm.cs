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
using JobNear.Controller;

namespace JobNear.Forms
{
    public partial class JobPosterLoginForm : Form
    {
        public JobPosterLoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobPosterSignupForm(), app_panel);
        }

        private void JobPosterLoginForm_Load(object sender, EventArgs e)
        {
            ButtonStyle.RoundedButton(login_btn, 40, "#10B981");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }
    }
}
