using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Styles
{
    public class GridStyles
    {
        // 1. MODERN GRID WITH BLACK BORDERS
        public static void StyleGrid(DataGridView grid)
        {
            // Basic grid settings
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.BackgroundColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = true; // Made visible as requested
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = false;
            grid.RowHeadersWidth = 30;

            // Modern header style with black borders
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // White background as requested
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersHeight = 45;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Row header style
            grid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            grid.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.RowHeadersDefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);

            // Modern row styles
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            grid.RowTemplate.Height = 40;

            // Alternating row colors for better readability
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Selection styling
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            // Black borders as requested
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grid.GridColor = Color.Black;
        }

        // 2. DARK MODE GRID
        public static void DarkModeGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.BackgroundColor = Color.FromArgb(33, 37, 41);
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.RowHeadersWidth = 30;

            // Dark header
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 58, 64);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Bold);
            grid.ColumnHeadersHeight = 45;

            // Dark rows
            grid.DefaultCellStyle.BackColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            grid.RowTemplate.Height = 40;

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 44, 48);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grid.GridColor = Color.FromArgb(73, 80, 87);
        }

        // 3. MINIMAL CLEAN GRID
        public static void MinimalGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;

            // Clean header
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(73, 80, 87);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Clean rows
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(12, 8, 12, 8);
            grid.RowTemplate.Height = 50;

            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 37, 41);

            // Only horizontal lines
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(233, 236, 239);
        }

        // 4. COLORFUL MODERN GRID
        public static void ColorfulGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.BackgroundColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersWidth = 30;

            // Colorful gradient header
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 126, 234);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Bold);
            grid.ColumnHeadersHeight = 50;

            // Modern rows with subtle colors
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            grid.DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
            grid.RowTemplate.Height = 45;

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 89, 182);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grid.GridColor = Color.FromArgb(189, 195, 199);
        }

        // 5. ENHANCED ACTION BUTTONS
        public static void AddActionButtons(DataGridView grid, bool includeOpen = true, bool includeDelete = true)
        {
            if (includeOpen && grid.Columns["Open"] == null)
            {
                DataGridViewButtonColumn openButton = new DataGridViewButtonColumn();
                openButton.Name = "Open";
                openButton.HeaderText = "Actions";
                openButton.Text = "View";
                openButton.UseColumnTextForButtonValue = true;
                openButton.FlatStyle = FlatStyle.Flat;
                openButton.Width = 80;

                // Modern button styling
                openButton.DefaultCellStyle.BackColor = Color.FromArgb(40, 167, 69);
                openButton.DefaultCellStyle.ForeColor = Color.White;
                openButton.DefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Bold);
                openButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.Columns.Add(openButton);
            }

            if (includeDelete && grid.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "";
                deleteButton.Text = "✕";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.Width = 50;

                // Red delete button
                deleteButton.DefaultCellStyle.BackColor = Color.FromArgb(220, 53, 69);
                deleteButton.DefaultCellStyle.ForeColor = Color.White;
                deleteButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);
                deleteButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.Columns.Add(deleteButton);
            }
        }

        // 6. ADD MODERN ICON BUTTONS
        public static void AddIconButtons(DataGridView grid)
        {
            // Edit button
            if (grid.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "";
                editButton.Text = "✎";
                editButton.UseColumnTextForButtonValue = true;
                editButton.FlatStyle = FlatStyle.Flat;
                editButton.Width = 45;
                editButton.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 7);
                editButton.DefaultCellStyle.ForeColor = Color.Black;
                editButton.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                editButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns.Add(editButton);
            }

            // Download button
            if (grid.Columns["Download"] == null)
            {
                DataGridViewButtonColumn downloadButton = new DataGridViewButtonColumn();
                downloadButton.Name = "Download";
                downloadButton.HeaderText = "";
                downloadButton.Text = "⬇";
                downloadButton.UseColumnTextForButtonValue = true;
                downloadButton.FlatStyle = FlatStyle.Flat;
                downloadButton.Width = 45;
                downloadButton.DefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
                downloadButton.DefaultCellStyle.ForeColor = Color.White;
                downloadButton.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                downloadButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns.Add(downloadButton);
            }
        }

        // 7. APPLY HOVER EFFECTS
        public static void AddHoverEffects(DataGridView grid)
        {
            grid.CellMouseEnter += (s, e) => {
                if (e.RowIndex >= 0)
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 244, 248);
                }
            };

            grid.CellMouseLeave += (s, e) => {
                if (e.RowIndex >= 0)
                {
                    // Reset to original color
                    if (e.RowIndex % 2 == 0)
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    else
                        grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
                }
            };
        }

        // 8. STRIPE PATTERN GRID
        public static void StripedGrid(DataGridView grid)
        {
            StyleGrid(grid); // Apply base styling first

            // Enhanced striped pattern
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 245, 247);
            grid.DefaultCellStyle.BackColor = Color.White;

            // Add subtle selection highlight
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 144, 220);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        // 9. PROFESSIONAL GRID (Best for business apps)
        public static void ProfessionalGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.BackgroundColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = true;
            grid.RowHeadersWidth = 25;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;

            // Professional header
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(52, 58, 64);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Clean rows
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            grid.RowTemplate.Height = 38;

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 253, 254);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            // Subtle borders
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grid.GridColor = Color.FromArgb(221, 226, 230);
        }
    }
}