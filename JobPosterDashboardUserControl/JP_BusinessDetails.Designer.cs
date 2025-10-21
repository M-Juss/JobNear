namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_BusinessDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JP_BusinessDetails));
            this.business_panel = new System.Windows.Forms.Panel();
            this.edit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.company_logo_picturebox = new System.Windows.Forms.PictureBox();
            this.post_job_button = new System.Windows.Forms.Button();
            this.joblist_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).BeginInit();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // business_panel
            // 
            this.business_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.business_panel.Controls.Add(this.edit_button);
            this.business_panel.Controls.Add(this.label3);
            this.business_panel.Controls.Add(this.label2);
            this.business_panel.Controls.Add(this.label1);
            this.business_panel.Controls.Add(this.company_logo_picturebox);
            this.business_panel.Location = new System.Drawing.Point(121, 44);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(800, 223);
            this.business_panel.TabIndex = 0;
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(711, 15);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 28);
            this.edit_button.TabIndex = 6;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 81);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "123 Street City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "ABC Company";
            // 
            // company_logo_picturebox
            // 
            this.company_logo_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.company_logo_picturebox.Image = global::JobNear.Properties.Resources.JobnearLogo;
            this.company_logo_picturebox.Location = new System.Drawing.Point(34, 37);
            this.company_logo_picturebox.Name = "company_logo_picturebox";
            this.company_logo_picturebox.Size = new System.Drawing.Size(150, 150);
            this.company_logo_picturebox.TabIndex = 0;
            this.company_logo_picturebox.TabStop = false;
            // 
            // post_job_button
            // 
            this.post_job_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.post_job_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.post_job_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_job_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_job_button.ForeColor = System.Drawing.SystemColors.Control;
            this.post_job_button.Location = new System.Drawing.Point(430, 289);
            this.post_job_button.Name = "post_job_button";
            this.post_job_button.Size = new System.Drawing.Size(166, 51);
            this.post_job_button.TabIndex = 1;
            this.post_job_button.Text = "Post a Job";
            this.post_job_button.UseVisualStyleBackColor = false;
            // 
            // joblist_flowlayout
            // 
            this.joblist_flowlayout.Location = new System.Drawing.Point(114, 362);
            this.joblist_flowlayout.Name = "joblist_flowlayout";
            this.joblist_flowlayout.Size = new System.Drawing.Size(812, 309);
            this.joblist_flowlayout.TabIndex = 2;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.pictureBox1);
            this.sidebar_panel.Controls.Add(this.joblist_flowlayout);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Controls.Add(this.post_job_button);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobNear.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(22, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // JP_BusinessDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_BusinessDetails";
            this.Size = new System.Drawing.Size(1031, 705);
            this.business_panel.ResumeLayout(false);
            this.business_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).EndInit();
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.PictureBox company_logo_picturebox;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button post_job_button;
        private System.Windows.Forms.FlowLayoutPanel joblist_flowlayout;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
