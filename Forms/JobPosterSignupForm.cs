using JobNear.Controller;
using JobNear.Services;
using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class JobPosterSignupForm : Form
    {
        public JobPosterSignupForm()
        {
            InitializeComponent();
            SetUpUI();
        }
        private void SetUpUI()
        {
            ButtonStyle.RoundedButton(register_button, 40, "#10B981");

            PanelStyles.RoundedPanel(panel, 20, Color.White);
            TextboxStyles.RoundedTextBoxShadow(username_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(email_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(phone_input, 10, "#FFFFFF", 1);

            TextboxStyles.RoundedPasswordBox(password_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedPasswordBox(confirm_input, 10, "#FFFFFF", 1);

            password_input.UseSystemPasswordChar = true;
            confirm_input.UseSystemPasswordChar = true;

        }
        private void login_label_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobPosterLoginForm(), app_panel);
        }
        private async void register_button_Click(object sender, EventArgs e)
        {
            if (!TextBoxValidatorController.ValidateEmail(email_input))
            {
                return;
            }
            if (!TextBoxValidatorController.ValidatePhoneNumber(phone_input))
            {
                return;
            }
            TextBoxValidatorController.AllowOnlyNumbers(phone_input);

            if (string.IsNullOrEmpty(phone_input.Text) || string.IsNullOrEmpty(email_input.Text)
            || string.IsNullOrEmpty(username_input.Text) || string.IsNullOrEmpty(password_input.Text) || string.IsNullOrEmpty(confirm_input.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                if (password_input.Text == confirm_input.Text)
                {
                    if (await MongoDbServices.InsertJobPosterAccountAsync(username_input.Text.Trim(), email_input.Text.Trim(), phone_input.Text.Trim(), password_input.Text.Trim()))
                    {
                        MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsController.FormLoad(new JobPosterLoginForm(), app_panel);
                    }
                    else
                    {
                        MessageBox.Show("Failed to create account. Email might already be in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void prev_lbl_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }
    }
}
