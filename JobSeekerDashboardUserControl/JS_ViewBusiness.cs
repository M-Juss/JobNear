using JobNear.Services;
using MongoDB.Driver;
using JobNear.Models;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ViewBusiness : UserControl
    {
        public JS_ViewBusiness(string businessSpecificId)
        {
            InitializeComponent();
            LoadSelectedBusiness(businessSpecificId);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoadSelectedBusiness(string businessId)
        {
            var businessDetails = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Id == businessId)
                .FirstOrDefaultAsync();

            if (businessDetails != null)
            {
                company_logo_picturebox.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);
                name_label.Text = businessDetails.BusinessName;
                description_label.Text = businessDetails.BusinessDescription;
                footer_label.Text = $"{businessDetails.BusinessAddress} | {businessDetails.BusinessEmail} | {businessDetails.BusinessContact}";
            }
        }
    }
}
