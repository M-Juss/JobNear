using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;
using JobNear.Services;
using MongoDB.Driver;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_Dashboard : UserControl
    {
        public JP_Dashboard()
        {
            InitializeComponent();

            PanelStyles.RoundedPanel(panel1, 20, Color.White);
            PanelStyles.RoundedPanel(insturction_panel, 20, Color.White);
            LoadAnalytics();
        }

        private async void LoadAnalytics() {
            try { 
                var seekers = await MongoDbServices.JobSeekerAccount
                    .Find(x => x.Status == "Verified")
                    .CountDocumentsAsync();

                if (seekers != 0) { 
                    applicants_lbl.Text = seekers.ToString();
                }

            } catch(Exception ex)
            {
                MessageBox.Show("Error loading dashboard anallytics" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
