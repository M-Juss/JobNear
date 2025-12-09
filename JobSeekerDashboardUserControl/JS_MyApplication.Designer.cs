namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_MyApplication
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
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.review_table = new System.Windows.Forms.DataGridView();
            this.sidebar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.review_table)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.status_combo);
            this.sidebar_panel.Controls.Add(this.panel1);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Submitted",
            "Accepted",
            "Rejected",
            "All"});
            this.status_combo.Location = new System.Drawing.Point(19, 45);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(192, 44);
            this.status_combo.TabIndex = 5;
            this.status_combo.SelectedIndexChanged += new System.EventHandler(this.status_combo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.review_table);
            this.panel1.Location = new System.Drawing.Point(19, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 754);
            this.panel1.TabIndex = 0;
            // 
            // review_table
            // 
            this.review_table.AllowUserToAddRows = false;
            this.review_table.AllowUserToDeleteRows = false;
            this.review_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.review_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.review_table.Location = new System.Drawing.Point(0, 0);
            this.review_table.Margin = new System.Windows.Forms.Padding(4);
            this.review_table.Name = "review_table";
            this.review_table.ReadOnly = true;
            this.review_table.RowHeadersWidth = 51;
            this.review_table.Size = new System.Drawing.Size(1337, 754);
            this.review_table.TabIndex = 4;
            this.review_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.review_table_CellContentClick);
            // 
            // JS_MyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JS_MyApplication";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.review_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView review_table;
        private System.Windows.Forms.ComboBox status_combo;
    }
}
