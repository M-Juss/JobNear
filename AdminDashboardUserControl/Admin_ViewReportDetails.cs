using System;
using MongoDB.Driver;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;
using JobNear.Services;

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

    }
}
