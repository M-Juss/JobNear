using JobNear.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Notifications : UserControl
    {
        private NotificationFlowManager notificationManager;
        public JS_Notifications()
        {
            InitializeComponent();
            // Initialize with your existing notification panel
            notificationManager = new NotificationFlowManager(sidebar_panel);

            // Load some sample notifications
            notificationManager.LoadSampleNotifications();
            notificationManager.LoadSampleNotifications();
            notificationManager.LoadSampleNotifications();
            notificationManager.LoadSampleNotifications();
            notificationManager.LoadSampleNotifications();
            notificationManager.LoadSampleNotifications();
            notificationManager.LoadSampleNotifications();
            notificationManager.LoadSampleNotifications();

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
