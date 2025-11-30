namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_JP_UserManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.search_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.table_panel = new System.Windows.Forms.Panel();
            this.poster_table = new System.Windows.Forms.DataGridView();
            this.sidebar_panel.SuspendLayout();
            this.table_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_table)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.search_input);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.table_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint_1);
            // 
            // search_input
            // 
            this.search_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_input.Location = new System.Drawing.Point(29, 93);
            this.search_input.Margin = new System.Windows.Forms.Padding(2);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(611, 31);
            this.search_input.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Job Posters";
            // 
            // table_panel
            // 
            this.table_panel.Controls.Add(this.poster_table);
            this.table_panel.Location = new System.Drawing.Point(29, 141);
            this.table_panel.Name = "table_panel";
            this.table_panel.Size = new System.Drawing.Size(976, 536);
            this.table_panel.TabIndex = 12;
            // 
            // poster_table
            // 
            this.poster_table.AllowUserToAddRows = false;
            this.poster_table.AllowUserToDeleteRows = false;
            this.poster_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poster_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poster_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poster_table.Location = new System.Drawing.Point(0, 0);
            this.poster_table.Name = "poster_table";
            this.poster_table.ReadOnly = true;
            this.poster_table.RowHeadersWidth = 51;
            this.poster_table.Size = new System.Drawing.Size(976, 536);
            this.poster_table.TabIndex = 3;
            this.poster_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seeker_table_CellContentClick);
            // 
            // Admin_JP_UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_JP_UserManagement";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.table_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poster_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel table_panel;
        private System.Windows.Forms.DataGridView poster_table;
    }
}
