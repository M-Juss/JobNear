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
using JobNear.Services;
using JobNear.Controllers;
using MongoDB.Driver;
using JobNear.Models;

namespace JobNear.Forms
{
    public partial class JobSeekerLoginForm : Form
    {
        public JobSeekerLoginForm()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(login_button, 40, "#10B981");
        }

        private void JobSeekerLoginForm_Load(object sender, EventArgs e)
        {
            TextBoxValidatorController.SetPassword(password_input);
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
            FormsController.FormLoad(new ForgotPasswordForm(), app_panel);
        }

        private void password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            password_input.UseSystemPasswordChar = !password_checkbox.Checked;
        }

private async void login_button_Click(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(email_input.Text) || string.IsNullOrEmpty(password_input.Text))
    {
        MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    await MongoDbServices.LoginJobNearAccountAsync("jobseeker", email_input.Text, password_input.Text, app_panel);

        }

    }
}
