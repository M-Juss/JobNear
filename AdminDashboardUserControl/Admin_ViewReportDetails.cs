using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_ViewReportDetails : UserControl
    {
        public Admin_ViewReportDetails(string complainantId, string complaineeId, string reportId)
        {
            InitializeComponent();
            DesignPanels();
            LoadReportDetails(complainantId, complaineeId, reportId);
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoadReportDetails(string complainantId, string complaineeId, string reportId)
        {
            try
            {
                var getUser = await MongoDbServices.JobSeekerAccount.Find(x => x.Id == complainantId).FirstOrDefaultAsync();

                var getReportedBusiness = await MongoDbServices.JobPosterBusiness.Find(x => x.Id == complaineeId).FirstOrDefaultAsync();

                if (getUser != null && getReportedBusiness != null) {
                    string userName = $"{getUser.Firstname} {getUser.Middlename} {getUser.Lastname}";

                    complainant_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(getUser.ProfilePicture);
                    complainant_name.Text = userName;
                    complainant_email.Text = getUser.Email;
                    complainant_phone.Text = getUser.Phone;

                    complainee_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(getReportedBusiness.BusinessLogo);
                    complainee_name.Text = getReportedBusiness.BusinessName;
                    complainee_email.Text = getReportedBusiness.BusinessEmail;
                    complainee_phone.Text = getReportedBusiness.BusinessContact;
                } else MessageBox.Show("Error loading user or business details.");

                var getReportDetails = await MongoDbServices.ReportBusiness.Find(x => x.Id == reportId).FirstOrDefaultAsync();

                if (getReportDetails != null)
                {
                    subject_lbl.Text = getReportDetails.Subject;
                    description_lbl.Text = getReportDetails.Description;

                    if (getReportDetails.SupportingDocuments != null)
                    {
                        foreach (var doc in getReportDetails.SupportingDocuments)
                        {
                            FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, 865);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report details: " + ex.Message);
            }
        }
        private void DesignPanels() {
            PanelStyles.StyleRoundedLabel(complainant_lbl, 5, Color.Green, Color.White);
            PanelStyles.StyleRoundedLabel(complainee_lbl, 5, Color.Orange, Color.White);
            PanelStyles.RoundedPanel(complainant_panel, 1, Color.WhiteSmoke, Color.LightGray);
            PanelStyles.RoundedPanel(complainee_panel, 1, Color.WhiteSmoke, Color.LightGray);
            PanelStyles.RoundedPanel(details_panel, 15, Color.WhiteSmoke, Color.LightGray);

            //ButtonStyle.RoundedButton(cancel_button, 25, "#3B82F6");
            //ButtonStyle.RoundedButton(submit_button, 25, "#3B82F6");
        }

        private async void submit_button_Click(object sender, EventArgs e)
        {
            string status = status_combo.SelectedItem.ToString();
            var complainant = await MongoDbServices.JobSeekerAccount
                .Find(x => x.Email == complainant_email.Text)
                .FirstOrDefaultAsync();

            var complainee = await MongoDbServices.JobPosterBusiness
                .Find(x => x.BusinessEmail == complainee_email.Text)
                .FirstOrDefaultAsync();

            if (status == "Valid")
            {
                if (complainant != null && complainee != null)
                {
                    string key = "Admin";
                    DateTime date = DateTime.Now;

                    var complainantNotif = new UserNotificationModel
                    {
                        NotificationId = complainant.Id,
                        Key = key,
                        HeaderMessage = "Your complaint has been successfully validated.",
                        Type = "info",
                        Remarks = "Thank you for submitting your concern. Our team has reviewed your report and taken the appropriate action.",
                        Date = date
                    };
                    await MongoDbServices.UserNotification.InsertOneAsync(complainantNotif);

                    int warningCount = complainee.WarningCount + 1;

                    if (warningCount == 3)
                    {
                        var terminationNotif = new UserNotificationModel
                        {
                            NotificationId = complainee.BusinessId,
                            Key = key,
                            HeaderMessage = "Account Termination Notice",
                            Type = "warning",
                            Remarks = $"You business {complainee.BusinessName} had 3 validated warnings for policy violations. As per platform rules, your business account will now be subject to termination procedures.",
                            Date = date
                        };
                        await MongoDbServices.UserNotification.InsertOneAsync(terminationNotif);
                    }
                    else
                    {
                        var warningNotif = new UserNotificationModel
                        {
                            NotificationId = complainee.BusinessId,
                            Key = key,
                            HeaderMessage = $"Warning {warningCount}: Policy Violation Notice",
                            Type = "warning",
                            Remarks = $"A complaint filed against your business {complainee.BusinessName} has been validated. Please address this matter promptly. Accumulating 3 warnings will result in temporary account termination.",
                            Date = date
                        };
                        await MongoDbServices.UserNotification.InsertOneAsync(warningNotif);
                    }

                    var updateWarning = Builders<JobPosterBusinessModel>.Update
                        .Set(x => x.WarningCount, warningCount);

                    await MongoDbServices.JobPosterBusiness.UpdateOneAsync(
                        x => x.Id == complainee.Id,
                        updateWarning);
                }
            }

            else if (status == "Invalid")
            {
                if (complainant != null && complainee != null)
                {
                    string key = "Admin";
                    DateTime date = DateTime.Now;

                    var invalidNotif = new UserNotificationModel
                    {
                        NotificationId = complainant.Id,
                        Key = key,
                        HeaderMessage = "Your complaint has been reviewed.",
                        Type = "info",
                        Remarks = "After careful evaluation, we found that the submitted complaint does not meet the criteria for a valid case. No action has been taken. If you believe this is an error, you may submit additional details.",
                        Date = date
                    };

                    await MongoDbServices.UserNotification.InsertOneAsync(invalidNotif);
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Admin_ReportsAndComplaints rnc = new Admin_ReportsAndComplaints();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(rnc);
            rnc.Dock = DockStyle.Fill;
        }
    }
}
