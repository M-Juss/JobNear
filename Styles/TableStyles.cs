using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Styles
{
    public class TableStyles
    {
        public static void UserTables(DataGridView user_table) {

            user_table.Dock = DockStyle.Fill;
            user_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            user_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            user_table.RowHeadersVisible = false;

            user_table.BackgroundColor = Color.White;
            user_table.BorderStyle = BorderStyle.None;
            user_table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            user_table.GridColor = Color.LightGray;

            user_table.EnableHeadersVisualStyles = false;
            user_table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            user_table.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#3B82F6");
            user_table.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            user_table.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            user_table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            user_table.ColumnHeadersHeight = 35;
            user_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            user_table.DefaultCellStyle.BackColor = Color.White;
            user_table.DefaultCellStyle.ForeColor = Color.Black;
            user_table.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 120, 216);
            user_table.DefaultCellStyle.SelectionForeColor = Color.White;
            user_table.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            user_table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);

            user_table.DefaultCellStyle.Padding = new Padding(6, 6, 6, 6);
        }
    }
}
