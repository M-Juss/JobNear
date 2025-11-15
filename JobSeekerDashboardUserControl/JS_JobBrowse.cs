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

            LoadBusinessInMap();

            distance_combo.SelectedIndex = 0; // default to 5 km    

        }

        private async void LoadBusinessInMap() { 

            var businesses = await MongoDbServices.JobPosterBusiness
                .Find(x => x.Status == "Verified")
                .ToListAsync();

            if (businesses != null) {

                foreach (var business in businesses) {

                    var businessActiveJobs = await MongoDbServices.JobPosterJobPosting
                        .CountDocumentsAsync(x => x.JobStatus == "Active");
                        
                    string toolTipText = $"\n{business.BusinessName}\n{business.BusinessAddress}\n{businessActiveJobs} Active Jobs ";

                    MapController.AddBusinessMarker(
                        business.BusinessLatitude,
                        business.BusinessLongitude,
                        toolTipText,
                        business.Id
                    );
                }

                    
            }
        }

        private void map_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void distance_combo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedDistance = distance_combo.SelectedItem.ToString();
            MapController.GetZoomLevel(selectedDistance);
        }
    }
}
