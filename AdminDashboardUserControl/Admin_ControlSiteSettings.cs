using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_ControlSiteSettings : UserControl
    {
        public Admin_ControlSiteSettings()
        {
            InitializeComponent();
            SetUpUI();

            activate_button.Enabled = false;
            deactivate_button.Enabled = false;
        }

        public Admin_ControlSiteSettings(string ControlId)
        {
            InitializeComponent();
            LoadControlSiteData(ControlId);
            ControlButtonsVisibility();
            SetUpUI();
        }
        private void SetUpUI()
        {
            TextboxStyles.RoundedTextBoxShadow(name_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(description_input, 10, "#FFFFFF", 1);
            PanelStyles.RoundedPanel(maintenance_panel, 20, Color.White);
            ButtonStyle.RoundedButton(send_button, 20, "#495057");
            ButtonStyle.RoundedButton(revoke_button, 20, "#495057");
            ButtonStyle.RoundedButton(deactivate_button, 20, "#3B82F6");
            ButtonStyle.RoundedButton(activate_button, 20, "#10B981");

        }
        private async void LoadControlSiteData(string ControlId)
        {
            var controlSite = await MongoDbServices.ControlSiteNotification
                .Find(x => x.Id == ControlId)
                .FirstOrDefaultAsync();

            if (controlSite != null)
            {
                name_input.Text = controlSite.MaintenanceTitle;
                description_input.Text = controlSite.MaintenanceDescription;
                start_date.Value = controlSite.StartDate;
                end_date.Value = controlSite.EndDate;

                name_input.Enabled = false;
                description_input.Enabled = false;
                start_date.Enabled = false;
                end_date.Enabled = false;

            }
        }

        private async void ControlButtonsVisibility()
        {
            var getMaintenance = await MongoDbServices.ControlSiteMaintenance
                .Find(_ => true)
                .FirstOrDefaultAsync();
            if (getMaintenance != null)
            {
                if (getMaintenance.IsUnderMaintenance == true)
                {
                    send_button.Visible = false;
                    revoke_button.Visible = false;
                    activate_button.Enabled = false;
                    deactivate_button.Enabled = true;
                }
                else
                {
                    send_button.Visible = false;
                    revoke_button.Visible = true;

                    activate_button.Enabled = true;
                    deactivate_button.Enabled = false;
                }
            }
        }

        private async void send_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_input.Text) || string.IsNullOrEmpty(description_input.Text)
                || string.IsNullOrEmpty(start_date.Text) || string.IsNullOrEmpty(end_date.Text))
            {
                MessageBox.Show("Please fill out all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool response = await MongoDbServices.InsertControlSite(
                    name_input.Text.Trim(),
                    description_input.Text.Trim(),
                    start_date.Value,
                    end_date.Value
                );

                if (response)
                {

                    var getControlInfo = await MongoDbServices.ControlSiteNotification
                        .Find(x => x.MaintenanceTitle == name_input.Text.Trim())
                        .FirstOrDefaultAsync();

                    var getAllSeeker = await MongoDbServices.JobSeekerAccount
                        .Find(_ => true)
                        .ToListAsync();

                    var getAllPoster = await MongoDbServices.JobPosterAccount
                        .Find(_ => true)
                        .ToListAsync();

                    if (getAllSeeker != null && getAllPoster != null)
                    {

                        string key = "Admin";
                        DateTime date = DateTime.Now;
                        string headerMessage = $"{name_input.Text.Trim()} (Starting on {start_date.Value.ToString()} to {end_date.Value.ToString()})";
                        string remarks = description_input.Text.Trim();
                        string type = "info";


                        getAllSeeker.ForEach(async seeker =>
                        {
                            var newNotifSeeker = new UserNotificationModel
                            {
                                NotificationId = seeker.Id,
                                Key = key,
                                HeaderMessage = headerMessage,
                                Remarks = remarks,
                                Type = type,
                                Date = date,
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(newNotifSeeker);
                        });

                        getAllPoster.ForEach(async poster =>
                        {
                            var newNotifPoster = new UserNotificationModel
                            {
                                NotificationId = poster.Id,
                                Key = key,
                                HeaderMessage = headerMessage,
                                Remarks = remarks,
                                Type = type,
                                Date = date,
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(newNotifPoster);
                        });

                        MessageBox.Show("Notification sent successfully from both user!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (getControlInfo != null)
                        {
                            Admin_ControlSiteSettings controlSiteSettings = new Admin_ControlSiteSettings(getControlInfo.Id);
                            sidebar_panel.Controls.Clear();
                            sidebar_panel.Controls.Add(controlSiteSettings);
                            controlSiteSettings.Dock = DockStyle.Fill;

                        }

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error sending notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void revoke_button_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to revoke the maintenance?",
                "Confirm Revoke", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            await MongoDbServices.ControlSiteNotification.DeleteOneAsync(x => x.MaintenanceTitle == name_input.Text.Trim());

            var getAllSeeker = await MongoDbServices.JobSeekerAccount.Find(_ => true).ToListAsync();
            var getAllPoster = await MongoDbServices.JobPosterAccount.Find(_ => true).ToListAsync();

            string key = "Admin";
            DateTime date = DateTime.Now;
            string headerMessage = $"{name_input.Text.Trim()} (Maintenance Revoked)";
            string remarks = "The scheduled maintenance has been revoked. The system is now back to normal.";
            string type = "info";

            foreach (var seeker in getAllSeeker)
            {
                await MongoDbServices.UserNotification.InsertOneAsync(new UserNotificationModel
                {
                    NotificationId = seeker.Id,
                    Key = key,
                    HeaderMessage = headerMessage,
                    Remarks = remarks,
                    Type = type,
                    Date = date
                });
            }

            foreach (var poster in getAllPoster)
            {
                await MongoDbServices.UserNotification.InsertOneAsync(new UserNotificationModel
                {
                    NotificationId = poster.Id,
                    Key = key,
                    HeaderMessage = headerMessage,
                    Remarks = remarks,
                    Type = type,
                    Date = date
                });
            }

            MessageBox.Show("Revoke notification sent to all users!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Admin_ControlSiteSettings controlSiteSettings = new Admin_ControlSiteSettings();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(controlSiteSettings);
            controlSiteSettings.Dock = DockStyle.Fill;

        }
        private async void activate_button_Click(object sender, EventArgs e)
        {
            var getMaintenance = await MongoDbServices.ControlSiteMaintenance
                .Find(_ => true)
                .FirstOrDefaultAsync();

            if (getMaintenance != null)
            {
                if (getMaintenance.IsUnderMaintenance == true)
                {
                    MessageBox.Show("The site is already under maintenance.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                await MongoDbServices.ControlSiteMaintenance.UpdateOneAsync(
                    Builders<ControlSiteMaintenanceModel>.Filter.Empty,
                    Builders<ControlSiteMaintenanceModel>.Update.Set(x => x.IsUnderMaintenance, true)
                );
                MessageBox.Show("Site is now under maintenance.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var getControlInfo = await MongoDbServices.ControlSiteNotification
                    .Find(x => x.MaintenanceTitle == name_input.Text.Trim())
                    .FirstOrDefaultAsync();

                if (getControlInfo != null)
                {
                    Admin_ControlSiteSettings controlSiteSettings = new Admin_ControlSiteSettings(getControlInfo.Id);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(controlSiteSettings);
                    controlSiteSettings.Dock = DockStyle.Fill;

                }
            }
        }
        private async void deactivate_button_Click(object sender, EventArgs e)
        {
            var getMaintenance = await MongoDbServices.ControlSiteMaintenance
                .Find(_ => true)
                .FirstOrDefaultAsync();

            if (getMaintenance != null)
            {
                if (getMaintenance.IsUnderMaintenance == false)
                {
                    MessageBox.Show("The site is not under maintenance.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                await MongoDbServices.ControlSiteNotification.DeleteOneAsync(x => x.MaintenanceTitle == name_input.Text.Trim());

                await MongoDbServices.ControlSiteMaintenance.UpdateOneAsync(
                    Builders<ControlSiteMaintenanceModel>.Filter.Empty,
                    Builders<ControlSiteMaintenanceModel>.Update.Set(x => x.IsUnderMaintenance, false)
                );

                MessageBox.Show("Site is no longer under maintenance.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Admin_ControlSiteSettings controlSiteSettings = new Admin_ControlSiteSettings();
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(controlSiteSettings);
                controlSiteSettings.Dock = DockStyle.Fill;
            }



        }
    }
}
