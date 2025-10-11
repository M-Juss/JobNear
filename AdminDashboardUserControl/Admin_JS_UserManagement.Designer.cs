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
            this.table_panel = new System.Windows.Forms.Panel();
            this.seeker_table = new System.Windows.Forms.DataGridView();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.table_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seeker_table)).BeginInit();
            this.sidebar_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_panel
            // 
            this.table_panel.Controls.Add(this.seeker_table);
            this.table_panel.Location = new System.Drawing.Point(29, 160);
            this.table_panel.Margin = new System.Windows.Forms.Padding(4);
            this.table_panel.Name = "table_panel";
            this.table_panel.Size = new System.Drawing.Size(1301, 503);
            this.table_panel.TabIndex = 6;
            // 
            // seeker_table
            // 
            this.seeker_table.AllowUserToAddRows = false;
            this.seeker_table.AllowUserToDeleteRows = false;
            this.seeker_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seeker_table.Location = new System.Drawing.Point(4, 4);
            this.seeker_table.Margin = new System.Windows.Forms.Padding(4);
            this.seeker_table.Name = "seeker_table";
            this.seeker_table.ReadOnly = true;
            this.seeker_table.RowHeadersWidth = 51;
            this.seeker_table.Size = new System.Drawing.Size(1297, 483);
            this.seeker_table.TabIndex = 3;
            this.seeker_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seeker_table_CellContentClick);
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.panel5);
            this.sidebar_panel.Controls.Add(this.panel4);
            this.sidebar_panel.Controls.Add(this.panel3);
            this.sidebar_panel.Controls.Add(this.panel2);
            this.sidebar_panel.Controls.Add(this.search_input);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.table_panel);
            this.sidebar_panel.Controls.Add(this.status_combo);
            this.sidebar_panel.Controls.Add(this.label2);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(1027, 684);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 154);
            this.panel5.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 50);
            this.label11.TabIndex = 4;
            this.label11.Text = "#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 50);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rejected Users";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(697, 684);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 154);
            this.panel4.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 50);
            this.label10.TabIndex = 3;
            this.label10.Text = "#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "Incomplete Users";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(365, 684);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 154);
            this.panel3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 50);
            this.label9.TabIndex = 2;
            this.label9.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pending Users";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(33, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 154);
            this.panel2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 50);
            this.label8.TabIndex = 1;
            this.label8.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Verified Users";
            // 
            // search_input
            // 
            this.search_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_input.Location = new System.Drawing.Point(29, 111);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(813, 37);
            this.search_input.TabIndex = 7;
            this.search_input.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_input_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "JobSeeker User Management";
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Pending",
            "Verified",
            "Pending",
            "Incomplete",
            "All"});
            this.status_combo.Location = new System.Drawing.Point(1170, 110);
            this.status_combo.Margin = new System.Windows.Forms.Padding(4);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(160, 38);
            this.status_combo.TabIndex = 4;
            this.status_combo.SelectedIndexChanged += new System.EventHandler(this.status_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1001, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter by status:";
            // 
            // Admin_JS_UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_JS_UserManagement";
            this.Size = new System.Drawing.Size(1375, 868);
            this.table_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seeker_table)).EndInit();
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel table_panel;
        private System.Windows.Forms.DataGridView seeker_table;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
