using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

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

        private async void LoadAnalytics()
        {
            try
            {
                var seekers = await MongoDbServices.JobSeekerAccount
                    .Find(x => x.Status == "Verified")
                    .CountDocumentsAsync();

                if (seekers != 0)
                {
                    applicants_lbl.Text = seekers.ToString();
                }

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

        private void insturction_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
