using JobNear.Services;
using JobNear.Styles;
using JobNear.Models;
using MongoDB.Driver;
using System;
using System.Windows.Forms;
using System.Drawing;


namespace JobNear.AdminDashboardUserControl
{
    public partial class JP_ViewBusinessDetails : UserControl
    {
        public JP_ViewBusinessDetails(string id)
        {
            InitializeComponent();
            LoadSelectedBusiness(id);
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
        }

        private async void LoadSelectedBusiness(string businessId)
        {
            try
            {
                var businessDetails = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Id == businessId)
                    .FirstOrDefaultAsync();

                if (businessDetails != null) { 
                    name_label.Text = businessDetails.BusinessName;
                    industry_input.Text = businessDetails.BusinessIndustry;
                    website_input.Text = businessDetails.BusinessSite;
                    description_richbox.Text = businessDetails.BusinessDescription;
                    email_input.Text = businessDetails.BusinessEmail;
                    phone_input.Text = businessDetails.BusinessContact;
                    address_input.Text = businessDetails.BusinessAddress;
                    lng_input.Text = businessDetails.BusinessLongitude.ToString();
                    lat_input.Text = businessDetails.BusinessLatitude.ToString();

                    profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);


                    if (businessDetails.SupportingDocuments != null)
                    {
                        foreach (var doc in businessDetails.SupportingDocuments)
                        {
                            FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, image_flowlayout.Width - 20, "No");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching business details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {

            JP_ViewInformation viewInfo = new JP_ViewInformation(Session.CurrentJobPosterSelected);
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(viewInfo);
            viewInfo.Dock = DockStyle.Fill;
        }

        private async void submit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(status_combo.Text))
            {
                MessageBox.Show("Please select a status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                {
                string status = status_combo.Text.ToString();

                var business = await MongoDbServices.JobPosterBusiness
                        .Find(x => x.Id == Session.CurrentBusinessSelected)
                        .FirstOrDefaultAsync();

                    if (business != null)
                    {
                        string key = "Admin";
                        DateTime date = DateTime.Now;
                        string remarks = remarks_richtext.Text.ToString().ToLower();

                        switch (status.ToLower())
                        {
                            case "verified":
                                string verifyMessage = $"Your business {business.BusinessName} status has been updated to verified.";
                                string verifyType = "Success";

                                var verifyNotif = new UserNotificationModel
                                {
                                    NotificationId = business.BusinessId,
                                    Key = key,
                                    HeaderMessage = verifyMessage,
                                    Type = verifyType,
                                    Remarks = remarks,
                                    Date = date
                                };

                                await MongoDbServices.UserNotification.InsertOneAsync(verifyNotif);

                                break;

                            case "pending":
                                string pendingMessage = $"Your business {business.BusinessName} is currently pending for review. Please wait for confirmation.";
                                string pendingType = "Info";

                                var pendingNotif = new UserNotificationModel
                                {
                                    NotificationId = business.BusinessId,
                                    Key = key,
                                    HeaderMessage = pendingMessage,
                                    Type = pendingType,
                                    Remarks = remarks,
                                    Date = date
                                };

                                await MongoDbServices.UserNotification.InsertOneAsync(pendingNotif);
                                break;

                            case "incomplete":
                                string incMessage = $"Your business {business.BusinessName} information is incomplete. Please review and update.";
                                string incType = "Warning";


                                var incNotif = new UserNotificationModel
                                {
                                    NotificationId = business.BusinessId,
                                    Key = key,
                                    HeaderMessage = incMessage,
                                    Type = incType,
                                    Remarks = remarks,
                                    Date = date
                                };

                                await MongoDbServices.UserNotification.InsertOneAsync(incNotif);
                                break;

                            case "rejected":
                                string rejectedMessage = $"Your business {business.BusinessName} submission was not approved. Please review the requirements and resubmit.";
                                string rejectedType = "Error";

                                var rejectedNotif = new UserNotificationModel
                                {
                                    NotificationId = business.BusinessId,
                                    Key = key,
                                    HeaderMessage = rejectedMessage,
                                    Type = rejectedType,
                                    Remarks = remarks,
                                    Date = date
                                };

                                await MongoDbServices.UserNotification.InsertOneAsync(rejectedNotif);
                                break;

                            default:
                                MessageBox.Show("Please select a valid status.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }

                        var getbusiness = Builders<JobPosterBusinessModel>.Filter.Eq(x => x.Id, Session.CurrentBusinessSelected);

                        if (getbusiness != null)
                        {
                            if (status == "Verified") // verified business and set BusinessOnReview to false in job posts
                            {
                                var updateVerified = Builders<JobPosterBusinessModel>.Update
                                    .Set(x => x.Status, status);

                                await MongoDbServices.JobPosterBusiness.UpdateOneAsync(getbusiness, updateVerified);

                                var checkJobPosts = await MongoDbServices.JobPosterJobPosting
                                    .Find(x => x.BusinessId == Session.CurrentBusinessSelected)
                                    .ToListAsync();

                                if (checkJobPosts != null && checkJobPosts.Count > 0)
                                {
                                    foreach (var jobPost in checkJobPosts)
                                    {
                                        var updateJobPost = Builders<JobPosterJobPostingModel>.Update
                                            .Set(x => x.IsBusinessOnReview, false);
                                        var jobPostFilter = Builders<JobPosterJobPostingModel>.Filter.Eq(x => x.Id, jobPost.Id);
                                        await MongoDbServices.JobPosterJobPosting.UpdateOneAsync(jobPostFilter, updateJobPost);
                                    }
                                }
                            }
                            else {
                                var updateDef = Builders<JobPosterBusinessModel>.Update
                                    .Set(x => x.Status, status);

                                await MongoDbServices.JobPosterBusiness.UpdateOneAsync(getbusiness, updateDef);
                            }

                            MessageBox.Show($"{business.BusinessName} {status} status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sidebar_panel.Controls.Clear();
                            sidebar_panel.Controls.Add(new Admin_JP_UserManagement());
                            sidebar_panel.Dock = DockStyle.Fill;
                        }
                        else MessageBox.Show("Business not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else MessageBox.Show("Business not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
