using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_ViewApplication : UserControl
    {
        public JP_ViewApplication(string applicationId)
        {
            InitializeComponent();
            LoadApplicationDetails(applicationId);
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(info_panel, 20, Color.White);
            ButtonStyle.RoundedButton(submit_button, 10, "#10B981");
            ButtonStyle.RoundedButton(cancel_button, 10, "#495057");

            view_lbl.Click += (s, e) =>
            {
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
            sub_lbl.Text = $"{getBusiness.BusinessName}";

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

        private async void submit_button_Click(object sender, EventArgs e)
        {
            string status = status_combo.SelectedItem.ToString();

            string key = sub_lbl.Text;
            DateTime date = DateTime.Now;
            string remarks = remarks_richtext.Text.ToString().ToLower();

            var getApplication = await MongoDbServices.JobApplication
                .Find(x => x.Id == Session.CurrentJobApplicationSelected)
                .FirstOrDefaultAsync();

            var getApplicant = await MongoDbServices.JobSeekerAccount
                .Find(x => x.Id == getApplication.SeekerId)
                .FirstOrDefaultAsync();

            var getPostedJob = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == getApplication.JobId)
                .FirstOrDefaultAsync();

            var getBusiness = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == getPostedJob.BusinessId)
                .FirstOrDefaultAsync();

            switch (status.ToLower())
            {
                case "accepted":
                    string seekerAcceptedMessage = $"Congratulations! Your application for {header_label.Text} has been accepted. The employer will contact you with next steps.";
                    string seekerAcceptedType = "success";

                    var acceptedNotif = new UserNotificationModel
                    {
                        NotificationId = getApplicant.Id,
                        Key = key,
                        HeaderMessage = seekerAcceptedMessage,
                        Remarks = remarks,
                        Type = seekerAcceptedType,
                        Date = date
                    };

                    await MongoDbServices.UserNotification.InsertOneAsync(acceptedNotif);

                    var application = Builders<JobApplicationModel>.Filter.Eq(x => x.Id, Session.CurrentJobApplicationSelected);

                    if (application != null)
                    {
                        var updateApplication = Builders<JobApplicationModel>.Update
                            .Set(x => x.Status, status)
                            .Set(x => x.isSubmissionActive, false);

                        await MongoDbServices.JobApplication.UpdateOneAsync(application, updateApplication);
                        MessageBox.Show(
                        $"You have successfully marked the application for {header_label.Text} as Accepted.",
                        "Application Status Updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
);
                        sidebar_panel.Controls.Clear();
                        sidebar_panel.Controls.Add(new JP_ReviewApplication());
                        sidebar_panel.Dock = DockStyle.Fill;

                    }
                    else MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    break;
                case "rejected":
                    string seekerRejectedMessage = $"Thank you for applying for {header_label.Text}. Unfortunately, your application was not selected.";
                    string seekerRejectedType = "error";

                    var rejectedNotif = new UserNotificationModel
                    {
                        NotificationId = getApplicant.Id,
                        Key = key,
                        HeaderMessage = seekerRejectedMessage,
                        Remarks = remarks,
                        Type = seekerRejectedType,
                        Date = date
                    };

                    await MongoDbServices.UserNotification.InsertOneAsync(rejectedNotif);

                    var applicationR = Builders<JobApplicationModel>.Filter.Eq(x => x.Id, Session.CurrentJobApplicationSelected);

                    if (applicationR != null)
                    {
                        var updateApplication = Builders<JobApplicationModel>.Update
                            .Set(x => x.Status, status)
                            .Set(x => x.isSubmissionActive, false);

                        await MongoDbServices.JobApplication.UpdateOneAsync(applicationR, updateApplication);
                        MessageBox.Show(
                            $"You have successfully marked the application for {header_label.Text} as Rejected.",
                            "Application Status Updated",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        sidebar_panel.Controls.Clear();
                        sidebar_panel.Controls.Add(new JP_ReviewApplication());
                        sidebar_panel.Dock = DockStyle.Fill;

                    }
                    else MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            JP_ReviewApplication jP_ReviewApplication = new JP_ReviewApplication();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jP_ReviewApplication);
            jP_ReviewApplication.Dock = DockStyle.Fill;
        }
    }
}
