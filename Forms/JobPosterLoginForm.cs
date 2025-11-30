using JobNear.Controller;
using JobNear.Services;
using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class JobPosterLoginForm : Form
    {
        public JobPosterLoginForm()
        {
            InitializeComponent();
            SetUpUI();
        }
        private void SetUpUI()
        {

            PanelStyles.RoundedPanel(panel, 20, Color.White);
            ButtonStyle.RoundedButton(login_button, 40, "#10B981");

            TextboxStyles.RoundedTextBoxShadow(email_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedPasswordBox(password_input, 10, "#FFFFFF", 1);

            password_input.UseSystemPasswordChar = true;
        }

        private void signup_label_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobPosterSignupForm(), app_panel);
        }

        private void forgot_label_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new ForgotPasswordForm("jobposter"), app_panel);
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
            await MongoDbServices.LoginJobNearAccountAsync("jobposter", email_input.Text, password_input.Text, app_panel);
        }

        private void prev_lbl_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);

        }
    }
}
