using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_ReportsAndComplaints : UserControl
    {
        public Admin_ReportsAndComplaints()
        {
            InitializeComponent();
            LoadTable();
            status_combo.SelectedIndex = 0;

        }

        private void LoadTable() {
            TableStyles.UserTables(reports_table);

            reports_table.Columns.Add("Subject", "Subject");
            reports_table.Columns.Add("Complainant", "Complainant");
            reports_table.Columns.Add("ComplainantId", "ComplainantId");
            reports_table.Columns.Add("Complainee", "Complainee");
            reports_table.Columns.Add("ComplaineeId", "ComplaineeId");
            reports_table.Columns.Add("Date Filed", "Date Filed");
            reports_table.Columns.Add("Status", "Status");
            reports_table.Columns.Add("ReportId", "ReportId");

            reports_table.Columns["ComplainantId"].Visible = false;
            reports_table.Columns["ComplaineeId"].Visible = false;
            reports_table.Columns["ReportId"].Visible = false;

            var actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = ">";
            actionButton.UseColumnTextForButtonValue = true;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Width = 60;
            actionButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            reports_table.Columns.Add(actionButton);
        }

        private void reports_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == reports_table.Columns["Action"].Index)
            {
                string complainantId = reports_table.Rows[e.RowIndex].Cells["ComplainantId"].Value.ToString();
                string complaineeId = reports_table.Rows[e.RowIndex].Cells["ComplaineeId"].Value.ToString();
                string reportId = reports_table.Rows[e.RowIndex].Cells["ReportId"].Value.ToString();


                Admin_ViewReportDetails viewReportInformation = new Admin_ViewReportDetails(complainantId, complaineeId, reportId);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(viewReportInformation);
                viewReportInformation.Dock = DockStyle.Fill;
            }
        }

        private async void status_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string response = status_combo.Text.ToLower();

                switch (response)
                {
                    case "active":
                        reports_table.Rows.Clear();
                        var activeReports = await MongoDbServices.ReportBusiness
                            .Find(x => x.Status == "Active")
                            .ToListAsync();

                        if (activeReports != null)
                        {
                            foreach (var active in activeReports)
                            {
                                var getUser = await MongoDbServices.JobSeekerAccount
                                    .Find(x => x.Id == active.Complainant)
                                    .FirstOrDefaultAsync();

                                var getBusiness = await MongoDbServices.JobPosterBusiness
                                    .Find(x => x.Id == active.Complainee)
                                    .FirstOrDefaultAsync();

                                if (getUser != null && getBusiness != null)
                                {
                                    string complainantName = $"{getUser.Firstname} {getUser.Lastname}";
                                    string complaineeName = getBusiness.BusinessName;

                                    reports_table.Rows.Add(
                                        active.Subject,
                                        complainantName,
                                        getUser.Id,
                                        complaineeName,
                                        getBusiness.Id,
                                        active.DateCreated.ToString("MM/dd/yyyy"),
                                        active.Status,
                                        active.Id
                                    );
                                }
                            }
                        }
                        break;

                    case "resolved":
                        reports_table.Rows.Clear();
                        var resolvedReports = await MongoDbServices.ReportBusiness
                            .Find(x => x.Status == "Resolved")
                            .ToListAsync();

                        if (resolvedReports != null)
                        {
                            foreach (var resolved in resolvedReports)
                            {
                                var getUser = await MongoDbServices.JobSeekerAccount
                                    .Find(x => x.Id == resolved.Complainant)
                                    .FirstOrDefaultAsync();

                                var getBusiness = await MongoDbServices.JobPosterBusiness
                                    .Find(x => x.Id == resolved.Complainee)
                                    .FirstOrDefaultAsync();

                                if (getUser != null && getBusiness != null)
                                {
                                    string complainantName = $"{getUser.Firstname} {getUser.Lastname}";
                                    string complaineeName = getBusiness.BusinessName;
                                    reports_table.Rows.Add(
                                        resolved.Subject,
                                        complainantName,
                                        getUser.Id,
                                        complaineeName,
                                        getBusiness.Id,
                                        resolved.DateCreated.ToString("MM/dd/yyyy"),
                                        resolved.Status,
                                        resolved.Id
                                    );
                                }
                            }
                        }
                        break;

                    case "closed":
                        reports_table.Rows.Clear();
                        var closedReports = await MongoDbServices.ReportBusiness
                             .Find(x => x.Status == "Resolved")
                             .ToListAsync();

                        if (closedReports != null)
                        {
                            foreach (var closed in closedReports)
                            {
                                var getUser = await MongoDbServices.JobSeekerAccount
                                    .Find(x => x.Id == closed.Complainant)
                                    .FirstOrDefaultAsync();

                                var getBusiness = await MongoDbServices.JobPosterBusiness
                                    .Find(x => x.Id == closed.Complainee)
                                    .FirstOrDefaultAsync();

                                if (getUser != null && getBusiness != null)
                                {
                                    string complainantName = $"{getUser.Firstname} {getUser.Lastname}";
                                    string complaineeName = getBusiness.BusinessName;

                                    reports_table.Rows.Add(
                                        closed.Subject,
                                        complainantName,
                                        getUser.Id,
                                        complaineeName,
                                        getBusiness.Id,
                                        closed.DateCreated.ToString("MM/dd/yyyy"),
                                        closed.Status,
                                        closed.Id
                                    );
                                }
                            }
                        }
                        break;

                    case "all":
                        reports_table.Rows.Clear();
                        var allReports = await MongoDbServices.ReportBusiness
                                 .Find(_ => true)
                                 .ToListAsync();

                        if (allReports != null)
                        {
                            foreach (var all in allReports)
                            {
                                var getUser = await MongoDbServices.JobSeekerAccount
                                    .Find(x => x.Id == all.Complainant)
                                    .FirstOrDefaultAsync();

                                var getBusiness = await MongoDbServices.JobPosterBusiness
                                    .Find(x => x.Id == all.Complainee)
                                    .FirstOrDefaultAsync();

                                if (getUser != null && getBusiness != null)
                                {
                                    string complainantName = $"{getUser.Firstname} {getUser.Lastname}";
                                    string complaineeName = getBusiness.BusinessName;

                                    reports_table.Rows.Add(
                                        all.Subject,
                                        complainantName,
                                        getUser.Id,
                                        complaineeName,
                                        getBusiness.Id,
                                        all.DateCreated.ToString("MM/dd/yyyy"),
                                        all.Status,
                                        all.Id
                                    );
                                }
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a valid status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
