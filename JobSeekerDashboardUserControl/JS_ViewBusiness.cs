using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ViewBusiness : UserControl
    {
        public JS_ViewBusiness(string businessSpecificId)
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);

            LoadSelectedBusiness(businessSpecificId);
            LoadActiveJobPosted(businessSpecificId);

            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.StyleRoundedLabel(report_label, 10, Color.Red, Color.White);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoadSelectedBusiness(string businessId)
        {
            var businessDetails = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == businessId)
                .FirstOrDefaultAsync();

            if (businessDetails != null)
            {
                company_logo_picturebox.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);
                name_label.Text = businessDetails.BusinessName;
                description_label.Text = businessDetails.BusinessDescription;
                footer_label.Text = $"{businessDetails.BusinessAddress} | {businessDetails.BusinessEmail} | {businessDetails.BusinessContact}";
            }
        }

        // Consult arnel regarding to displaying all job posted or js the actives only?
        private async void LoadActiveJobPosted(string businessId)
        {
            try
            {
                var getBusiness = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Id == businessId)
                    .FirstOrDefaultAsync();

                if (getBusiness != null)
                {
                    Console.WriteLine("Business Status: " + getBusiness.Status);
                    var getActiveJobs = await MongoDbServices.JobPosterJobPosting
                        .Find(x => x.BusinessId == getBusiness.Id && x.JobStatus == "Active")
                        .ToListAsync();

                    getActiveJobs.ForEach(job =>
                    {
                        FlowLayoutStyles.AddPostJob(
                            job.Id,
                            job.JobPosition,
                            job.JobWorkModel,
                            job.JobEmploymentType,
                            job.JobAbout,
                            job.JobStatus,
                            joblist_flowlayout,
                            sidebar_panel
                        );
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            JS_JobBrowse js_JobBrowse = new JS_JobBrowse();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_JobBrowse);
            js_JobBrowse.Dock = DockStyle.Fill;
        }


        private async void report_label_Click(object sender, EventArgs e)
        {

            var report = await MongoDbServices.ReportBusiness
                .Find(x => x.Complainant == Session.CurrentUserId && x.Complainee == Session.CurrentBusinessSelected)
                .FirstOrDefaultAsync();

            if (report != null)
            {
                if (report.Status == "Active")
                {
                    MessageBox.Show(
                    "Your report has already been submitted and is currently waiting for review. Please wait for updates.",
                    "Report Pending",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                    return;
                }
                else {
                    JS_ReportBusiness reportBusiness = new JS_ReportBusiness(Session.CurrentBusinessSelected);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(reportBusiness);
                    reportBusiness.Dock = DockStyle.Fill;
                }
            }
        }
    }
}
