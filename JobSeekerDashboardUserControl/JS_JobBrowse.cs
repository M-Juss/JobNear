using System.Collections.Generic;
using System.Windows.Forms;
using JobNear.Controllers;
using MongoDB.Driver;
using JobNear.Services;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_JobBrowse : UserControl
    {
        public JS_JobBrowse()
        {
            InitializeComponent();


            MapController.InitializeMap(map_panel, Session.CurrentLatitude, Session.CurrentLongitude);

            // Example data (this would normally come from your DB)
            var businesses = new List<(double lat, double lng, string name)>
                {
                    (14.6995, 120.8842, "Manila Business #1"),
                    (14.6760, 121.0437, "Quezon City Business #2"),
                    (14.5547, 121.0244, "Makati Business #3")
                };

            // Add all markers
            foreach (var business in businesses)
            {
                MapController.AddBusinessMarker(business.lat, business.lng, business.name);
            }

        }

        private async void LoadBusinessInMap() { 
            var businesses = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Status == "Verified")
                .ToListAsync();

            if (businesses != null) { 
                businesses.ForEach(business => {

                    string toolTipText = $"{business.BusinessName}\n {business.BusinessAddress} \n ";

                    MapController.AddBusinessMarker(
                        business.BusinessLatitude,
                        business.BusinessLongitude,
                        toolTipText
                    );
                });
            }
        }

        private void map_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
