using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
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
    public partial class JS_ViewInformation : UserControl
    {
        public JS_ViewInformation(string email)
        {
            InitializeComponent();
            LoadSpecificUser(email);

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;  
            image_flowlayout.AutoScroll = true;
        }

        private async void LoadSpecificUser(string email)
        {
            var filter = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Email, email);

            var specificUser = await MongoDbServices.JobSeekerAccount
                .Find(filter)
                .FirstOrDefaultAsync();

            if (specificUser != null)
            {
                username_label.Text = specificUser.Username;
                fullname_input.Text =  $"{specificUser.Lastname}, {specificUser.Firstname} {specificUser.Middlename}";
                age_input.Text = specificUser.Age.ToString();
                sex_input.Text = specificUser.Sex;
                birthdate_input.Text = specificUser.Birthdate.ToShortDateString();
                email_input.Text = specificUser.Email;
                phone_input.Text = specificUser.Phone;
                address_input.Text = specificUser.Address;
                lat_input.Text = specificUser.Latitude.ToString();
                lng_input.Text = specificUser.Longitude.ToString();
                profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(specificUser.ProfilePicture);

                if (specificUser.SupportingDocuments != null) { 
                    foreach (var doc in specificUser.SupportingDocuments)
                    {
                        FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, 869);
                    }
                }

            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(new Admin_JS_UserManagement());
            sidebar_panel.Dock = DockStyle.Fill;
        }

        private async void submit_button_Click(object sender, EventArgs e)
        {
            string userEmail = email_input.Text.ToString();

            var specificUser = await MongoDbServices.JobSeekerAccount
                .Find(x => x.Email == userEmail)
                .FirstOrDefaultAsync();

        }
    }
}
