using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_VerifyRequirement : UserControl
    {
        public Admin_VerifyRequirement()
        {
            InitializeComponent();
            SetUpTable();

            ButtonStyle.RoundedButton(add_button, 10, "#10B981");

            status_combo.SelectedIndex = 0;

        }
        private void SetUpTable()
        {

            requirements_table.CellPainting += (s, e) =>
            {
                if (e.RowIndex < 0) return;

                Rectangle rect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5,
                                               e.CellBounds.Width - 10, e.CellBounds.Height - 10);

                int radius = 12;

                if (requirements_table.Columns[e.ColumnIndex].Name == "View" ||
                    requirements_table.Columns[e.ColumnIndex].Name == "Delete")
                {
                    e.PaintBackground(e.ClipBounds, true);

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        // Correct AddArc usage
                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);                // top-left
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);  // top-right
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // bottom-right
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);  // bottom-left
                        path.CloseAllFigures();

                        // Fill color
                        Color fillColor = requirements_table.Columns[e.ColumnIndex].Name == "View"
                                          ? ColorTranslator.FromHtml("#E0F0FF")
                                          : ColorTranslator.FromHtml("#FEE0E0");

                        using (SolidBrush brush = new SolidBrush(fillColor))
                            e.Graphics.FillPath(brush, path);

                        // Border color
                        Color borderColor = requirements_table.Columns[e.ColumnIndex].Name == "View"
                                            ? ColorTranslator.FromHtml("#A5C8F0")
                                            : ColorTranslator.FromHtml("#F5A5A5");

                        using (Pen pen = new Pen(borderColor, 1))
                            e.Graphics.DrawPath(pen, path);

                        // Draw text
                        string text = requirements_table.Columns[e.ColumnIndex].Name;
                        TextRenderer.DrawText(e.Graphics, text, new Font("Poppins", 12, FontStyle.Regular),
                                              rect, Color.Black,
                                              TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    }

                    e.Handled = true;
                }
            };



            TableStyles.UserTables(requirements_table);

            requirements_table.Columns.Add("Document Name", "Document Name");
            requirements_table.Columns.Add("Type", "Type");
            requirements_table.Columns.Add("Description", "Description");
            requirements_table.Columns.Add("User Type", "User Type");
            requirements_table.Columns.Add("DocumentId", "DocumentId");

            requirements_table.Columns["User Type"].Visible = false;
            requirements_table.Columns["DocumentId"].Visible = false;


            var viewButton = new DataGridViewButtonColumn();
            viewButton.Name = "View";
            viewButton.HeaderText = "Action";
            viewButton.Text = "View";
            viewButton.UseColumnTextForButtonValue = true;
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.Width = 60;
            viewButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Regular);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.FlatStyle = FlatStyle.Standard;
            deleteButton.Width = 60;
            deleteButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Regular);

            requirements_table.Columns.Add(viewButton);
            requirements_table.Columns.Add(deleteButton);
        }

        private void add_button_Click_1(object sender, EventArgs e)
        {
            Admin_AddVerifyRequirement addRequirementControl = new Admin_AddVerifyRequirement();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(addRequirementControl);
            addRequirementControl.Dock = DockStyle.Fill;
        }

        private async void status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status_combo.SelectedItem.ToString() == "For Job Seekers")
            {
                var getDocu = await MongoDbServices.RequirementGuide
                    .Find(x => x.UserType == "For Job Seeker")
                    .ToListAsync();

                if (getDocu != null)
                {

                    requirements_table.Rows.Clear();
                    getDocu.ForEach(docu =>
                    {
                        requirements_table.Rows.Add(
                            docu.DocumentName,
                            docu.RequirementType,
                            docu.DocumentDescription,
                            docu.UserType,
                            docu.Id
                        );
                    });

                }
            }
            else if (status_combo.SelectedItem.ToString() == "For Job Posters")
            {
                var getDocu = await MongoDbServices.RequirementGuide
                    .Find(x => x.UserType == "For Job Poster")
                    .ToListAsync();

                if (getDocu != null)
                {
                    requirements_table.Rows.Clear();
                    getDocu.ForEach(docu =>
                    {
                        requirements_table.Rows.Add(
                            docu.DocumentName,
                            docu.RequirementType,
                            docu.DocumentDescription,
                            docu.UserType,
                            docu.Id
                        );
                    });
                }
            }
        }

        private async void requirements_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string documentId = requirements_table.Rows[e.RowIndex].Cells["DocumentId"].Value?.ToString();

            if (string.IsNullOrEmpty(documentId))
            {
                MessageBox.Show("Invalid document ID.");
                return;
            }


            if (requirements_table.Columns[e.ColumnIndex].Name == "View")
            {
                var filter = Builders<RequirementGuideModel>.Filter.Eq(x => x.Id, documentId);
                var doc = await MongoDbServices.RequirementGuide.Find(filter).FirstOrDefaultAsync();

                if (doc == null)
                {
                    MessageBox.Show("Document not found in database.");
                    return;
                }

                if (doc.SupportingDocuments == null || doc.SupportingDocuments.Count == 0)
                {
                    MessageBox.Show("This requirement has no supporting file.");
                    return;
                }

                var file = doc.SupportingDocuments[0];
                byte[] bytes = file.FileContent;
                string tempPath = Path.Combine(Path.GetTempPath(), file.FileName);

                File.WriteAllBytes(tempPath, bytes);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = tempPath,
                    UseShellExecute = true
                });
            }

            else if (requirements_table.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this requirement?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var filter = Builders<RequirementGuideModel>.Filter.Eq(x => x.Id, documentId);
                    await MongoDbServices.RequirementGuide.DeleteOneAsync(filter);

                    requirements_table.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Requirement deleted successfully.");
                }
            }
        }

    }
}
