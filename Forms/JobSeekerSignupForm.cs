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
            ButtonStyle.RoundedButton(register_btn, 40, "#10B981");
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            FormLoad(new JobSeekerLoginForm());
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

        private void JobSeekerSignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
