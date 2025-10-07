using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;
using JobNear.Controller;
using JobNear.Services;

namespace JobNear.Forms
{
    public partial class JobNearAdminForm_ : Form
    {
        public JobNearAdminForm_()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(login_button, 40, "#10B981");
            TextBoxValidatorController.SetPassword(password_input);
        }

        private void JobNearAdminForm__Load(object sender, EventArgs e)
        {

        }
        private void back_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearUserForm(), app_panel);
        }

        private void app_panel_Paint(object sender, PaintEventArgs e)
        {

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
            }
            else {
                await MongoDbServices.LoginJobNearAccountAsync("admin", email_input.Text, password_input.Text, app_panel);
                
                
            }

        }

    }
}
