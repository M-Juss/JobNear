using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_JP_UserManagement : UserControl
    {
        public Admin_JP_UserManagement()
        {
            InitializeComponent();
            SetUpJpPanel();
        }

        private void SetUpJpPanel()
        {
            poster_table.CellPainting += (s, e) =>
            {
                if (e.RowIndex >= 0 &&
                    e.ColumnIndex == poster_table.Columns["Action"].Index)
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


            TableStyles.UserTables(poster_table);

            poster_table.Columns.Add("Username", "Username");
            poster_table.Columns.Add("Email", "Email");
            poster_table.Columns.Add("Phone", "Phone");

            var actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "Action";
            actionButton.HeaderText = "Action";
            actionButton.Text = "View";
            actionButton.UseColumnTextForButtonValue = true;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Width = 80;

            actionButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Regular);
            actionButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            poster_table.Columns.Add(actionButton);

            InitialTableValue();

        }
        private async void InitialTableValue()
        {

            var posters = await MongoDbServices.JobPosterAccount
                .Find(_ => true)
                .ToListAsync();

            if (posters != null)
            {
                posters.ForEach(poster =>
                {
                    poster_table.Rows.Add(
                        poster.Username,
                        poster.Email,
                        poster.Phone
                    );
                });
            }

        }
        private void seeker_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == poster_table.Columns["Action"].Index)
            {
                string email = poster_table.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                Session.CurrentJobPosterSelected = email;

                JP_ViewInformation viewInformation = new JP_ViewInformation(email);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(viewInformation);
                viewInformation.Dock = DockStyle.Fill;
            }
        }

    }
}
