using JobNear.Controller;
using JobNear.Controllers;
using JobNear.JobSeekerDashboardUserControl;
using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            SetUpJsPanel();
        }

        private void SetUpJsPanel() {

            seeker_table.CellPainting += (s, e) =>
            {
                if (e.RowIndex >= 0 &&
                    e.ColumnIndex == seeker_table.Columns["Action"].Index)
                {
                    e.PaintBackground(e.ClipBounds, true);

                    Rectangle rect = new Rectangle(
                        e.CellBounds.X + 10,
                        e.CellBounds.Y + 5,
                        e.CellBounds.Width - 20,
                        e.CellBounds.Height - 10
                    );

                    int radius = 12;

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                        path.CloseAllFigures();


                        using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#E0F0FF")))
                        {
                            e.Graphics.FillPath(brush, path);
                        }


                        using (Pen pen = new Pen(ColorTranslator.FromHtml("#A5C8F0"), 1))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }


                        TextRenderer.DrawText(
                            e.Graphics,
                            "View",
                            new Font("Poppins", 11, FontStyle.Regular),
                            rect,
                            Color.Black,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                        );
                    }

                    e.Handled = true;
                }
            };

            status_combo.SelectedIndex = 0;

            TableStyles.UserTables(seeker_table);

            seeker_table.Columns.Add("Username", "Username");
            seeker_table.Columns.Add("Fullname", "Full Name");
            seeker_table.Columns.Add("Email", "Email");
            seeker_table.Columns.Add("Phone", "Phone");
            seeker_table.Columns.Add("Age", "Age");
            seeker_table.Columns.Add("Sex", "Sex");
            seeker_table.Columns.Add("Status", "Status");

            var actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = "View";
            actionButton.UseColumnTextForButtonValue = true;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Width = 60;
            actionButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            seeker_table.Columns.Add(actionButton);

            search_input.Text = "Search";
            search_input.ForeColor = Color.Gray;
        }


        private void seeker_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == seeker_table.Columns["Action"].Index)
            {
                string email = seeker_table.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                JS_ViewInformation viewInformation = new JS_ViewInformation(email);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(viewInformation);
                viewInformation.Dock = DockStyle.Fill;
            }
        }

        private void search_input_MouseClick(object sender, MouseEventArgs e)
        {
            search_input.Text = "";
            search_input.ForeColor = Color.Gray;
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string response = status_combo.Text.ToLower();

            switch (response)
            {
                case "pending":
                    seeker_table.Rows.Clear();

                    var filterPending = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "Pending");

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
                    break;

                case "verified":
                    seeker_table.Rows.Clear();
                    var filterVerified = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "Verified");

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
                    var filterIncomplete = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "Incomplete");

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
                    var filterRejected = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Status, "Rejected");

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
    }
}
