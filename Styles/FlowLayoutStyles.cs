using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Styles
{
    public class FlowLayoutStyles
    {
        public static void AddFileItem(string filePath, FlowLayoutPanel docu_flowlayout)
        {
            Panel filePanel = new Panel();
            filePanel.Width = 765;
            filePanel.Height = 50;
            filePanel.BackColor = Color.White;
            filePanel.Margin = new Padding(0, 0, 0, 2);
            filePanel.Padding = new Padding(10);
            filePanel.BorderStyle = BorderStyle.None;

            // ✅ Save filePath inside Tag so we can retrieve it later
            filePanel.Tag = filePath;

            filePanel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, filePanel.ClientRectangle,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            PictureBox picIcon = new PictureBox();
            picIcon.Width = 30;
            picIcon.Height = 30;
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.Location = new Point(10, 10);

            try
            {
                Icon sysIcon = Icon.ExtractAssociatedIcon(filePath);
                picIcon.Image = sysIcon.ToBitmap();
            }
            catch
            {
                picIcon.Image = SystemIcons.Application.ToBitmap();
            }

            Label lbl = new Label();
            lbl.Text = Path.GetFileName(filePath);
            lbl.AutoSize = false;
            lbl.Width = 180;
            lbl.Height = 30;
            lbl.Location = new Point(70, 10);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Poppins", 12, FontStyle.Regular);
            lbl.ForeColor = Color.Black;

            Button btnPreview = new Button();
            btnPreview.Width = 30;
            btnPreview.Height = 30;
            btnPreview.Location = new Point(680, 10);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.BackColor = Color.Transparent;
            btnPreview.Text = "👁";
            btnPreview.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnPreview.ForeColor = Color.DimGray;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.Click += (s, e) =>
            {
                string fullPath = filePanel.Tag?.ToString(); // ✅ Use Tag
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
            };

            Button btnDelete = new Button();
            btnDelete.Width = 30;
            btnDelete.Height = 30;
            btnDelete.Location = new Point(720, 10);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Text = "🗑";
            btnDelete.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += (s, e) =>
            {
                string fullPath = filePanel.Tag?.ToString(); // ✅ Use Tag
                string fileName = Path.GetFileName(fullPath);

                var confirm = MessageBox.Show($"Delete {fileName}?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }
                    filePanel.Dispose();
                }
            };

            filePanel.Controls.Add(picIcon);
            filePanel.Controls.Add(lbl);
            filePanel.Controls.Add(btnPreview);
            filePanel.Controls.Add(btnDelete);

            docu_flowlayout.Controls.Add(filePanel);
        }

    }
}
