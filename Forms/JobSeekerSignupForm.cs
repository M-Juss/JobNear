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
    public partial class JobSeekerSignupForm : Form 
    {
        public JobSeekerSignupForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(register_btn, 40, "#10B981");
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobSeekerLoginForm(), app_panel);
        }


        private void JobSeekerSignupForm_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }
    }
}
