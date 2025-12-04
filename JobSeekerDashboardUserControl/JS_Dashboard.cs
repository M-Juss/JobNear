using JobNear.Services;
using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;
using MongoDB.Driver;

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

                if (business != 0 && jobposting != 0)
                {
                    business_lbl.Text = business.ToString();
                    posting_lbl.Text = jobposting.ToString();
                }
                else MessageBox.Show("No data to shown in dashboard");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard anallytics" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
