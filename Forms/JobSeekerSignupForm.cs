using JobNear.Controller;
using JobNear.Services;
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

namespace JobNear.Forms
{
    public partial class JobSeekerSignupForm : Form 
    {
        public JobSeekerSignupForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(register_button, 40, "#10B981");

            PanelStyles.RoundedPanel(panel, 20, Color.White);

            TextboxStyles.RoundedTextBoxShadow(username_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(phone_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(email_input, 10, "#FFFFFF", 1);

            TextboxStyles.RoundedPasswordBox(password_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedPasswordBox(confirm_input, 10, "#FFFFFF", 1);

            password_input.UseSystemPasswordChar = true;
            confirm_input.UseSystemPasswordChar = true;

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobSeekerLoginForm(), app_panel);
        }

        private async void register_button_Click(object sender, EventArgs e)
        {
            string newAccountStatus = "incomplete";
            if (string.IsNullOrEmpty(username_input.Text) || string.IsNullOrEmpty(phone_input.Text) || string.IsNullOrEmpty(email_input.Text)
                || string.IsNullOrEmpty(password_input.Text) || string.IsNullOrEmpty(confirm_input.Text)) {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                TextBoxValidatorController.ValidateEmail(email_input);
                TextBoxValidatorController.ValidatePhoneNumber(phone_input);
                if (password_input.Text == confirm_input.Text)
                {
                    if (await MongoDbServices.InsertJobSeekerAccountAsync(username_input.Text, phone_input.Text, email_input.Text, password_input.Text, newAccountStatus))
                    {
                        MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsController.FormLoad(new JobSeekerLoginForm(), app_panel);
                    }
                    else MessageBox.Show("Failed to create account. Email might already be in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Password and Confirm Password do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }

        

        private void password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //password_input.UseSystemPasswordChar = !password_checkbox.Checked;
            //confirm_input.UseSystemPasswordChar = !password_checkbox.Checked;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void app_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prev_lbl_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }
    }
}
