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
            //FlowLayoutStyles.AddPendingBusiness("Mochi Store", "A grocery store wherein you can buy everything!", "Sahud - Ulan Chapel, Antero Soriano Highway, Tanza, 4108 Cavite, Philippines","pending", mybusiness_flowlayout, my_business_panel);
            //FlowLayoutStyles.AddPendingBusiness("Mochi s", "A grocery store wherein you can buy everything!", "Sahud - Ulan Chapel, Antero Soriano Highway, Tanza, 4108 Cavite, Philippines", "verified", mybusiness_flowlayout, my_business_panel);
            //FlowLayoutStyles.AddPendingBusiness("Mochi sa", "A grocery store wherein you can buy everything!", "Sahud - Ulan Chapel, Antero Soriano Highway, Tanza, 4108 Cavite, Philippines", "incomplete", mybusiness_flowlayout, my_business_panel);
            //FlowLayoutStyles.AddPendingBusiness("Mochi da", "A grocery store wherein you can buy everything!", "Sahud - Ulan Chapel, Antero Soriano Highway, Tanza, 4108 Cavite, Philippines", "rejected",mybusiness_flowlayout, my_business_panel);
        }

        private async void LoadBusiness()
        {
            try
            {
                var businessDetails = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.BusinessId == Session.CurrentUserId)
                    .ToListAsync();

                if (businessDetails != null)
                {
                    businessDetails.ForEach(business =>
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
                    });
                }
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while fetching business details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void my_business_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

        
    }
