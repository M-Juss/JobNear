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
    }
}
