using JobNear.Styles;
using System;
using System.Drawing;
using System.Windows.Forms;
using JobNear.Services;
using MongoDB.Driver;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_JP_UserManagement : UserControl
    {
        public Admin_JP_UserManagement()
        {
            InitializeComponent();

            TableStyles.UserTables(seeker_table);

            seeker_table.Columns.Add("Username", "Username");
            seeker_table.Columns.Add("Email", "Email");
            seeker_table.Columns.Add("Phone", "Phone");

            var actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = ">";
            actionButton.UseColumnTextForButtonValue = true;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Width = 60;
            actionButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            seeker_table.Columns.Add(actionButton);

            InitialTableValue();

            search_input.Text = "Search";
            search_input.ForeColor = Color.Gray;

        }

        private async void InitialTableValue() {

            var posters = await MongoDbServices.JobPosterAccount
                .Find(_ => true)
                .ToListAsync();

            if (posters != null) {
                posters.ForEach(poster =>
                {
                    seeker_table.Rows.Add(
                        poster.Username,
                        poster.Email,
                        poster.Phone
                    );
                });
            }

        }

        private void seeker_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == seeker_table.Columns["Action"].Index)
            {
                string email = seeker_table.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                Session.CurrentJobPosterSelected = email;

                JP_ViewInformation viewInformation = new JP_ViewInformation(email);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(viewInformation);
                viewInformation.Dock = DockStyle.Fill;
            }
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
