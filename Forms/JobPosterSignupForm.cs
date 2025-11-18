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
    public partial class JobPosterSignupForm : Form
    {
        public JobPosterSignupForm()
        {
            InitializeComponent();


            ButtonStyle.RoundedButton(register_button, 40, "#10B981");
            TextBoxValidatorController.SetPassword(password_input);
            TextBoxValidatorController.SetPassword(confirm_input);

            TextboxStyles.RoundedTextBoxShadow(username_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(email_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(phone_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(password_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(confirm_input, 10, "#FFFFFF", 1);



        }

        private void JobPosterLoginForm_Load(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobPosterLoginForm(), app_panel);
        }

        private void email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private async void register_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phone_input.Text) || string.IsNullOrEmpty(email_input.Text)
            || string.IsNullOrEmpty(username_input.Text) || string.IsNullOrEmpty(password_input.Text) || string.IsNullOrEmpty(confirm_input.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TextBoxValidatorController.ValidateEmail(email_input);
                TextBoxValidatorController.ValidatePhoneNumber(phone_input);
                if (password_input.Text == confirm_input.Text)
                {
                    if (await MongoDbServices.InsertJobPosterAccountAsync(username_input.Text.Trim(), email_input.Text.Trim(), phone_input.Text.Trim(), password_input.Text.Trim()))
                    {
                        MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsController.FormLoad(new JobSeekerLoginForm(), app_panel);
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

        private void password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            password_input.UseSystemPasswordChar = !password_checkbox.Checked;
            confirm_input.UseSystemPasswordChar = !password_checkbox.Checked;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void app_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_input_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void phone_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_input_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void confirm_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
