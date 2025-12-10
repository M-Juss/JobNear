using JobNear.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.Controllers
{
    public class UserController
    {
        public static void LogoutUser()
        {
            string response = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (response == "Yes")
            {
                Application.Restart();
            }
            else return;
        }

        public static void SetSeekerAndBusinesStatus(Label status_label, string status)
        {

            switch (status.ToLower())
            {
                case "verified":
                    status_label.Text = "Verified";
                    PanelStyles.StyleRoundedLabel(status_label, 5, Color.Green, Color.White);
                    break;

                case "pending":
                    status_label.Text = "Pending";
                    PanelStyles.StyleRoundedLabel(status_label, 5, Color.Orange, Color.White);
                    break;

                case "incomplete":
                    status_label.Text = "Incomplete";
                    PanelStyles.StyleRoundedLabel(status_label, 5, Color.Black, Color.White);

                    break;

                case "rejected":
                    status_label.Text = "Rejected";
                    PanelStyles.StyleRoundedLabel(status_label, 5, Color.Red, Color.White);
                    break;

                default:
                    status_label.Text = "Unknown";
                    PanelStyles.StyleRoundedLabel(status_label, 5, Color.Black, Color.White);
                    break;
            }
        }

        public static void SetJobPostStatus(Label status_label, string status)
        {
            switch (status.ToLower())
            {
                case "active":
                    status_label.Text = "Active";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Green, Color.White);
                    break;
                case "inactive":
                    status_label.Text = "Inactive";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Gray, Color.White);
                    break;
                case "closed":
                    status_label.Text = "Closed";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Black, Color.White);
                    break;
                case "withdrawn":
                    status_label.Text = "Withdrawn";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Orange, Color.White);
                    break;
                case "on review":
                    status_label.Text = "On Review";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Orange, Color.White);
                    break;
                case "pending":
                    status_label.Text = "Pending";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Orange, Color.White);
                    break;
                case "rejected":
                    status_label.Text = "Rejected";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Red, Color.White);
                    break;
                default:
                    status_label.Text = "Unknown";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Black, Color.White);
                    break;
            }
        }

        public static void SetJobApplicationStatus(Label status_label, string status)
        {
            switch (status.ToLower())
            {
                case "submitted":
                    status_label.Text = "Submitted";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Orange, Color.White);
                    break;
                case "accepted":
                    status_label.Text = "Accepted";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Green, Color.White);
                    break;
                case "rejected":
                    status_label.Text = "Rejected";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Red, Color.White);
                    break;
                default:
                    status_label.Text = "Unknown";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Black, Color.White);
                    break;
            }
        }
    }
}
