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
            this.company_logo_picturebox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.post_job_button = new System.Windows.Forms.Button();
            this.job_list_flowlayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Job_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).BeginInit();
            this.job_list_flowlayoutpanel.SuspendLayout();
            this.Job_panel.SuspendLayout();
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
            this.business_panel.Location = new System.Drawing.Point(94, 76);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(812, 223);
            this.business_panel.TabIndex = 0;
            // 
            // company_logo_picturebox
            // 
            this.company_logo_picturebox.Image = global::JobNear.Properties.Resources.JobnearLogo;
            this.company_logo_picturebox.Location = new System.Drawing.Point(35, 40);
            this.company_logo_picturebox.Name = "company_logo_picturebox";
            this.company_logo_picturebox.Size = new System.Drawing.Size(150, 150);
            this.company_logo_picturebox.TabIndex = 0;
            this.company_logo_picturebox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 81);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "123 Street City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "ABC Company";
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(722, 16);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 28);
            this.edit_button.TabIndex = 6;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // post_job_button
            // 
            this.post_job_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.post_job_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.post_job_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_job_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_job_button.ForeColor = System.Drawing.SystemColors.Control;
            this.post_job_button.Location = new System.Drawing.Point(413, 338);
            this.post_job_button.Name = "post_job_button";
            this.post_job_button.Size = new System.Drawing.Size(166, 51);
            this.post_job_button.TabIndex = 1;
            this.post_job_button.Text = "Post a Job";
            this.post_job_button.UseVisualStyleBackColor = false;
            this.post_job_button.Click += new System.EventHandler(this.post_job_button_Click);
            // 
            // job_list_flowlayoutpanel
            // 
            this.job_list_flowlayoutpanel.Controls.Add(this.Job_panel);
            this.job_list_flowlayoutpanel.Location = new System.Drawing.Point(94, 411);
            this.job_list_flowlayoutpanel.Name = "job_list_flowlayoutpanel";
            this.job_list_flowlayoutpanel.Size = new System.Drawing.Size(812, 409);
            this.job_list_flowlayoutpanel.TabIndex = 2;
            // 
            // Job_panel
            // 
            this.Job_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Job_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Job_panel.Controls.Add(this.label4);
            this.Job_panel.Controls.Add(this.label5);
            this.Job_panel.Controls.Add(this.label6);
            this.Job_panel.Location = new System.Drawing.Point(5, 10);
            this.Job_panel.Margin = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.Job_panel.Name = "Job_panel";
            this.Job_panel.Size = new System.Drawing.Size(792, 150);
            this.Job_panel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(532, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Job Location | Work Model | Exployment Type";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Job Position";
            // 
            // JP_BusinessDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.job_list_flowlayoutpanel);
            this.Controls.Add(this.post_job_button);
            this.Controls.Add(this.business_panel);
            this.Name = "JP_BusinessDetails";
            this.Size = new System.Drawing.Size(1031, 705);
            this.business_panel.ResumeLayout(false);
            this.business_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).EndInit();
            this.job_list_flowlayoutpanel.ResumeLayout(false);
            this.Job_panel.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel job_list_flowlayoutpanel;
        private System.Windows.Forms.Panel Job_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
