using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_JS_UserManagement : UserControl
    {
        public Admin_JS_UserManagement()
        {
            InitializeComponent();
            status_combo.TextChanged += (s, e) =>
            {
                
                string response = status_combo.Text.ToLower();

                switch (response) 
                {
                    case "pending":
                        
                        break;
                    case "verified":

                        break;
                    case "incomplete":

                        break;
                    case "rejected":

                        break;
                    case "all":

                        break;
                    default:
                        break;
                }
            };
        }

        private void Admin_JS_UserManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
