using JobNear.Controllers;
using JobNear.JobPosterDashboardUserControl;
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
    public partial class JobPosterDashboardForm : Form
    {
        //public JP_RegisterBusinessForm register_business_panel;
        //public JP_PostJobForm post_job_form_panel;
        //public JP_Notifications notification_panel;
        //public JP_Dashboard dashboard_panel;
        //public JP_MyBusiness my_business_panel;
        //public JP_BusinessDetails business_details_panel;

        public JobPosterDashboardForm()
        {
            InitializeComponent();

            ButtonStyle.SidebarButton(jobnear_button, "#3B82F6");
            ButtonStyle.SidebarButton(dashboard_button, "#3B82F6");
            ButtonStyle.SidebarButton(business_button, "#3B82F6");
            ButtonStyle.SidebarButton(view_business_button, "#3B82F6");
            ButtonStyle.SidebarButton(notification_button, "#3B82F6");
            ButtonStyle.SidebarButton(log_out_button, "#3B82F6");


            //register_business_panel = new JP_RegisterBusinessForm(this);
            //post_job_form_panel = new JP_PostJobForm(this);
            //notification_panel = new JP_Notifications(this);
            //dashboard_panel = new JP_Dashboard(this);
            //business_details_panel = new JP_BusinessDetails(this);

            //JP_main_panel.Controls.Add(register_business_panel);
            //JP_main_panel.Controls.Add(post_job_form_panel);
            //JP_main_panel.Controls.Add(notification_panel);
            //JP_main_panel.Controls.Add(dashboard_panel);
            //JP_main_panel.Controls.Add(business_details_panel);
            //JP_main_panel.Controls.Add(my_business_panel);

            //register_business_panel.Dock = DockStyle.Fill;
            //register_business_panel.Visible = false;

            //post_job_form_panel.Dock = DockStyle.Fill;
            //post_job_form_panel.Visible = false;


            //notification_panel.Dock = DockStyle.Fill;
            //notification_panel.Visible = false;

            //business_details_panel.Dock = DockStyle.Fill;
            //business_details_panel.Visible = false;

            //dashboard_panel.Dock = DockStyle.Fill;
            //dashboard_panel.Visible = true;

        }

        private void business_button_Click(object sender, EventArgs e)
        {
            //ShowPanel(register_business_panel);
        }

        private void view_business_button_Click(object sender, EventArgs e)
        {
            //ShowPanel(my_business_panel);
        }

        private void notification_button_Click(object sender, EventArgs e)
        {
            //ShowPanel(notification_panel);
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            //ShowPanel(dashboard_panel);
        }

        public void ShowPanel(Control panel_to_show)
        {
            foreach (Control control in JP_main_panel.Controls)
            {
                control.Visible = false;
            }
            panel_to_show.BringToFront();
            panel_to_show.Visible = true;
        }

        private void JP_sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JP_main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            UserController.LogoutUser();
        }

        private void JobPosterDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
