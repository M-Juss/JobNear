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

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Profile : UserControl
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public JS_Profile()
        {
            InitializeComponent();
            SetupFileGrid();

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

        private void SetupFileGrid()
        {
            if (file_grid.Columns.Count == 0) // prevent duplicate setup
            {
                file_grid.Columns.Add("Filename", "Filename");

                
                GridStyles.StyleGrid(file_grid);

                
                GridStyles.AddActionButtons(file_grid, includeOpen: true, includeDelete: true);
            }
        }

        private void file_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent invalid clicks (header row, out of bounds, or no rows left)
            if (e.RowIndex < 0 || e.RowIndex >= file_grid.Rows.Count)
                return;

            if (e.ColumnIndex < 0)
                return;

            string fileName = file_grid.Rows[e.RowIndex].Cells["FileName"].Value?.ToString();
            if (string.IsNullOrEmpty(fileName)) return;

            string folderPath = Path.Combine(Application.StartupPath, "SupportingDocs");
            string fullPath = Path.Combine(folderPath, fileName);

            // --- Open Button (column index 1) ---
            if (e.ColumnIndex == 1)
            {
                if (File.Exists(fullPath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = fullPath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }

            // --- Delete Button (column index 2) ---
            else if (e.ColumnIndex == 2)
            {
                var confirm = MessageBox.Show($"Delete {fileName}?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Delete from disk
                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }

                    // Remove row safely
                    file_grid.Rows.RemoveAt(e.RowIndex);

                    // 🛑 Clear selection to stop re-triggering
                    file_grid.ClearSelection();

                    // 🛑 End method immediately
                    return;
                }
            }
        }




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

                    // Add row into grid
                    file_grid.Rows.Add(fileName);
                }
            }
        }
    }
}
