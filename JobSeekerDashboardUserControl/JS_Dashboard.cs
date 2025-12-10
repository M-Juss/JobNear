using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Dashboard : UserControl
    {
        public JS_Dashboard()
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(panel1, 20, Color.White);
            PanelStyles.RoundedPanel(panel2, 20, Color.White);
            PanelStyles.RoundedPanel(instruction_panel, 20, Color.White);
            LoadAnalytics();
        }

        private async void LoadAnalytics()
        {
            try
            {
                var business = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Status == "Verified")
                    .CountDocumentsAsync();

                var jobposting = await MongoDbServices.JobPosterJobPosting
                    .Find(x => x.JobStatus == "Active" && x.IsBusinessOnReview == false)
                    .CountDocumentsAsync();

                business_lbl.Text = business.ToString();
                posting_lbl.Text = jobposting.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard anallytics" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void read_lbl_Click(object sender, EventArgs e)
        {
            AdminDashboardUserControl.Admin_TermsAndPolicy admin_TermsAndPolicy = new AdminDashboardUserControl.Admin_TermsAndPolicy();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_TermsAndPolicy);
            admin_TermsAndPolicy.Dock = DockStyle.Fill;
        }
    }
}
