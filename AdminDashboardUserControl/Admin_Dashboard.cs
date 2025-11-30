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

        private async void SetupApplicantsEmployersChart()
        {
            chartApplicantsEmployers.Series.Clear();
            chartApplicantsEmployers.ChartAreas.Clear();
            chartApplicantsEmployers.Titles.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisX.Title = "Months";
            area.AxisY.Title = "Count";
            chartApplicantsEmployers.ChartAreas.Add(area);

            Series applicantsSeries = new Series("Applicants")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            Series employersSeries = new Series("Employers")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            chartApplicantsEmployers.Series.Add(applicantsSeries);
            chartApplicantsEmployers.Series.Add(employersSeries);

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                        "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            int[] applicantCounts = new int[12];
            int[] employerCounts = new int[12];

            // Fetch all JobSeekers and JobPosters from MongoDB
            var jobSeekers = await MongoDbServices.JobSeekerAccount.Find(_ => true).ToListAsync();
            var jobPosters = await MongoDbServices.JobPosterAccount.Find(_ => true).ToListAsync();

            // Count JobSeekers by month
            foreach (var seeker in jobSeekers)
            {
                int monthIndex = seeker.DateCreated.Month - 1; // Month is 1-12
                applicantCounts[monthIndex]++;
            }

            // Count JobPosters by month
            foreach (var poster in jobPosters)
            {
                int monthIndex = poster.DateCreated.Month - 1;
                employerCounts[monthIndex]++;
            }

            // Add points to chart
            for (int i = 0; i < months.Length; i++)
            {
                chartApplicantsEmployers.Series["Applicants"].Points.AddXY(months[i], applicantCounts[i]);
                chartApplicantsEmployers.Series["Employers"].Points.AddXY(months[i], employerCounts[i]);
            }

            chartApplicantsEmployers.Titles.Add("Number of Applicants & Employers Per Month");
        }
    }
}

