using JobNear.Models;
using JobNear.Services;
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
using System.Xml.Serialization;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_JS_UserManagement : UserControl
    {
        public Admin_JS_UserManagement()
        {
            InitializeComponent();
            status_combo.TextChanged += StatusChanged;
            seeker_table.Columns.Add("Username", "Username");
            seeker_table.Columns.Add("Fullname", "Full Name");
            seeker_table.Columns.Add("Email", "Email");
            seeker_table.Columns.Add("Phone", "Phone");
            seeker_table.Columns.Add("Age", "Age");
            seeker_table.Columns.Add("Sex", "Sex");
            seeker_table.Columns.Add("Status", "Status");
            seeker_table.Columns.Add("Action", "Action");

            seeker_table.Dock = DockStyle.Fill;
            seeker_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            seeker_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            seeker_table.RowHeadersVisible = false;

            // Background and border
            seeker_table.BackgroundColor = Color.White;
            seeker_table.BorderStyle = BorderStyle.None;
            seeker_table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            seeker_table.GridColor = Color.LightGray;

            // Header style
            seeker_table.EnableHeadersVisualStyles = false;
            seeker_table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            seeker_table.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            seeker_table.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            seeker_table.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            seeker_table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            seeker_table.ColumnHeadersHeight = 35;
            seeker_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row style
            seeker_table.DefaultCellStyle.BackColor = Color.White;
            seeker_table.DefaultCellStyle.ForeColor = Color.Black;
            seeker_table.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 120, 216);
            seeker_table.DefaultCellStyle.SelectionForeColor = Color.White;
            seeker_table.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Alternating row color (for modern look)
            seeker_table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);

            // Rounded corners (optional: only works visually if placed in panel with padding)
            seeker_table.DefaultCellStyle.Padding = new Padding(6, 6, 6, 6);
        }

        private void Admin_JS_UserManagement_Load(object sender, EventArgs e)
        {

        }

        private async void StatusChanged(object sender, EventArgs e)
        {
            string response = status_combo.Text.ToLower();

            switch (response)
            {
                case "pending":
                    var filterPending = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "pending");

                    var pendingAccounts = await MongoDbServices.JobSeekerAccount
                        .Find(filterPending)
                        .ToListAsync();

                    if (pendingAccounts != null) { 
                        pendingAccounts.ForEach(account => {


                            string fullname = $"{account.Lastname}, {account.Firstname} {account.Middlename}";

                            seeker_table.Rows.Add(account.Username, fullname, account.Email, account.Phone, account.Age, account.Sex, account.Status);

                        });
                    }
                    break;

                case "verified":
                    var filterVerified = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "verified");

                    var verifiedAccount = await MongoDbServices.JobSeekerAccount
                        .Find(filterVerified)
                        .ToListAsync();

                    if (verifiedAccount != null)
                    {
                        verifiedAccount.ForEach(account => {


                            string fullname = $"{account.Lastname}, {account.Firstname} {account.Middlename}";

                            seeker_table.Rows.Add(account.Username, fullname, account.Email, account.Phone, account.Age, account.Sex, account.Status);

                        });
                    }
                    break;

                case "incomplete":
                    var filterIncomplete = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "incomplete");

                    var incompleteAccount = await MongoDbServices.JobSeekerAccount
                        .Find(filterIncomplete)
                        .ToListAsync();


                    if (incompleteAccount != null)
                    {
                        incompleteAccount.ForEach(account => {


                            string fullname = $"{account.Lastname}, {account.Firstname} {account.Middlename}";

                            seeker_table.Rows.Add(account.Username, fullname, account.Email, account.Phone, account.Age, account.Sex, account.Status);

                        });
                    }
                    break;

                case "rejected":
                    var filterRejected = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "rejected");

                    var rejectedAccount = await MongoDbServices.JobSeekerAccount
                        .Find(filterRejected)
                        .ToListAsync();


                    if (rejectedAccount != null)
                    {
                        rejectedAccount.ForEach(account => {
                            string fullname = $"{account.Lastname}, {account.Firstname} {account.Middlename}";

                            seeker_table.Rows.Add(account.Username, fullname, account.Email, account.Phone, account.Age, account.Sex, account.Status);

                        });
                    }
                    break;

                case "all":
                    var submmitedAccount = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.IsDraft, false);

                    var allAccount = await MongoDbServices.JobSeekerAccount
                        .Find(submmitedAccount)
                        .ToListAsync();


                    if (allAccount != null)
                    {
                        allAccount.ForEach(account => {

                            string fullname = $"{account.Lastname}, {account.Firstname} {account.Middlename}";

                            seeker_table.Rows.Add(account.Username, fullname, account.Email, account.Phone, account.Age, account.Sex, account.Status);

                        });
                    }
                    break;

                default:
                    MessageBox.Show("Please select a valid status.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void seeker_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
