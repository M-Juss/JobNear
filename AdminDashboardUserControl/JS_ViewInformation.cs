using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class JS_ViewInformation : UserControl
    {
        public JS_ViewInformation(string email)
        {
            InitializeComponent();
            LoadSpecificUser(email);

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;  
            image_flowlayout.AutoScroll = true;
        }

        private async void LoadSpecificUser(string email)
        {
            var filter = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Email, email);

            var specificUser = await MongoDbServices.JobSeekerAccount
                .Find(filter)
                .FirstOrDefaultAsync();

            if (specificUser != null)
            {
                username_label.Text = specificUser.Username;
                fullname_input.Text =  $"{specificUser.Lastname}, {specificUser.Firstname} {specificUser.Middlename}";
                age_input.Text = specificUser.Age.ToString();
                sex_input.Text = specificUser.Sex;
                birthdate_input.Text = specificUser.Birthdate.ToShortDateString();
                email_input.Text = specificUser.Email;
                phone_input.Text = specificUser.Phone;
                address_input.Text = specificUser.Address;
                lat_input.Text = specificUser.Latitude.ToString();
                lng_input.Text = specificUser.Longitude.ToString();
                profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(specificUser.ProfilePicture);

                if (specificUser.SupportingDocuments != null) { 
                    foreach (var doc in specificUser.SupportingDocuments)
                    {
                        FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, 851);
                    }
                }

            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(new Admin_JS_UserManagement());
            sidebar_panel.Dock = DockStyle.Fill;
        }

        private async void submit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(status_combo.Text))
            {
                MessageBox.Show("Please select a status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string userEmail = email_input.Text.ToString();
                string status = status_combo.Text.ToString();

                var seeker = await MongoDbServices.JobSeekerAccount
                  .Find(x => x.Email == userEmail)
                  .FirstOrDefaultAsync();

                if (seeker != null)
                {
                    string key = "Admin";
                    DateTime date = DateTime.Now;
                    string remarks = remarks_richtext.Text.ToString();

                    switch (status.ToLower())
                    {
                        case "verified":
                            string verifyMessage = "Your profile status has been updated to verified.";
                            string verifyType = "Success";

                            var verifyNotif = new UserNotificationModel
                            {
                                NotificationId = seeker.Id,
                                Key = key,
                                HeaderMessage = verifyMessage,
                                Type = verifyType,
                                Remarks = remarks,
                                Date = date
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(verifyNotif);
                            break;

                        case "incomplete":
                            string incMessage = "Some information in your profile is incomplete. Please review and update.";
                            string incType = "Warning";

                            var incNotif = new UserNotificationModel
                            {
                                NotificationId = seeker.Id,
                                Key = key,
                                HeaderMessage = incMessage,
                                Type = incType,
                                Remarks = remarks,
                                Date = date
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(incNotif);
                            break;

                        case "rejected":
                            string rejectedMessage = "Your submission was not approved. Please review the requirements and resubmit.";
                            string rejectedType = "Error";

                            var rejectedNotif = new UserNotificationModel
                            {
                                NotificationId = seeker.Id,
                                Key = key,
                                HeaderMessage = rejectedMessage,
                                Type = rejectedType,
                                Remarks = remarks,
                                Date = date
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(rejectedNotif);
                            break;

                        case "pending":
                            string pendingMessage = "Your profile is currently pending review. Please wait for confirmation.";
                            string pendingType = "Info";

                            var pendingNotif = new UserNotificationModel
                            {
                                NotificationId = seeker.Id,
                                Key = key,
                                HeaderMessage = pendingMessage,
                                Type = pendingType,
                                Remarks = remarks,
                                Date = date
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(pendingNotif);
                            break;

                        default:
                            MessageBox.Show("Please select a valid status.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }

                    var getUser = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Email, userEmail);

                    if (getUser != null)
                    {
                        var updateUser = Builders<JobSeekerAccountModel>.Update
                            .Set(x => x.Status, status);

                        await MongoDbServices.JobSeekerAccount.UpdateOneAsync(getUser, updateUser);
                    }
                    else MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show("User status and notification have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(new Admin_JS_UserManagement());
                    sidebar_panel.Dock = DockStyle.Fill;
                }
                else MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
