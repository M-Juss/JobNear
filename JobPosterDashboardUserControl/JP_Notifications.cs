using JobNear.Controllers;
using JobNear.Forms;
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

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_Notifications : UserControl
    {
        private NotificationFlowManager notificationManager;
        public JP_Notifications()
        {
            InitializeComponent();
            LoadUserNotif();
        }

        private async void LoadUserNotif()
        {
            var poster = await MongoDbServices.UserNotification
                .Find(x => x.NotificationId == Session.CurrentUserId)
                .ToListAsync();
            Console.WriteLine(poster.Count);
            if (poster.Count > 0)
            {
                notificationManager = new NotificationFlowManager(notif_panel);
                foreach (var notif in poster)
                {
                    notificationManager.AddNotification(notif.Key, notif.HeaderMessage, notif.Remarks, notif.Type, notif.Date);
                }
            }
        }

        private void JP_Notifications_Load(object sender, EventArgs e)
        {

        }
    }
}
