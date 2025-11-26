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
        public NotificationController(string senderName, string headerMessage, string remarks, string type, DateTime date, string warningCount)
        {
            SetupNotificationBox(senderName, headerMessage, remarks, type, date, warningCount);
        }

        private void SetupNotificationBox(string senderName, string headerMessage, string remarks, string type, DateTime date, string warningCount)
        {
            this.Size = new Size(980, 130);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(5, 3, 5, 3);

            Panel avatarPanel = new Panel();
            avatarPanel.Size = new Size(45, 45);
            avatarPanel.Location = new Point(10, 12);
            avatarPanel.BackColor = GetNotificationColor(type);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 45, 45);
            avatarPanel.Region = new Region(path);
            avatarPanel.Paint += (s, e) => DrawIcon(e.Graphics, type);

            Panel warningIndicator = new Panel();
            warningIndicator.Size = new Size(18, 18);
            warningIndicator.Location = new Point(this.Width - 28, 8);
            warningIndicator.BackColor = GetWarningColor(warningCount);

            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, 18, 18);
            warningIndicator.Region = new Region(circlePath);

            Label senderLabel = new Label();
            senderLabel.Text = senderName;
            senderLabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            senderLabel.ForeColor = Color.Black;
            senderLabel.Location = new Point(65, 8);
            senderLabel.Size = new Size(200, 25);

            Label headerLabel = new Label();
            headerLabel.Text = headerMessage;
            headerLabel.Font = new Font("Poppins", 9);
            headerLabel.ForeColor = Color.FromArgb(60, 60, 60);
            headerLabel.Location = new Point(65, 36);
            headerLabel.Size = new Size(600, 20);

            Label remarksLabel = new Label();
            remarksLabel.Text = remarks;
            remarksLabel.Font = new Font("Poppins", 8.5f, FontStyle.Italic);
            remarksLabel.ForeColor = Color.FromArgb(100, 100, 100);
            remarksLabel.Location = new Point(65, 60);
            remarksLabel.Size = new Size(800, 35);
            remarksLabel.AutoEllipsis = true;

            Label dateLabel = new Label();
            dateLabel.Text = FormatTimeAgo(date);
            dateLabel.Font = new Font("Poppins", 8);
            dateLabel.ForeColor = Color.Gray;
            dateLabel.Location = new Point(65, 100);
            dateLabel.Size = new Size(120, 15);

            this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(248, 249, 250);
            this.MouseLeave += (s, e) => this.BackColor = Color.White;

            this.Controls.AddRange(new Control[]
            {
                avatarPanel,
                senderLabel,
                headerLabel,
                remarksLabel,
                dateLabel,
                warningIndicator
            });
        }

        private Color GetWarningColor(string warningCount)
        {
            switch (warningCount)
            {
                case "1": return Color.Gold;
                case "2": return Color.Orange;
                case "3": return Color.Red;
                default: return Color.Transparent;
            }
        }

        private void DrawIcon(Graphics g, string type)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            string icon = GetIcon(type);

            using (Font iconFont = new Font("Segoe UI", 16, FontStyle.Bold))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                SizeF size = g.MeasureString(icon, iconFont);
                g.DrawString(icon, iconFont, brush, (45 - size.Width) / 2, (45 - size.Height) / 2);
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



    public class NotificationFlowManager
    {
        private FlowLayoutPanel flowPanel;

        public NotificationFlowManager(Panel containerPanel)
        {
            CreateFlowLayoutPanel(containerPanel);
        }

        private void CreateFlowLayoutPanel(Panel container)
        {
            flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.WhiteSmoke;
            flowPanel.Padding = new Padding(10);

            container.Controls.Clear();
            container.Controls.Add(flowPanel);
        }

        public void AddNotification(string senderName, string headerMessage, string remarks,
            string type = "Info", DateTime? date = null, string warningCount = null)
        {
            DateTime notificationDate = date ?? DateTime.Now;

            NotificationController notification =
                new NotificationController(senderName, headerMessage, remarks, type, notificationDate, warningCount);

            flowPanel.Controls.Add(notification);
            flowPanel.Controls.SetChildIndex(notification, 0);

            flowPanel.ScrollControlIntoView(notification);
        }

        public void ClearAllNotifications()
        {
            flowPanel.Controls.Clear();
        }

        public int GetNotificationCount()
        {
            return flowPanel.Controls.Count;
        }
    }
}