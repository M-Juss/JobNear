using JobNear.Services;
using System;
using MongoDB.Driver;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ReportBusiness : UserControl
    {
        public JS_ReportBusiness(string businessSpecificId)
        {
            InitializeComponent();
            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;

            LoadSelectedBusiness(businessSpecificId);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
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
