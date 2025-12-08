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
using JobNear.Styles;

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
    }
}
