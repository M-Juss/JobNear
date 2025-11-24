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
            PanelStyles.StyleRoundedLabel(complainant_lbl, 5, Color.Green, Color.White);
            PanelStyles.StyleRoundedLabel(complainee_lbl, 5, Color.Orange, Color.White);
            PanelStyles.RoundedPanel(complainant_panel, 15, Color.WhiteSmoke, Color.LightGray);
            PanelStyles.RoundedPanel(complainee_panel, 15, Color.WhiteSmoke, Color.LightGray);
            PanelStyles.RoundedPanel(details_panel, 15, Color.WhiteSmoke, Color.LightGray);

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
                }

                var getReportDetails = await MongoDbServices.ReportBusiness.Find(x => x.Id == reportId).FirstOrDefaultAsync();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report details: " + ex.Message);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
