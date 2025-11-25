using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_Dashboard : UserControl
    {
        public Admin_Dashboard()
        {
            InitializeComponent();

            StylePanels();
            LoadDashboardData();
            SetupApplicantsEmployersChart();
        }
        
        private void StylePanels()
        {
            PanelStyles.RoundedPanel(registered_panel, 20, Color.White);
            PanelStyles.RoundedPanel(seekers_panel, 20, Color.White);
            PanelStyles.RoundedPanel(seekers_panel, 20, Color.White);
            PanelStyles.RoundedPanel(active_panel, 20, Color.White);
            PanelStyles.RoundedPanel(verified_panel, 20, Color.White);
            PanelStyles.RoundedPanel(pending_panel, 20, Color.White);
            PanelStyles.RoundedPanel(complaints_panel, 20, Color.White);
        }

        private async void LoadDashboardData()
        {
            try
            {
                var getVerifiedBusinessesCount = await MongoDbServices.JobPosterBusiness.CountDocumentsAsync(x => x.Status == "Verified");
                var getVerifiedJobSeekersCount = await MongoDbServices.JobSeekerAccount.CountDocumentsAsync(x => x.Status == "Verified");
                var getActiveJobPostsCount = await MongoDbServices.JobPosterJobPosting.CountDocumentsAsync(x => x.JobStatus == "Active" && x.IsBusinessOnReview == false);

               
                var getPendingBusinessesCount = await MongoDbServices.JobPosterBusiness.CountDocumentsAsync(x => x.Status == "Pending");
                var getPendingJobSeekersCount = await MongoDbServices.JobSeekerAccount.CountDocumentsAsync(x => x.Status == "Pending");
                var getActiveComplaintsCount = await MongoDbServices.ReportBusiness.CountDocumentsAsync(x => x.Status == "Active");

                business_lbl.Text = getVerifiedBusinessesCount.ToString();
                seeker_lbl.Text = getVerifiedJobSeekersCount.ToString();
                jobs_lbl.Text = getActiveJobPostsCount.ToString();
                pendingBusiness_lbl.Text = getPendingBusinessesCount.ToString();
                pendingSeekers_lbl.Text = getPendingJobSeekersCount.ToString();
                complaints_lbl.Text = getActiveComplaintsCount.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}");
            }
        }
        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SetupApplicantsEmployersChart()
        {

            chartApplicantsEmployers.Series.Clear();
            chartApplicantsEmployers.ChartAreas.Clear();
            chartApplicantsEmployers.Titles.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisX.Title = "Months";
            area.AxisY.Title = "Count";

            chartApplicantsEmployers.ChartAreas.Add(area);

            Series applicantsSeries = new Series("Applicants");
            applicantsSeries.ChartType = SeriesChartType.Column;
            applicantsSeries.IsValueShownAsLabel = true;

            Series employersSeries = new Series("Employers");
            employersSeries.ChartType = SeriesChartType.Column;
            employersSeries.IsValueShownAsLabel = true;

            chartApplicantsEmployers.Series.Add(applicantsSeries);
            chartApplicantsEmployers.Series.Add(employersSeries);

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                        "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            int[] applicantCounts = { 150, 200, 180, 220, 260, 300, 310, 280, 240, 230, 210, 190 };
            int[] employerCounts = { 40, 50, 45, 60, 70, 80, 75, 65, 55, 58, 52, 48 };

            for (int i = 0; i < months.Length; i++)
            {
                chartApplicantsEmployers.Series["Applicants"].Points.AddXY(months[i], applicantCounts[i]);
                chartApplicantsEmployers.Series["Employers"].Points.AddXY(months[i], employerCounts[i]);
            }

            chartApplicantsEmployers.Titles.Add("Number of Applicants & Employers Per Month");
        }
    }
}
