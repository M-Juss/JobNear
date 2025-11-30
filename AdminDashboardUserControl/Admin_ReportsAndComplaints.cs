using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void LoadTable()
        {
            reports_table.CellPainting += (s, e) =>
            {
                if (e.RowIndex >= 0 &&
                    e.ColumnIndex == reports_table.Columns["Action"].Index)
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
                string status = reports_table.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                Session.CurrentReportSelected = reportId;


                Admin_ViewReportDetails viewReportInformation = new Admin_ViewReportDetails(complainantId, complaineeId, reportId, status);
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
                    case "closed":
                        reports_table.Rows.Clear();
                        var closedReports = await MongoDbServices.ReportBusiness
                             .Find(x => x.Status == "Closed")
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
