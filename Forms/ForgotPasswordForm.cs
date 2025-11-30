using JobNear.Controller;
using JobNear.Services;
using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm(string user)
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(changepass_button, 30, "#10B981");

            PanelStyles.RoundedPanel(panel, 20, Color.White);
            TextboxStyles.RoundedTextBoxShadow(email_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedPasswordBox(newpass_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedPasswordBox(confirmnewpass_input, 10, "#FFFFFF", 1);

            newpass_input.UseSystemPasswordChar = true;
            confirmnewpass_input.UseSystemPasswordChar = true;

            changepass_button.Click += async (s, e) =>
            {
                if (!TextBoxValidatorController.ValidateEmail(email_input))
                {
                    return;
                }
                if (string.IsNullOrEmpty(email_input.Text) || string.IsNullOrEmpty(newpass_input.Text) || string.IsNullOrEmpty(confirmnewpass_input.Text))
                {
                    MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newpass_input.Text != confirmnewpass_input.Text)
                {
                    MessageBox.Show("New Password and Confirm New Password do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = await MongoDbServices.UpdateUserAccount(email_input.Text.Trim(), newpass_input.Text.Trim(), user);

                if (result)
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormsController.FormLoad(new JobNearUserForm(), app_panel);

                }
                else
                {
                    MessageBox.Show("Failed to change password. Please check your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            };

        }
        private void prev_lbl_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);

        }
    }
}
