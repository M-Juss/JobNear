namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_JS_UserManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.seeker_table = new System.Windows.Forms.DataGridView();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.table_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.seeker_table)).BeginInit();
            this.table_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "JobSeeker User Management";
            // 
            // seeker_table
            // 
            this.seeker_table.AllowUserToAddRows = false;
            this.seeker_table.AllowUserToDeleteRows = false;
            this.seeker_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seeker_table.Location = new System.Drawing.Point(4, 4);
            this.seeker_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seeker_table.Name = "seeker_table";
            this.seeker_table.ReadOnly = true;
            this.seeker_table.RowHeadersWidth = 51;
            this.seeker_table.Size = new System.Drawing.Size(1297, 639);
            this.seeker_table.TabIndex = 3;
            this.seeker_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seeker_table_CellContentClick);
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Pending",
            "Verified",
            "Pending",
            "Incomplete",
            "All"});
            this.status_combo.Location = new System.Drawing.Point(142, 88);
            this.status_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(160, 28);
            this.status_combo.TabIndex = 4;
            this.status_combo.SelectedIndexChanged += new System.EventHandler(this.status_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // table_panel
            // 
            this.table_panel.Controls.Add(this.seeker_table);
            this.table_panel.Location = new System.Drawing.Point(36, 150);
            this.table_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.table_panel.Name = "table_panel";
            this.table_panel.Size = new System.Drawing.Size(1301, 656);
            this.table_panel.TabIndex = 6;
            // 
            // Admin_JS_UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status_combo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_JS_UserManagement";
            this.Size = new System.Drawing.Size(1375, 868);
            ((System.ComponentModel.ISupportInitialize)(this.seeker_table)).EndInit();
            this.table_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView seeker_table;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel table_panel;
    }
}
