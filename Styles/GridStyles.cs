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
        public static void StyleGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;

            // Header style
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 138);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);

            // Row style
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);
            grid.DefaultCellStyle.SelectionBackColor = Color.White;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Gridlines
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.LightGray;
        }

        public static void AddActionButtons(DataGridView grid, bool includeOpen = true, bool includeDelete = true)
        {
            if (includeOpen && grid.Columns["Open"] == null)
            {
                DataGridViewButtonColumn openButton = new DataGridViewButtonColumn();
                openButton.Name = "Open";
                openButton.HeaderText = "Action";
                openButton.Text = "Open";
                openButton.UseColumnTextForButtonValue = true;
                openButton.FlatStyle = FlatStyle.Flat;
                openButton.DefaultCellStyle.BackColor = Color.White;
                openButton.DefaultCellStyle.ForeColor = Color.White;
                openButton.DefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Bold);
                grid.Columns.Add(openButton);
            }

            if (includeDelete && grid.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.FlatStyle = FlatStyle.Flat;
                deleteButton.DefaultCellStyle.BackColor = Color.White;
                deleteButton.DefaultCellStyle.ForeColor = Color.Black;
                deleteButton.DefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Bold);
                grid.Columns.Add(deleteButton);
            }
        }
    }
}
