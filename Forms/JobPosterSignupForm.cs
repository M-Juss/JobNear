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
        }

        private void JobPosterLoginForm_Load(object sender, EventArgs e)
        {
            ButtonStyle.RoundedButton(register_button, 40, "#10B981");
            TextBoxValidatorController.SetPassword(password_input);
            TextBoxValidatorController.SetPassword(confirm_input);
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

        private void register_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phone_input.Text) || string.IsNullOrEmpty(email_input.Text)
        || string.IsNullOrEmpty(password_input.Text) || string.IsNullOrEmpty(confirm_input.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (TextBoxValidatorController.ValidatePhoneNumber(phone_input))
                {
                    if (TextBoxValidatorController.ValidateEmail(email_input))
                    {
                        if (password_input.Text == confirm_input.Text)
                        {
                            if (MongoDbServices.InsertJobPosterAccount(phone_input.Text, email_input.Text, password_input.Text))
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
                    else
                    {
                        MessageBox.Show("Please enter a valid email address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            password_input.UseSystemPasswordChar = !password_checkbox.Checked;
            confirm_input.UseSystemPasswordChar = !password_checkbox.Checked;
        }
    }
}
