using JobNear.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_MyBusiness : UserControl
    {

        public JP_MyBusiness()
        {
            InitializeComponent();

            FlowLayoutStyles.AddPendingBusiness("Mochi Store", "A grocery store wherein you can buy everything!", "Sahud - Ulan Chapel, Antero Soriano Highway, Tanza, 4108 Cavite, Philippines", mybusiness_flowlayout);

        }




    }
}
