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

namespace JobNear.Forms
{
    public partial class JobNearUserForm : Form
    {
        public JobNearUserForm()
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
    }
}
