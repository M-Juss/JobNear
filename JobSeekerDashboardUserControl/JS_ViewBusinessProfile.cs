using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ViewBusinessProfile : UserControl
    {
        public JS_ViewBusinessProfile(string prev)
        {
            InitializeComponent();
            LoadEditBusinessDetails();
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(address_panel, 20, Color.White);

            prev_lbl.Click += (s, e) =>
            {
                if (prev == "joblist")
                {
                    JS_ViewJobList js_viewjoblistform = new JS_ViewJobList(Session.CurrentPostedJobSelected);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(js_viewjoblistform);
                    js_viewjoblistform.Dock = DockStyle.Fill;
                }
                else if (prev == "business")
                {
                    JS_ViewBusiness js_businessform = new JS_ViewBusiness(Session.CurrentBusinessSelected);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(js_businessform);
                    js_businessform.Dock = DockStyle.Fill;
                }
                else if (prev == "report")
                {
                    JS_ReportBusiness jS_ReportBusiness = new JS_ReportBusiness(Session.CurrentBusinessSelected);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(jS_ReportBusiness);
                    jS_ReportBusiness.Dock = DockStyle.Fill;
                }
            };
        }

        private async void LoadEditBusinessDetails()
        {
            try
            {
                var businessDetails = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Id == Session.CurrentBusinessSelected)
                    .FirstOrDefaultAsync();

                if (businessDetails != null)
                {
                    name_input.Text = businessDetails.BusinessName;
                    industry_input.Text = businessDetails.BusinessIndustry;
                    description_richbox.Text = businessDetails.BusinessDescription;
                    address_input.Text = businessDetails.BusinessAddress;
                    email_input.Text = businessDetails.BusinessEmail;
                    phone_input.Text = businessDetails.BusinessContact;
                    website_input.Text = businessDetails.BusinessSite;
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
                MessageBox.Show("Error loading business details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
