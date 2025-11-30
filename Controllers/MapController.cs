using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Linq;
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

            gmap.Position = new GMap.NET.PointLatLng(lat, lng);

            AddUserMarker(lat, lng, "ME");

            gmap.CanDragMap = false;
            gmap.MouseWheelZoomEnabled = false;
            gmap.IgnoreMarkerOnMouseWheel = true;


            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            gmap.Zoom = 16;

        }

        public static void GetZoomLevel(string distance)
        {
            switch (distance.ToLower())
            {
                case "1 km":
                    gmap.Zoom = 16;
                    break;
                case "5 km":
                    gmap.Zoom = 14;
                    break;
                case "10 km":
                    gmap.Zoom = 13;
                    break;
                case "20 km":
                    gmap.Zoom = 12;
                    break;
                case "50 km":
                    gmap.Zoom = 11;
                    break;
                case "100 km":
                    gmap.Zoom = 10;
                    break;
                case "free navigation":
                    gmap.CanDragMap = true;
                    gmap.MouseWheelZoomEnabled = true;
                    gmap.IgnoreMarkerOnMouseWheel = false;
                    break;
                default:
                    gmap.Zoom = 16;
                    break;
            }
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

            if (item.Tag != null)
            {
                string businessId = item.Tag.ToString();
                Session.CurrentBusinessSelected = businessId;
                Session.CurrentBusinessSelectedStatus = "Verified";

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

    }
}