using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_BusinessDetails : UserControl
    {
        public JP_BusinessDetails()
        {
            InitializeComponent();
            FlowLayoutStyles.AddPostJob("Senior Developer", "Fully In Office", "Full Time", "Lorem ipsum dolor sit amet. Eum consequatur itaque et quibusdam voluptatem et aspernatur explicabo. Sit eaque possimus ut repellat enim et temporibus natus ut saepe nihil et iusto odit aut animi sunt cum necessitatibus incidunt. ", joblist_flowlayout);
            FlowLayoutStyles.AddPostJob("Junior Developer", "Hybrid", "Part Time", "Lorem ipsum dolor sit amet. Eum consequatur itaque et quibusdam voluptatem et aspernatur explicabo. Sit eaque possimus ut repellat enim et temporibus natus ut saepe nihil et iusto odit aut animi sunt cum necessitatibus incidunt. ", joblist_flowlayout);
            FlowLayoutStyles.AddPostJob("Intern Developer", "Fullt Remote", "Part Time", "Lorem ipsum dolor sit amet. Eum consequatur itaque et quibusdam voluptatem et aspernatur explicabo. Sit eaque possimus ut repellat enim et temporibus natus ut saepe nihil et iusto odit aut animi sunt cum necessitatibus incidunt.", joblist_flowlayout);

            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            ButtonStyle.RoundedButton(edit_button, 20, "#3B82F6");
            ButtonStyle.RoundedButton(post_job_button, 10, "#3B82F6");

            joblist_flowlayout.FlowDirection = FlowDirection.TopDown;
            joblist_flowlayout.WrapContents = false;
            joblist_flowlayout.AutoScroll = true;

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_MyBusiness jp_myBusiness = new JobPosterDashboardUserControl.JP_MyBusiness();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_myBusiness);
            sidebar_panel.Dock = DockStyle.Fill;
        }

        private void post_job_button_Click(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_PostJobForm jp_postJob = new JobPosterDashboardUserControl.JP_PostJobForm();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_postJob);
            sidebar_panel.Dock = DockStyle.Fill;
        }
    }
}
