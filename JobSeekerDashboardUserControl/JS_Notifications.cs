using JobNear.Controllers;
using JobNear.Services;
using MongoDB.Driver;
using System;
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
            Console.WriteLine(seeker.Count);
            if (seeker.Count > 0)
            {
                notificationManager = new NotificationFlowManager(notif_panel);
                foreach (var notif in seeker)
                {
                    notificationManager.AddNotification(notif.Key, notif.HeaderMessage, notif.Remarks, notif.Type, notif.Date);
                }
            }
        }


    }
}
