using JobNear.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_Dashboard : UserControl
    {
        public JP_Dashboard()
        {
            InitializeComponent();

            PanelStyles.RoundedPanel(panel1, 20, Color.White);
            PanelStyles.RoundedPanel(insturction_panel, 20, Color.White);
        }
    }
}
