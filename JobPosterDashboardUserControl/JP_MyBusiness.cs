using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_MyBusiness : UserControl
    {

        public JP_MyBusiness()
        {
            InitializeComponent();
            LoadBusiness();
        }

        private async void LoadBusiness()
        {
            try
            {
                var businessDetails = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.BusinessId == Session.CurrentUserId)
                    .ToListAsync();

                foreach (var business in businessDetails)
                {
                    FlowLayoutStyles.AddMyBusiness(
                        business.Id,
                        business.BusinessName,
                        business.BusinessDescription,
                        business.BusinessAddress,
                        business.Status,
                        mybusiness_flowlayout,
                        sidebar_panel
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching business details: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
