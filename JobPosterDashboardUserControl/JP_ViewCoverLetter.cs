using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_ViewCoverLetter : UserControl
    {
        public JP_ViewCoverLetter(string applicationId)
        {
            InitializeComponent();
            LoadCoverLetter(applicationId);
            ButtonStyle.RoundedButton(back_button, 10, "#495057");
        }

        private async void LoadCoverLetter(string application)
        {
            var getApplication = await MongoDbServices.JobApplication
                .Find(x => x.Id == application)
                .FirstOrDefaultAsync();

            if (getApplication != null)
            {
                cover_input.Text = getApplication.CoverLetter;
            }
        }

        private void back_button_Click(object sender, System.EventArgs e)
        {
            JP_ViewApplication jP_ViewApplication = new JP_ViewApplication(Session.CurrentJobApplicationSelected);
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jP_ViewApplication);
            jP_ViewApplication.Dock = DockStyle.Fill;
        }
    }
}
