namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_ViewBusiness
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
            this.report_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.business_panel = new System.Windows.Forms.Panel();
            this.description_label = new System.Windows.Forms.Label();
            this.footer_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.company_logo_picturebox = new System.Windows.Forms.PictureBox();
            this.joblist_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.report_label);
            this.sidebar_panel.Controls.Add(this.pictureBox1);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Controls.Add(this.joblist_flowlayout);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // report_label
            // 
            this.report_label.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_label.Location = new System.Drawing.Point(1163, 15);
            this.report_label.Name = "report_label";
            this.report_label.Size = new System.Drawing.Size(189, 34);
            this.report_label.TabIndex = 9;
            this.report_label.Text = "Report an Issue";
            this.report_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.report_label.Click += new System.EventHandler(this.report_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobNear.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(20, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // business_panel
            // 
            this.business_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.business_panel.Controls.Add(this.description_label);
            this.business_panel.Controls.Add(this.footer_label);
            this.business_panel.Controls.Add(this.name_label);
            this.business_panel.Controls.Add(this.company_logo_picturebox);
            this.business_panel.Location = new System.Drawing.Point(20, 62);
            this.business_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(1333, 260);
            this.business_panel.TabIndex = 5;
            // 
            // description_label
            // 
            this.description_label.AutoEllipsis = true;
            this.description_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(365, 85);
            this.description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(880, 117);
            this.description_label.TabIndex = 5;
            // 
            // footer_label
            // 
            this.footer_label.AutoEllipsis = true;
            this.footer_label.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer_label.ForeColor = System.Drawing.Color.Gray;
            this.footer_label.Location = new System.Drawing.Point(365, 214);
            this.footer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.footer_label.Name = "footer_label";
            this.footer_label.Size = new System.Drawing.Size(880, 23);
            this.footer_label.TabIndex = 4;
            // 
            // name_label
            // 
            this.name_label.AllowDrop = true;
            this.name_label.AutoEllipsis = true;
            this.name_label.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(365, 25);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(880, 47);
            this.name_label.TabIndex = 3;
            // 
            // company_logo_picturebox
            // 
            this.company_logo_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.company_logo_picturebox.Location = new System.Drawing.Point(83, 21);
            this.company_logo_picturebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.company_logo_picturebox.Name = "company_logo_picturebox";
            this.company_logo_picturebox.Size = new System.Drawing.Size(253, 216);
            this.company_logo_picturebox.TabIndex = 0;
            this.company_logo_picturebox.TabStop = false;
            // 
            // joblist_flowlayout
            // 
            this.joblist_flowlayout.Location = new System.Drawing.Point(20, 330);
            this.joblist_flowlayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.joblist_flowlayout.Name = "joblist_flowlayout";
            this.joblist_flowlayout.Size = new System.Drawing.Size(1333, 512);
            this.joblist_flowlayout.TabIndex = 3;
            // 
            // JS_ViewBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JS_ViewBusiness";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.business_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.FlowLayoutPanel joblist_flowlayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label report_label;
        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label footer_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox company_logo_picturebox;
    }
}
