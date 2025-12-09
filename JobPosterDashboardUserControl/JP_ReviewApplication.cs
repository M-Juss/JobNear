using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_ReviewApplication : UserControl
    {
        public JP_ReviewApplication()
        {
            InitializeComponent();
            SetUpUI();
        }

        private void SetUpUI() {
            review_table.CellPainting += (s, e) =>
            {
                if (e.RowIndex >= 0 &&
                    e.ColumnIndex == review_table.Columns["Action"].Index)
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

            TableStyles.UserTables(review_table);

            review_table.Columns.Add("Applicant", "Applicant");
            review_table.Columns.Add("Business", "Business");
            review_table.Columns.Add("Job", "Job");
            review_table.Columns.Add("Status", "Status");
            review_table.Columns.Add("Status", "Status");
            review_table.Columns.Add("ApplicationId", "ApplicationId");

            review_table.Columns["ApplicationId"].Visible = false;

            var actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = "View";
            actionButton.UseColumnTextForButtonValue = true;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Width = 80;

            actionButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Regular);
            actionButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            review_table.Columns.Add(actionButton);
        }

        private async void review_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = status_combo.SelectedItem.ToString();

            switch (status.ToLower())
            {
                case "To Review":
                    review_table.Rows.Clear();
                    var getToReview = await MongoDbServices.JobApplication
                        .Find(x => x.Status == "To Review")
                        .ToListAsync();

                    if (getToReview.Count > 0)
                    {
                        foreach (var application in getToReview) { 
                            var getApplicant = await MongoDbServices.JobSeekerAccount
                                .Find(x => x.Id == application.SeekerId)
                                .FirstOrDefaultAsync();

                            var getPostedJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();

                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getPostedJob.BusinessId)
                                .FirstOrDefaultAsync();

                            string fullname = $"{getApplicant.Firstname} {getApplicant.Middlename} {getApplicant.Lastname}";

                            review_table.Rows.Add(fullname, getBusiness.BusinessName, getPostedJob.JobPosition, application.Status, application.Id);
                        }
                    }
                    break;
                case "Accepted":
                    review_table.Rows.Clear();
                    var getAccepted = await MongoDbServices.JobApplication
                        .Find(x => x.Status == "Accepted")
                        .ToListAsync();

                    if (getAccepted.Count > 0)
                    {
                        foreach (var application in getAccepted)
                        {
                            var getApplicant = await MongoDbServices.JobSeekerAccount
                                .Find(x => x.Id == application.SeekerId)
                                .FirstOrDefaultAsync();

                            var getPostedJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();

                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getPostedJob.BusinessId)
                                .FirstOrDefaultAsync();

                            string fullname = $"{getApplicant.Firstname} {getApplicant.Middlename} {getApplicant.Lastname}";

                            review_table.Rows.Add(fullname, getBusiness.BusinessName, getPostedJob.JobPosition, application.Status, application.Id);
                        }
                    }
                    break;
                case "Rejected":
                    review_table.Rows.Clear();
                    var getRejected= await MongoDbServices.JobApplication
                        .Find(x => x.Status == "Accepted")
                        .ToListAsync();

                    if (getRejected.Count > 0)
                    {
                        foreach (var application in getRejected)
                        {
                            var getApplicant = await MongoDbServices.JobSeekerAccount
                                .Find(x => x.Id == application.SeekerId)
                                .FirstOrDefaultAsync();

                            var getPostedJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();

                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getPostedJob.BusinessId)
                                .FirstOrDefaultAsync();

                            string fullname = $"{getApplicant.Firstname} {getApplicant.Middlename} {getApplicant.Lastname}";

                            review_table.Rows.Add(fullname, getBusiness.BusinessName, getPostedJob.JobPosition, application.Status, application.Id);
                        }
                    }
                    break;
                case "All":
                    review_table.Rows.Clear();
                    var getAll = await MongoDbServices.JobApplication
                        .Find(_ => true)
                        .ToListAsync();

                    if (getAll.Count > 0)
                    {
                        foreach (var application in getAll)
                        {
                            var getApplicant = await MongoDbServices.JobSeekerAccount
                                .Find(x => x.Id == application.SeekerId)
                                .FirstOrDefaultAsync();

                            var getPostedJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();

                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getPostedJob.BusinessId)
                                .FirstOrDefaultAsync();

                            string fullname = $"{getApplicant.Firstname} {getApplicant.Middlename} {getApplicant.Lastname}";

                            review_table.Rows.Add(fullname, getBusiness.BusinessName, getPostedJob.JobPosition, application.Status, application.Id);
                        }
                    }
                    break;
            }
        }
    }
}
