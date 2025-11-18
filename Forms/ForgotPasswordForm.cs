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
using JobNear.Styles;

namespace JobNear.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(changepass_button, 30, "#3B82F6");

            TextboxStyles.RoundedTextBoxShadow(email_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(newpass_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(confirmnewpass_input, 10, "#FFFFFF", 1);

        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }

        private void changepass_button_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
