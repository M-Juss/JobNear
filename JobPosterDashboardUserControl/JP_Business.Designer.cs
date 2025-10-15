namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_Business
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_business_button = new System.Windows.Forms.Button();
            this.business_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_industry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.business_name,
            this.business_industry,
            this.address});
            this.dataGridView1.Location = new System.Drawing.Point(85, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_business_button
            // 
            this.add_business_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_business_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_business_button.Location = new System.Drawing.Point(825, 90);
            this.add_business_button.Name = "add_business_button";
            this.add_business_button.Size = new System.Drawing.Size(106, 28);
            this.add_business_button.TabIndex = 1;
            this.add_business_button.Text = "Add Business";
            this.add_business_button.UseVisualStyleBackColor = false;
            this.add_business_button.Click += new System.EventHandler(this.add_business_button_Click);
            // 
            // business_name
            // 
            this.business_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.business_name.HeaderText = "Business Name";
            this.business_name.Name = "business_name";
            // 
            // business_industry
            // 
            this.business_industry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.business_industry.HeaderText = "Industry";
            this.business_industry.Name = "business_industry";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // JP_Business
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add_business_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JP_Business";
            this.Size = new System.Drawing.Size(1031, 705);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_business_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_industry;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}
