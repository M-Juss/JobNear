using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Controllers
{
    public class MapController
    {
        public static GMapControl gmap;


        public static void InitializeMap(Panel map_panel, double lat, double lng)
        {
            Console.Write($"lat: {lat} \n lon: {lng}");
            gmap = new GMapControl();

            gmap.Dock = DockStyle.Fill;
            map_panel.Controls.Add(gmap);

            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gmap.MapProvider = GMapProviders.GoogleMap; 

            gmap.CanDragMap = false;

            // this would be dynamic based on user location
            gmap.Position = new GMap.NET.PointLatLng(lat, lng);

            AddUserMarker(lat, lng, "ME");

            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            gmap.Zoom = 15; // ~5km radius

        }

        public static void AddBusinessMarker(double lat, double lng, string tooltipText, string businessSpecificId)
        {

            GMapOverlay markersOverlay;

            markersOverlay = gmap.Overlays.FirstOrDefault(o => o.Id == "markers");
            if (markersOverlay == null)
            {
                markersOverlay = new GMapOverlay("markers");
                gmap.Overlays.Add(markersOverlay);
            }

            var marker = new GMarkerGoogle(
                new PointLatLng(lat, lng),
                GMarkerGoogleType.red_dot
            )
            {
                ToolTipText = tooltipText,
                ToolTipMode = MarkerTooltipMode.OnMouseOver,
                Tag = businessSpecificId,
            };

            markersOverlay.Markers.Add(marker);

            gmap.OnMarkerClick -= Gmap_OnMarkerClick;
            gmap.OnMarkerClick += Gmap_OnMarkerClick;
        }
        public static void Gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // Check if it’s a business marker (not the user)
            if (item.Tag != null)
            {
                string businessId = item.Tag.ToString();

                JobSeekerDashboardUserControl.JS_ViewBusiness view = new JobSeekerDashboardUserControl.JS_ViewBusiness(businessId);
                Session.CurrentSidebarPanel.Controls.Clear();   
                Session.CurrentSidebarPanel.Controls.Add(view);
                view.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("This is your location!", "User Marker");
            }
        }
        public static void AddUserMarker(double lat, double lng, string tooltipText)
        {
            GMapOverlay markersOverlay;
            markersOverlay = gmap.Overlays.FirstOrDefault(o => o.Id == "markers");
            if (markersOverlay == null)
            {
                markersOverlay = new GMapOverlay("markers");
                gmap.Overlays.Add(markersOverlay);
            }
            var marker = new GMarkerGoogle(
                new PointLatLng(lat, lng),
                GMarkerGoogleType.blue_dot
            )
            {
                ToolTipText = tooltipText,
                ToolTipMode = MarkerTooltipMode.OnMouseOver
            };
            markersOverlay.Markers.Add(marker);

        }


        public static Bitmap GetBusinessIcon()
        {
            Bitmap business = new Bitmap("path_to_your_icon.png");
            return new Bitmap(business, new Size(32, 32)); // Resize to 32x32 pixels
        }

        public static Bitmap GetUserIcon()
        {
            Bitmap user = new Bitmap("path_to_your_icon.png");
            return new Bitmap(user, new Size(32, 32)); // Resize to 32x32 pixels
        }

    }
} 