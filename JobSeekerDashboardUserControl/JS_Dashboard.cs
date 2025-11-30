using JobNear.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Dashboard : UserControl
    {
        public JS_Dashboard()
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(panel1, 20, Color.White);
            PanelStyles.RoundedPanel(panel2, 20, Color.White);
            PanelStyles.RoundedPanel(instruction_panel, 20, Color.White);
        }
    }
}
