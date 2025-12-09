using MongoDB.Driver;
using System.Windows.Forms;
using JobNear.Services;
using JobNear.Styles;


namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_ViewApplication : UserControl
    {
        public JP_ViewApplication(string applicationId)
        {
            InitializeComponent();
            LoadApplicationDetails(applicationId);

            view_lbl.Click += (s, e) => {
                Session.CurrentJobApplicationSelected = applicationId;
                JP_ViewCoverLetter jP_ViewCoverLetter = new JP_ViewCoverLetter(applicationId);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(jP_ViewCoverLetter);
                jP_ViewCoverLetter.Dock = DockStyle.Fill;   
            };
        }

        private async void LoadApplicationDetails(string applicationId) {

            var application = await MongoDbServices.JobApplication
                .Find(x => x.Id == applicationId)
                .FirstOrDefaultAsync();

            var getApplicant = await MongoDbServices.JobSeekerAccount
                .Find(x => x.Id == application.SeekerId)
                .FirstOrDefaultAsync();

            var getPostedJob = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == application.JobId)
                .FirstOrDefaultAsync();

            var getBusiness = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == getPostedJob.BusinessId)
                .FirstOrDefaultAsync();

            if (application != null && getApplicant != null && getPostedJob != null) 
            {
                header_label.Text = $"Applying for: {getPostedJob.JobPosition}";
                sub_lbl.Text = $"In Business: {getBusiness.BusinessName}";

                string fullname = $"{getApplicant.Firstname} {getApplicant.Middlename} {getApplicant.Lastname}";

                profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(getApplicant.ProfilePicture);
                name_label.Text = fullname;
                email_lbl.Text = getApplicant.Email;
                phone_lbl.Text = getApplicant.Phone;

                if (application.SupportingDocuments != null)
                {
                    foreach (var doc in application.SupportingDocuments)
                    {
                        FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, image_flowlayout.Width - 20, "No");
                    }
                }

            }
        }

        private void view_lbl_Click(object sender, System.EventArgs e)
        {

        }

        private void business_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_lbl_Click_1(object sender, System.EventArgs e)
        {

        }

        private void submit_button_Click(object sender, System.EventArgs e)
        {

        }
    }
}
