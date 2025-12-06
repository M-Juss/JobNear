using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ViewBusiness : UserControl
    {
        public JS_ViewBusiness(string businessSpecificId)
        {
            InitializeComponent();

            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.StyleRoundedLabel(report_label, 10, Color.Red, Color.White);

            LoadSelectedBusiness(businessSpecificId);
            LoadActiveJobPosted(businessSpecificId);
        }

        private async void LoadSelectedBusiness(string businessId)
        {
            var businessDetails = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == businessId)
                .FirstOrDefaultAsync();

            if (businessDetails != null)
            {
                Session.CurrentBusinessSelected = businessDetails.Id;
                company_logo_picturebox.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);
                name_label.Text = businessDetails.BusinessName;
                description_label.Text = businessDetails.BusinessDescription;
                footer_label.Text = $"{businessDetails.BusinessAddress} | {businessDetails.BusinessEmail} | {businessDetails.BusinessContact}";
            }
        }

        private async void LoadActiveJobPosted(string businessId)
        {
            try
            {
                var getBusiness = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Id == businessId)
                    .FirstOrDefaultAsync();

                if (getBusiness != null)
                {
                    Session.CurrentBusinessSelectedStatus = getBusiness.Status;
                    var getActiveJobs = await MongoDbServices.JobPosterJobPosting
                        .Find(x => x.BusinessId == getBusiness.Id && x.JobStatus == "Active" && x.IsBusinessOnReview == false)
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


        private async void report_label_Click(object sender, EventArgs e)
        {
            var existingReport = await MongoDbServices.ReportBusiness
                .Find(x => x.Complainant == Session.CurrentUserId
                          && x.Complainee == Session.CurrentBusinessSelected
                          && x.Status == "Active")
                .FirstOrDefaultAsync();

            if (existingReport != null)
            {

                MessageBox.Show(
                    "Your report has already been submitted and is currently waiting for review. Please wait for updates.",
                    "Report Pending",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            JS_ReportBusiness reportBusiness = new JS_ReportBusiness(Session.CurrentBusinessSelected);
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(reportBusiness);
            reportBusiness.Dock = DockStyle.Fill;
        }


        private void prev_lbl_Click(object sender, EventArgs e)
        {
            JS_JobBrowse js_JobBrowse = new JS_JobBrowse();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(js_JobBrowse);
            js_JobBrowse.Dock = DockStyle.Fill;
        }

        private void business_panel_Click(object sender, EventArgs e)
        {
            JS_ViewBusinessProfile jS_ViewBusinessProfile = new JS_ViewBusinessProfile("business");
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jS_ViewBusinessProfile);
            jS_ViewBusinessProfile.Dock = DockStyle.Fill;
        }
    }
}
