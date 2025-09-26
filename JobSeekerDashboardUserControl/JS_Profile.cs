using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Profile : UserControl
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public JS_Profile()
        {
            InitializeComponent();
            //SetupFileGrid();
            ButtonStyle.RoundedButton(upload_button, 25 , "#F5F5F5");
            ButtonStyle.RoundedButton(attach_file, 25, "#F5F5F5");
            ButtonStyle.RoundedButton(draft_button, 25, "#F5F5F5");
            ButtonStyle.RoundedButton(review_button, 25, "#F5F5F5");

        }

        private void email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void upload_button_Click(object sender, EventArgs e)
        {            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profile_picture.Image = Image.FromFile(ofd.FileName);
            }
            else {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void SetupFileGrid()
        //{
        //    if (file_grid.Columns.Count == 0) // prevent duplicate setup
        //    {
        //        file_grid.Columns.Add("Filename", "Filename");

        //        // Apply the updated modern grid style

        //        // Add modern action buttons
        //        GridStyles.AddActionButtons(file_grid, true, true);

        //        // Add hover effects for interactivity
        //        GridStyles.AddHoverEffects(file_grid);
        //        GridStyles.ProfessionalGrid(file_grid);
        //    }
        //}

        //private void file_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Prevent invalid clicks (header row, out of bounds, or no rows left)
        //    if (e.RowIndex < 0 || e.RowIndex >= file_grid.Rows.Count)
        //        return;

        //    if (e.ColumnIndex < 0)
        //        return;

        //    string fileName = file_grid.Rows[e.RowIndex].Cells["FileName"].Value?.ToString();
        //    if (string.IsNullOrEmpty(fileName)) return;

        //    string folderPath = Path.Combine(Application.StartupPath, "SupportingDocs");
        //    string fullPath = Path.Combine(folderPath, fileName);

        //    // --- Open Button (column index 1) ---
        //    if (e.ColumnIndex == 1)
        //    {
        //        if (File.Exists(fullPath))
        //        {
        //            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
        //            {
        //                FileName = fullPath,
        //                UseShellExecute = true
        //            });
        //        }
        //        else
        //        {
        //            MessageBox.Show("File not found!");
        //        }
        //    }

        //    // --- Delete Button (column index 2) ---
        //    else if (e.ColumnIndex == 2)
        //    {
        //        var confirm = MessageBox.Show($"Delete {fileName}?", "Confirm Delete",
        //            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (confirm == DialogResult.Yes)
        //        {
        //            // Delete from disk
        //            if (File.Exists(fullPath))
        //            {
        //                File.Delete(fullPath);
        //            }

        //            // Remove row safely
        //            file_grid.Rows.RemoveAt(e.RowIndex);

        //            // 🛑 Clear selection to stop re-triggering
        //            file_grid.ClearSelection();

        //            // 🛑 End method immediately
        //            return;
        //        }
        //    }
        //}




        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; // allow multiple uploads
            ofd.Filter = "All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);

                    // Save file to your SupportingDocs folder
                    string savePath = Path.Combine(Application.StartupPath, "SupportingDocs");
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);

                    string destPath = Path.Combine(savePath, fileName);
                    File.Copy(filePath, destPath, true);

                    //// Add row into grid
                    //file_grid.Rows.Add(fileName);
                    AddFileItem(fileName);
                }
            }
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddFileItem(string filePath)
        {
            // Create panel for file item
            Panel filePanel = new Panel();
            filePanel.Width = 400;
            filePanel.Height = 40;
            filePanel.BorderStyle = BorderStyle.FixedSingle;
            filePanel.Margin = new Padding(5);

            // File icon as Label (instead of PictureBox)
            Label lblIcon = new Label();
            lblIcon.Width = 30;
            lblIcon.Height = 30;
            lblIcon.Location = new Point(5, 5);
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;

            try
            {
                // Get system file icon and set as label background
                Icon sysIcon = Icon.ExtractAssociatedIcon(filePath);
                lblIcon.ImageAlign = ContentAlignment.MiddleCenter;
                lblIcon.Image = sysIcon.ToBitmap();
            }
            catch
            {
                lblIcon.Image = SystemIcons.Application.ToBitmap(); // fallback icon
            }

            // File name
            Label lbl = new Label();
            lbl.Text = Path.GetFileName(filePath);
            lbl.AutoSize = true;
            lbl.Location = new Point(45, 12);

            // Preview button (eye)
            Button btnPreview = new Button();
            btnPreview.Width = 30;
            btnPreview.Height = 30;
            btnPreview.Location = new Point(250, 5);
            btnPreview.Image = Properties.Resources.eye; // use your eye.png
            btnPreview.ImageAlign = ContentAlignment.MiddleCenter;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Click += (s, e) =>
            {
                MessageBox.Show("Preview: " + filePath);
            };

            // Delete button (trash)
            Button btnDelete = new Button();
            btnDelete.Width = 30;
            btnDelete.Height = 30;
            btnDelete.Location = new Point(290, 5);
            btnDelete.Image = Properties.Resources; // use your trash.png
            btnDelete.ImageAlign = ContentAlignment.MiddleCenter;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Click += (s, e) =>
            {
                filePanel.Dispose(); // remove the item
            };

            // Add controls to panel
            filePanel.Controls.Add(lblIcon);
            filePanel.Controls.Add(lbl);
            filePanel.Controls.Add(btnPreview);
            filePanel.Controls.Add(btnDelete);

            // Add panel to FlowLayoutPanel
            image_flowlayout.Controls.Add(filePanel);
        }
    }
}
