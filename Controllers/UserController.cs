using JobNear.Controller;
using JobNear.Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Controllers
{
    public class UserController
    {
        public static void LogoutUser() { 
            string response = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (response == "Yes")
            {
                Application.Restart();
            }
            else return;
        }

        public static void UpdateAccountStatus(Label status_label, string status)
        {

            switch (status.ToLower())
            {
                case "verified":
                    status_label.Text = "Verified";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Green, Color.White);
                    break;

                case "pending":
                    status_label.Text = "Pending";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Orange, Color.White);
                    break;

                case "incomplete":
                    status_label.Text = "Incomplete";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Black, Color.White);

                    break;

                case "rejected":
                    status_label.Text = "Rejected";
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Red, Color.White);
                    break;

                default:
                    PanelStyles.StyleRoundedLabel(status_label, 10, Color.Black, Color.White);
                    break;
            }
        }
    }
}
