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
using JobNear.Controller;

namespace JobNear.Forms
{
    public partial class JobSeekerLoginForm : Form
    {
        public JobSeekerLoginForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(login_btn, 40, "#10B981");
        }

        private void signup_form_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobSeekerSignupForm(), app_panel);
        }


        private void JobSeekerLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }
    }
}
