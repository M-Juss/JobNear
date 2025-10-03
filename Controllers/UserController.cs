using JobNear.Controller;
using System;
using System.Collections.Generic;
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
    }
}
