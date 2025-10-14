using JobNear.Controllers;
using JobNear.Models;
using JobNear.Services;
using MongoDB.Driver;
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
            LoadUserNotif();
        }

        private async void LoadUserNotif()
        {
            var seeker = await MongoDbServices.UserNotification
                .Find(x => x.NotificationId == Session.CurrentUserId)
                .ToListAsync(); 

            if (seeker != null)
            {
                foreach (var notif in seeker)
                {
                    notificationManager = new NotificationFlowManager(sidebar_panel);
                    notificationManager.AddNotification(notif.Key, notif.HeaderMessage, notif.Remarks, notif.Type, notif.Date);
                }
            }
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
