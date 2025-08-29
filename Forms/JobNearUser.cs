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
    public partial class JobNearUser : Form
    {
        public JobNearUser()
        {
            InitializeComponent();
        }

        private void JobNearUser_Load(object sender, EventArgs e)
        {
            ButtonStyle.RoundedButton(js_button, 50, "#3B82F6");
            ButtonStyle.RoundedButton(jp_button, 50, "#3B82F6");
            ButtonStyle.RoundedButton(admin_button, 50, "#10B981");
        }

        private void js_button_Click(object sender, EventArgs e)
        {
            FormLoad(new JobSeekerLoginForm());
        }



        private void jp_button_Click(object sender, EventArgs e)
        {
            FormLoad(new JobPosterLoginForm());
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

        private void admin_button_Click(object sender, EventArgs e)
        {
            FormLoad(new JobNearAdminForm_());
        }
    }
}
