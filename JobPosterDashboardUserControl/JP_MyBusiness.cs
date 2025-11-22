using JobNear.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;
using JobNear.Services;
using MongoDB.Driver;
using JobNear.Models;

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

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

        
    }
