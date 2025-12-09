using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using MongoDB.Driver;
using System.Windows.Forms;
using JobNear.Services;
using JobNear.Styles;
using JobNear.AdminDashboardUserControl;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_MyApplication : UserControl
    {
        public JS_MyApplication()
        {
            InitializeComponent();
            SetUpUI();

            status_combo.SelectedIndex = 0;
        }

        private void SetUpUI()
        {
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

            review_table.Columns.Add("Business", "Business");
            review_table.Columns.Add("Job", "Job");
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

        private async void status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = status_combo.SelectedItem.ToString();

            switch (status.ToLower()) {
                case "submitted":
                    review_table.Rows.Clear();
                    var submmitedApplication = await MongoDbServices.JobApplication
                        .Find(x => x.Status == "To Review")
                        .ToListAsync();

                    if (submmitedApplication != null) {
                        foreach (var application in submmitedApplication)
                        {
                            var getJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();
                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getJob.BusinessId)
                                .FirstOrDefaultAsync();

                            review_table.Rows.Add(getBusiness.BusinessName, getJob.JobPosition, "Submitted", application.Id);
                        }
                    }
                    break;
                case "accepted":
                    review_table.Rows.Clear();
                    var acceptedApplication = await MongoDbServices.JobApplication
                        .Find(x => x.Status == "Accepted")
                        .ToListAsync();

                    if (acceptedApplication != null)
                    {
                        foreach (var application in acceptedApplication)
                        {
                            var getJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();
                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getJob.BusinessId)
                                .FirstOrDefaultAsync();

                            review_table.Rows.Add(getBusiness.BusinessName, getJob.JobPosition, application.Status, application.Id);

                        }
                    }
                    break;
                case "rejected":
                    review_table.Rows.Clear();
                    var rejectedApplication = await MongoDbServices.JobApplication
                        .Find(x => x.Status == "Rejected")
                        .ToListAsync();

                    if (rejectedApplication != null)
                    {
                        foreach (var application in rejectedApplication)
                        {
                            var getJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();
                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getJob.BusinessId)
                                .FirstOrDefaultAsync();

                            review_table.Rows.Add(getBusiness.BusinessName, getJob.JobPosition, application.Status, application.Id);
                        }
                    }
                    break;
                case "all":
                    review_table.Rows.Clear();
                    var allApplication = await MongoDbServices.JobApplication
                        .Find(_ => true)
                        .ToListAsync();

                    if (allApplication != null)
                    {
                        foreach (var application in allApplication)
                        {
                            var getJob = await MongoDbServices.JobPosterJobPosting
                                .Find(x => x.Id == application.JobId)
                                .FirstOrDefaultAsync();
                            var getBusiness = await MongoDbServices.JobPosterBusiness
                                .Find(x => x.Id == getJob.BusinessId)
                                .FirstOrDefaultAsync();

                            review_table.Rows.Add(getBusiness.BusinessName, getJob.JobPosition, application.Status, application.Id);
                        }
                    }
                    break;
            }
        }

        private async void review_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == review_table.Columns["Action"].Index)
            {
                
                string applicationId = review_table.Rows[e.RowIndex].Cells["ApplicationId"].Value.ToString();

                var getApplication = await MongoDbServices.JobApplication
                    .Find(x => x.Id == applicationId)
                    .FirstOrDefaultAsync();

                Session.CurrentPostedJobSelected = getApplication.JobId;   

                JS_JobApplication viewInformation = new JS_JobApplication(applicationId, "view");
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(viewInformation);
                viewInformation.Dock = DockStyle.Fill;
            }
        }
    }
}
