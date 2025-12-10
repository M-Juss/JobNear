using MongoDB.Driver;
using System.Windows.Forms;
using JobNear.Services;
using JobNear.Styles;
using System;


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

        private async void LoadApplicationDetails(string applicationId)
        {
            var application = await MongoDbServices.JobApplication
                .Find(x => x.Id == applicationId)
                .FirstOrDefaultAsync();

            if (application == null)
            {
                
                MessageBox.Show("Application not found.");
                return;
            }

            var getApplicant = await MongoDbServices.JobSeekerAccount
                .Find(x => x.Id == application.SeekerId)
                .FirstOrDefaultAsync();

            if (getApplicant == null)
            {
                MessageBox.Show("Applicant record not found.");
                return;
            }

            var getPostedJob = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == application.JobId)
                .FirstOrDefaultAsync();

            if (getPostedJob == null)
            {
                MessageBox.Show("Job posting not found.");
                return;
            }

            var getBusiness = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == getPostedJob.BusinessId)
                .FirstOrDefaultAsync();

            if (getBusiness == null)
            {
                MessageBox.Show("Business details not found.");
                return;
            }

            header_label.Text = $"Applying for: {getPostedJob.JobPosition}";
            sub_lbl.Text = $"In Business: {getBusiness.BusinessName}";

            string fullname = $"{getApplicant.Firstname} {getApplicant.Middlename} {getApplicant.Lastname}".Replace("  ", " ");

            profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(getApplicant.ProfilePicture);
            name_label.Text = fullname;
            email_lbl.Text = getApplicant.Email;
            phone_lbl.Text = getApplicant.Phone;
            address_lbl.Text = getApplicant.Address;

            image_flowlayout.Controls.Clear();

            if (application.SupportingDocuments != null && application.SupportingDocuments.Count > 0)
            {
                foreach (var doc in application.SupportingDocuments)
                {
                    FlowLayoutStyles.AddSupportingDocumentToFlow(
                        doc,
                        image_flowlayout,
                        image_flowlayout.Width - 20,
                        "No"
                    );
                }
            }
        }



    }
}
