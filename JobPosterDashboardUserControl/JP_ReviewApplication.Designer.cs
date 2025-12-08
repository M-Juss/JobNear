namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_ReviewApplication
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
            this.sidebar_panel.Controls.Add(this.panel1);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.review_table);
            this.panel1.Location = new System.Drawing.Point(21, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 732);
            this.panel1.TabIndex = 0;
            // 
            // review_table
            // 
            this.review_table.AllowUserToAddRows = false;
            this.review_table.AllowUserToDeleteRows = false;
            this.review_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.review_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.review_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.review_table.Location = new System.Drawing.Point(0, 0);
            this.review_table.Margin = new System.Windows.Forms.Padding(4);
            this.review_table.Name = "review_table";
            this.review_table.ReadOnly = true;
            this.review_table.RowHeadersWidth = 51;
            this.review_table.Size = new System.Drawing.Size(1331, 732);
            this.review_table.TabIndex = 4;
            // 
            // JP_ReviewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_ReviewApplication";
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
    }
}
