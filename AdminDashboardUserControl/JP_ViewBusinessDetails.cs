using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Windows.Forms;


namespace JobNear.AdminDashboardUserControl
{
    public partial class JP_ViewBusinessDetails : UserControl
    {
        public JP_ViewBusinessDetails(string id)
        {
            InitializeComponent();
            LoadSelectedBusiness(id);
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
                    lng_input.Text = businessDetails.Longitude.ToString();
                    lat_input.Text = businessDetails.Latitude.ToString();

                    profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(businessDetails.BusinessLogo);


                    if (businessDetails.SupportingDocuments != null)
                    {
                        foreach (var doc in businessDetails.SupportingDocuments)
                        {
                            FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, 865);
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
    }
}
