using JobNear.Controller;
using JobNear.Services;
using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class JobSeekerLoginForm : Form
    {
        public JobSeekerLoginForm()
        {
            InitializeComponent();
            SetUpUI();
        }

        private void SetUpUI()
        {
            ButtonStyle.RoundedButton(login_button, 40, "#10B981");

            PanelStyles.RoundedPanel(panel, 20, Color.White);

            TextboxStyles.RoundedTextBoxShadow(email_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedPasswordBox(password_input, 10, "#FFFFFF", 1);


            password_input.UseSystemPasswordChar = true;
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }

        private void signup_label_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobSeekerSignupForm(), app_panel);
        }

        private void forgot_label_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new ForgotPasswordForm("jobseeker"), app_panel);
        }

        private async void login_button_Click(object sender, EventArgs e)
        {
            if (!TextBoxValidatorController.ValidateEmail(email_input))
            {
                return;
            }
            if (string.IsNullOrEmpty(email_input.Text) || string.IsNullOrEmpty(password_input.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await MongoDbServices.LoginJobNearAccountAsync("jobseeker", email_input.Text, password_input.Text, app_panel);

        }

        private void prev_lbl_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);

        }
    }
}
