
using System.Windows.Forms;
using JobNear.Services;
using MongoDB.Driver;
using JobNear.Styles;

namespace JobNear.AdminDashboardUserControl
{
    public partial class JP_ViewInformation : UserControl
    {
        public JP_ViewInformation(string email)
        {
            InitializeComponent();
            LoadBusineses(email);
        }

        private async void LoadBusineses(string email)
        {
            var getUserId = await MongoDbServices.JobPosterAccount
                .Find(x => x.Email == email)
                .FirstOrDefaultAsync();

            if (getUserId != null) { 
                username_label.Text = getUserId.Username;
                email_input.Text = getUserId.Email;
                phone_input.Text = getUserId.Phone;

                var getUserBusinesses = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.BusinessId == getUserId.Id)
                    .ToListAsync();

                if (getUserBusinesses != null) {
                    getUserBusinesses.ForEach(business =>
                    {
                        FlowLayoutStyles.AddMyBusiness(
                            business.Id,
                            business.BusinessName,
                            business.BusinessDescription,
                            business.BusinessAddress,
                            business.Status,
                            mybusiness_flowlayout,
                            sidebar_panel
                        );
                    });
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
