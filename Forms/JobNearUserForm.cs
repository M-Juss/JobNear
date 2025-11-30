using JobNear.Controller;
using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.Forms
{
    public partial class JobNearUserForm : Form
    {
        public JobNearUserForm()
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(panel, 20, Color.White);
            ButtonStyle.RoundedButton(js_button, 50, "#3B82F6");
            ButtonStyle.RoundedButton(jp_button, 50, "#3B82F6");
            ButtonStyle.RoundedButton(admin_button, 50, "#10B981");
        }

        private void js_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobSeekerLoginForm(), app_panel);
        }

        private void jp_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobPosterLoginForm(), app_panel);
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            FormsController.FormLoad(new JobNearAdminForm_(), app_panel);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
