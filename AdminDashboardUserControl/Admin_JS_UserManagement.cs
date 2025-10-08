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
using System.Xml.Serialization;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_JS_UserManagement : UserControl
    {
        public Admin_JS_UserManagement()
        {
            InitializeComponent();
            status_combo.SelectedIndex = 0;
            InitialTableValue();

            TableStyles.UserTables(seeker_table);

            status_combo.TextChanged += StatusChanged;

            seeker_table.Columns.Add("Username", "Username");
            seeker_table.Columns.Add("Fullname", "Full Name");
            seeker_table.Columns.Add("Email", "Email");
            seeker_table.Columns.Add("Phone", "Phone");
            seeker_table.Columns.Add("Age", "Age");
            seeker_table.Columns.Add("Sex", "Sex");
            seeker_table.Columns.Add("Status", "Status");
            seeker_table.Columns.Add("Action", "Action");
        }

        private void Admin_JS_UserManagement_Load(object sender, EventArgs e)
        {

        }

        private async void InitialTableValue() {
            var filterPending = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "pending");

            var pendingAccounts = await MongoDbServices.JobSeekerAccount
                .Find(filterPending)
                .ToListAsync();

            if (pendingAccounts != null)
            {
                pendingAccounts.ForEach(account => {


                    string fullname = $"{account.Lastname}, {account.Firstname} {account.Middlename}";

                    seeker_table.Rows.Add(account.Username, fullname, account.Email, account.Phone, account.Age, account.Sex, account.Status);

                });
            }
        }
        private async void StatusChanged(object sender, EventArgs e)
        {
            string response = status_combo.Text.ToLower();

            switch (response)
            {
                case "pending":
                    seeker_table.Rows.Clear();

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
                    seeker_table.Rows.Clear();
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
                    seeker_table.Rows.Clear();
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
                    seeker_table.Rows.Clear();
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
                    seeker_table.Rows.Clear();
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
