using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Controllers
{
    public class NotificationController : UserControl
    {
        public NotificationController(string senderName, string message, string type, DateTime date)
        {
            SetupNotificationBox(senderName, message, type, date);
        }

        private void SetupNotificationBox(string senderName, string message, string type, DateTime date)
        {
            // Set size - FlowLayoutPanel will handle positioning
            this.Size = new Size(980, 70);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(5, 3, 5, 3); // Small margins for spacing

            // Avatar circle
            Panel avatarPanel = new Panel();
            avatarPanel.Size = new Size(45, 45);
            avatarPanel.Location = new Point(10, 12);
            avatarPanel.BackColor = GetNotificationColor(type);

            // Make circular
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 45, 45);
            avatarPanel.Region = new Region(path);
            avatarPanel.Paint += (s, e) => DrawIcon(e.Graphics, type);

            // Sender name label
            Label senderLabel = new Label();
            senderLabel.Text = senderName;
            senderLabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            senderLabel.ForeColor = Color.Black;
            senderLabel.Location = new Point(65, 8);
            senderLabel.Size = new Size(150, 20);
            senderLabel.BackColor = Color.Transparent;

            // Message label
            Label messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.Font = new Font("Poppins", 9, FontStyle.Regular);
            messageLabel.ForeColor = Color.FromArgb(60, 60, 60);
            messageLabel.Location = new Point(65, 28);
            messageLabel.Size = new Size(480, 20);
            messageLabel.BackColor = Color.Transparent;

            // Date label
            Label dateLabel = new Label();
            dateLabel.Text = FormatTimeAgo(date);
            dateLabel.Font = new Font("Poppins", 8, FontStyle.Regular);
            dateLabel.ForeColor = Color.Gray;
            dateLabel.Location = new Point(65, 48);
            dateLabel.Size = new Size(100, 15);
            dateLabel.BackColor = Color.Transparent;

            // Hover effects
            this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(248, 249, 250);
            this.MouseLeave += (s, e) => this.BackColor = Color.White;

            // Add all controls
            this.Controls.AddRange(new Control[] { avatarPanel, senderLabel, messageLabel, dateLabel });
        }

        private void DrawIcon(Graphics g, string type)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            string icon = GetIcon(type);

            using (Font iconFont = new Font("Segoe UI", 16, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                SizeF size = g.MeasureString(icon, iconFont);
                float x = (45 - size.Width) / 2;
                float y = (45 - size.Height) / 2;
                g.DrawString(icon, iconFont, brush, x, y);
            }
        }

        private Color GetNotificationColor(string type)
        {
            switch (type?.ToLower())
            {
                case "success": return Color.FromArgb(40, 167, 69);
                case "error": return Color.FromArgb(220, 53, 69);
                case "warning": return Color.FromArgb(255, 193, 7);
                case "info": return Color.FromArgb(23, 162, 184);
                default: return Color.FromArgb(108, 117, 125);
            }
        }

        private string GetIcon(string type)
        {
            switch (type?.ToLower())
            {
                case "success": return "✓";
                case "error": return "✕";
                case "warning": return "⚠";
                case "info": return "i";
                default: return "●";
            }
        }

        private string FormatTimeAgo(DateTime date)
        {
            var span = DateTime.Now - date;
            if (span.TotalMinutes < 1) return "Just now";
            if (span.TotalMinutes < 60) return $"{(int)span.TotalMinutes}m ago";
            if (span.TotalHours < 24) return $"{(int)span.TotalHours}h ago";
            if (span.TotalDays < 7) return $"{(int)span.TotalDays}d ago";
            return date.ToString("MM/dd/yyyy");
        }
    }

    // FlowLayout notification manager
    public class NotificationFlowManager
    {
        private FlowLayoutPanel flowPanel;

        public NotificationFlowManager(Panel containerPanel)
        {
            CreateFlowLayoutPanel(containerPanel);
        }

        private void CreateFlowLayoutPanel(Panel container)
        {
            // Create FlowLayoutPanel inside your existing panel
            flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown; // Top to bottom
            flowPanel.WrapContents = false; // Don't wrap to next column
            flowPanel.AutoScroll = true; // Enable scrolling
            flowPanel.BackColor = Color.FromArgb(46, 204, 113); // Your green background
            flowPanel.Padding = new Padding(10);

            // Add FlowLayoutPanel to your existing panel
            container.Controls.Clear();
            container.Controls.Add(flowPanel);
        }

        // Add a new notification (will automatically position at top)
        public void AddNotification(string senderName, string message, string type = "Info", DateTime? date = null)
        {
            DateTime notificationDate = date ?? DateTime.Now;
            NotificationController notification = new NotificationController(senderName, message, type, notificationDate);

            // Insert at the top (index 0) so newest notifications appear first
            flowPanel.Controls.Add(notification);
            flowPanel.Controls.SetChildIndex(notification, 0);

            // Auto-scroll to top to show the newest notification
            flowPanel.ScrollControlIntoView(notification);
        }

        // Add verification notification
        public void AddVerificationNotification(string applicantName, bool isVerified)
        {
            string message = isVerified
                ? $"Congratulations {applicantName}! Your profile has been successfully verified."
                : $"Hello {applicantName}, your profile verification was not approved. Please review and resubmit.";

            string type = isVerified ? "Success" : "Error";
            AddNotification("Admin", message, type);
        }

        // Clear all notifications
        public void ClearAllNotifications()
        {
            flowPanel.Controls.Clear();
        }

        // Get count of notifications
        public int GetNotificationCount()
        {
            return flowPanel.Controls.Count;
        }

        // Load sample notifications for testing
        public void LoadSampleNotifications()
        {
            List<NewNotification> list = new List<NewNotification>();
            list.Add(new NewNotification
            {
                Key = "Admin",
                Message = "Your profile has been verified successfully!",
                Type = "Success",
                Date = DateTime.Now.AddMinutes(-5)
            });
            list.Add(new NewNotification
            {
                Key = "Admin",
                Message = "Please update your contact information.",
                Type = "Warning",
                Date = DateTime.Now.AddMinutes(-15)
            });
            list.Add(new NewNotification
            {
                Key = "System",
                Message = "Welcome to JobNear! Complete your profile to get started.",
                Type = "Info",
                Date = DateTime.Now.AddHours(-1)
            });
            list.Add(new NewNotification
            {
                Key = "Admin",
                Message = "Your document upload failed. Please try again.",
                Type = "Error",
                Date = DateTime.Now.AddHours(-3)
            });
            list.Add(new NewNotification
            {
                Key = "Admin",
                Message = "Your profile has been verified successfully!",
                Type = "Success",
                Date = DateTime.Now.AddMinutes(-5)
            });
            list.Add(new NewNotification
            {
                Key = "Admin",
                Message = "Please update your contact information.",
                Type = "Warning",
                Date = DateTime.Now.AddMinutes(-15)
            });
            list.Add(new NewNotification
            {
                Key = "System",
                Message = "Welcome to JobNear! Complete your profile to get started.",
                Type = "Info",
                Date = DateTime.Now.AddHours(-1)
            });
            list.Add(new NewNotification
            {
                Key = "Admin",
                Message = "Your document upload failed. Please try again.",
                Type = "Error",
                Date = DateTime.Now.AddHours(-3)
            });

            foreach (var notif in list)
            {
                AddNotification(notif.Key, notif.Message, notif.Type, notif.Date);
            }
        }

    }
    public class NewNotification
    {
        public string Key { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }



    }
}
