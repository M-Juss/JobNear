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

namespace JobNear.Forms
{
    public partial class JobPosterLoginForm : Form
    {
        public JobPosterLoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            FormLoad(new JobPosterSignupForm());
        }

        private void FormLoad(Form form)
        {
            app_panel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            app_panel.Controls.Add(form);
            form.Show();
        }

        private void JobPosterLoginForm_Load(object sender, EventArgs e)
        {
            ButtonStyle.RoundedButton(login_btn, 40, "#10B981");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            FormLoad(new JobNearUser());
        }
    }
}
