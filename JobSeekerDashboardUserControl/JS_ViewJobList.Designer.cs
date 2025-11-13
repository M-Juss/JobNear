namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_ViewJobList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.business_panel = new System.Windows.Forms.Panel();
            this.description_label = new System.Windows.Forms.Label();
            this.footer_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.company_logo_picturebox = new System.Windows.Forms.PictureBox();
            this.job_panel = new System.Windows.Forms.Panel();
            this.status_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).BeginInit();
            this.job_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.job_panel);
            this.panel1.Controls.Add(this.business_panel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 705);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job Title";
            // 
            // business_panel
            // 
            this.business_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.business_panel.Controls.Add(this.description_label);
            this.business_panel.Controls.Add(this.footer_label);
            this.business_panel.Controls.Add(this.name_label);
            this.business_panel.Controls.Add(this.company_logo_picturebox);
            this.business_panel.Location = new System.Drawing.Point(15, 14);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(982, 223);
            this.business_panel.TabIndex = 4;
            // 
            // description_label
            // 
            this.description_label.AutoEllipsis = true;
            this.description_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(268, 67);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(660, 104);
            this.description_label.TabIndex = 5;
            // 
            // footer_label
            // 
            this.footer_label.AutoEllipsis = true;
            this.footer_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footer_label.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer_label.ForeColor = System.Drawing.Color.Gray;
            this.footer_label.Location = new System.Drawing.Point(268, 184);
            this.footer_label.Name = "footer_label";
            this.footer_label.Size = new System.Drawing.Size(660, 22);
            this.footer_label.TabIndex = 4;
            // 
            // name_label
            // 
            this.name_label.AllowDrop = true;
            this.name_label.AutoEllipsis = true;
            this.name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(268, 17);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(660, 36);
            this.name_label.TabIndex = 3;
            // 
            // company_logo_picturebox
            // 
            this.company_logo_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.company_logo_picturebox.Location = new System.Drawing.Point(48, 17);
            this.company_logo_picturebox.Name = "company_logo_picturebox";
            this.company_logo_picturebox.Size = new System.Drawing.Size(206, 189);
            this.company_logo_picturebox.TabIndex = 0;
            this.company_logo_picturebox.TabStop = false;
            // 
            // job_panel
            // 
            this.job_panel.Controls.Add(this.label8);
            this.job_panel.Controls.Add(this.label9);
            this.job_panel.Controls.Add(this.label10);
            this.job_panel.Controls.Add(this.label11);
            this.job_panel.Controls.Add(this.label6);
            this.job_panel.Controls.Add(this.label7);
            this.job_panel.Controls.Add(this.label5);
            this.job_panel.Controls.Add(this.label4);
            this.job_panel.Controls.Add(this.panel2);
            this.job_panel.Controls.Add(this.label3);
            this.job_panel.Controls.Add(this.label2);
            this.job_panel.Controls.Add(this.status_label);
            this.job_panel.Controls.Add(this.label1);
            this.job_panel.Location = new System.Drawing.Point(15, 254);
            this.job_panel.Name = "job_panel";
            this.job_panel.Size = new System.Drawing.Size(982, 435);
            this.job_panel.TabIndex = 6;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(823, 21);
            this.status_label.Name = "status_label";
            this.status_label.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.status_label.Size = new System.Drawing.Size(105, 28);
            this.status_label.TabIndex = 6;
            this.status_label.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "JOb Infos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(859, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(45, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 1);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "About the Job:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(47, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 131);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(48, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 131);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Responsibilities";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(499, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(431, 131);
            this.label8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "Minimum Qualities:";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(498, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(432, 131);
            this.label10.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(491, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "Preffered Qualities:";
            // 
            // JS_ViewJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Name = "JS_ViewJobList";
            this.Size = new System.Drawing.Size(1031, 705);
            this.panel1.ResumeLayout(false);
            this.business_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).EndInit();
            this.job_panel.ResumeLayout(false);
            this.job_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label footer_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox company_logo_picturebox;
        private System.Windows.Forms.Panel job_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
