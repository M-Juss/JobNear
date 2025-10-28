namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_PostJobForm
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
            this.hourly_input = new System.Windows.Forms.TextBox();
            this.paymenttype_label = new System.Windows.Forms.Label();
            this.payment_combo = new System.Windows.Forms.ComboBox();
            this.monthly_input = new System.Windows.Forms.TextBox();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.post_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.responsibilities_richbox = new System.Windows.Forms.RichTextBox();
            this.about_job_richbox = new System.Windows.Forms.RichTextBox();
            this.preferred_qualification_richbox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.min_qualification_richbox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fully_office_radiobtn = new System.Windows.Forms.RadioButton();
            this.hybrid_radiobtn = new System.Windows.Forms.RadioButton();
            this.fully_remote_radiobtn = new System.Windows.Forms.RadioButton();
            this.full_time_checkbox = new System.Windows.Forms.CheckBox();
            this.part_time_checkbox = new System.Windows.Forms.CheckBox();
            this.address_input = new System.Windows.Forms.TextBox();
            this.title_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.AutoScroll = true;
            this.sidebar_panel.Controls.Add(this.hourly_input);
            this.sidebar_panel.Controls.Add(this.paymenttype_label);
            this.sidebar_panel.Controls.Add(this.payment_combo);
            this.sidebar_panel.Controls.Add(this.monthly_input);
            this.sidebar_panel.Controls.Add(this.status_combo);
            this.sidebar_panel.Controls.Add(this.label11);
            this.sidebar_panel.Controls.Add(this.label10);
            this.sidebar_panel.Controls.Add(this.panel4);
            this.sidebar_panel.Controls.Add(this.post_button);
            this.sidebar_panel.Controls.Add(this.cancel_button);
            this.sidebar_panel.Controls.Add(this.responsibilities_richbox);
            this.sidebar_panel.Controls.Add(this.about_job_richbox);
            this.sidebar_panel.Controls.Add(this.preferred_qualification_richbox);
            this.sidebar_panel.Controls.Add(this.label8);
            this.sidebar_panel.Controls.Add(this.label7);
            this.sidebar_panel.Controls.Add(this.label6);
            this.sidebar_panel.Controls.Add(this.min_qualification_richbox);
            this.sidebar_panel.Controls.Add(this.label5);
            this.sidebar_panel.Controls.Add(this.label9);
            this.sidebar_panel.Controls.Add(this.fully_office_radiobtn);
            this.sidebar_panel.Controls.Add(this.hybrid_radiobtn);
            this.sidebar_panel.Controls.Add(this.fully_remote_radiobtn);
            this.sidebar_panel.Controls.Add(this.full_time_checkbox);
            this.sidebar_panel.Controls.Add(this.part_time_checkbox);
            this.sidebar_panel.Controls.Add(this.address_input);
            this.sidebar_panel.Controls.Add(this.title_input);
            this.sidebar_panel.Controls.Add(this.label4);
            this.sidebar_panel.Controls.Add(this.label3);
            this.sidebar_panel.Controls.Add(this.label2);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // hourly_input
            // 
            this.hourly_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourly_input.Location = new System.Drawing.Point(343, 824);
            this.hourly_input.Name = "hourly_input";
            this.hourly_input.Size = new System.Drawing.Size(276, 31);
            this.hourly_input.TabIndex = 137;
            // 
            // paymenttype_label
            // 
            this.paymenttype_label.AutoSize = true;
            this.paymenttype_label.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymenttype_label.Location = new System.Drawing.Point(337, 789);
            this.paymenttype_label.Name = "paymenttype_label";
            this.paymenttype_label.Size = new System.Drawing.Size(185, 34);
            this.paymenttype_label.TabIndex = 136;
            this.paymenttype_label.Text = "Salary per month";
            // 
            // payment_combo
            // 
            this.payment_combo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_combo.FormattingEnabled = true;
            this.payment_combo.Items.AddRange(new object[] {
            "Monthly Salary",
            "Hourly Rate "});
            this.payment_combo.Location = new System.Drawing.Point(81, 825);
            this.payment_combo.Name = "payment_combo";
            this.payment_combo.Size = new System.Drawing.Size(225, 30);
            this.payment_combo.TabIndex = 135;
            this.payment_combo.SelectedIndexChanged += new System.EventHandler(this.payment_combo_SelectedIndexChanged);
            // 
            // monthly_input
            // 
            this.monthly_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly_input.Location = new System.Drawing.Point(343, 824);
            this.monthly_input.Name = "monthly_input";
            this.monthly_input.Size = new System.Drawing.Size(276, 31);
            this.monthly_input.TabIndex = 134;
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Active",
            "Closed",
            "Withdrawn"});
            this.status_combo.Location = new System.Drawing.Point(653, 824);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(270, 30);
            this.status_combo.TabIndex = 133;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(647, 789);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 34);
            this.label11.TabIndex = 132;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 789);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 34);
            this.label10.TabIndex = 131;
            this.label10.Text = "Payment Type";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(103, 950);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(787, 1);
            this.panel4.TabIndex = 130;
            // 
            // post_button
            // 
            this.post_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_button.Location = new System.Drawing.Point(887, 885);
            this.post_button.Name = "post_button";
            this.post_button.Size = new System.Drawing.Size(109, 36);
            this.post_button.TabIndex = 129;
            this.post_button.Text = "Post";
            this.post_button.UseVisualStyleBackColor = true;
            this.post_button.Click += new System.EventHandler(this.post_button_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(777, 885);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(104, 36);
            this.cancel_button.TabIndex = 128;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // responsibilities_richbox
            // 
            this.responsibilities_richbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.responsibilities_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsibilities_richbox.Location = new System.Drawing.Point(83, 700);
            this.responsibilities_richbox.Name = "responsibilities_richbox";
            this.responsibilities_richbox.Size = new System.Drawing.Size(866, 81);
            this.responsibilities_richbox.TabIndex = 127;
            this.responsibilities_richbox.Text = "";
            // 
            // about_job_richbox
            // 
            this.about_job_richbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.about_job_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_job_richbox.Location = new System.Drawing.Point(83, 570);
            this.about_job_richbox.Name = "about_job_richbox";
            this.about_job_richbox.Size = new System.Drawing.Size(866, 81);
            this.about_job_richbox.TabIndex = 126;
            this.about_job_richbox.Text = "";
            // 
            // preferred_qualification_richbox
            // 
            this.preferred_qualification_richbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preferred_qualification_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferred_qualification_richbox.Location = new System.Drawing.Point(82, 440);
            this.preferred_qualification_richbox.Name = "preferred_qualification_richbox";
            this.preferred_qualification_richbox.Size = new System.Drawing.Size(866, 81);
            this.preferred_qualification_richbox.TabIndex = 125;
            this.preferred_qualification_richbox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 663);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 34);
            this.label8.TabIndex = 124;
            this.label8.Text = "Responsibilities";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 34);
            this.label7.TabIndex = 123;
            this.label7.Text = "About the Job";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 34);
            this.label6.TabIndex = 122;
            this.label6.Text = "Preferred Qualifications";
            // 
            // min_qualification_richbox
            // 
            this.min_qualification_richbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.min_qualification_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_qualification_richbox.Location = new System.Drawing.Point(81, 310);
            this.min_qualification_richbox.Name = "min_qualification_richbox";
            this.min_qualification_richbox.Size = new System.Drawing.Size(866, 81);
            this.min_qualification_richbox.TabIndex = 121;
            this.min_qualification_richbox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 34);
            this.label5.TabIndex = 120;
            this.label5.Text = "Minimum Qualifications";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 56);
            this.label9.TabIndex = 119;
            this.label9.Text = "Post a Job";
            // 
            // fully_office_radiobtn
            // 
            this.fully_office_radiobtn.AutoSize = true;
            this.fully_office_radiobtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fully_office_radiobtn.Location = new System.Drawing.Point(587, 245);
            this.fully_office_radiobtn.Name = "fully_office_radiobtn";
            this.fully_office_radiobtn.Size = new System.Drawing.Size(139, 32);
            this.fully_office_radiobtn.TabIndex = 118;
            this.fully_office_radiobtn.TabStop = true;
            this.fully_office_radiobtn.Text = "Fully In-Office";
            this.fully_office_radiobtn.UseVisualStyleBackColor = true;
            // 
            // hybrid_radiobtn
            // 
            this.hybrid_radiobtn.AutoSize = true;
            this.hybrid_radiobtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hybrid_radiobtn.Location = new System.Drawing.Point(769, 245);
            this.hybrid_radiobtn.Name = "hybrid_radiobtn";
            this.hybrid_radiobtn.Size = new System.Drawing.Size(82, 32);
            this.hybrid_radiobtn.TabIndex = 117;
            this.hybrid_radiobtn.TabStop = true;
            this.hybrid_radiobtn.Text = "Hybrid";
            this.hybrid_radiobtn.UseVisualStyleBackColor = true;
            // 
            // fully_remote_radiobtn
            // 
            this.fully_remote_radiobtn.AutoSize = true;
            this.fully_remote_radiobtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fully_remote_radiobtn.Location = new System.Drawing.Point(409, 245);
            this.fully_remote_radiobtn.Name = "fully_remote_radiobtn";
            this.fully_remote_radiobtn.Size = new System.Drawing.Size(131, 32);
            this.fully_remote_radiobtn.TabIndex = 116;
            this.fully_remote_radiobtn.TabStop = true;
            this.fully_remote_radiobtn.Text = "Fully Remote";
            this.fully_remote_radiobtn.UseVisualStyleBackColor = true;
            // 
            // full_time_checkbox
            // 
            this.full_time_checkbox.AutoSize = true;
            this.full_time_checkbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_time_checkbox.Location = new System.Drawing.Point(257, 245);
            this.full_time_checkbox.Name = "full_time_checkbox";
            this.full_time_checkbox.Size = new System.Drawing.Size(105, 32);
            this.full_time_checkbox.TabIndex = 115;
            this.full_time_checkbox.Text = "Full-Time";
            this.full_time_checkbox.UseVisualStyleBackColor = true;
            // 
            // part_time_checkbox
            // 
            this.part_time_checkbox.AutoSize = true;
            this.part_time_checkbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_time_checkbox.Location = new System.Drawing.Point(81, 245);
            this.part_time_checkbox.Name = "part_time_checkbox";
            this.part_time_checkbox.Size = new System.Drawing.Size(111, 32);
            this.part_time_checkbox.TabIndex = 114;
            this.part_time_checkbox.Text = "Part-Time";
            this.part_time_checkbox.UseVisualStyleBackColor = true;
            // 
            // address_input
            // 
            this.address_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(79, 170);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(867, 31);
            this.address_input.TabIndex = 113;
            // 
            // title_input
            // 
            this.title_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_input.Location = new System.Drawing.Point(79, 94);
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(867, 31);
            this.title_input.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 34);
            this.label4.TabIndex = 111;
            this.label4.Text = "Type of Work Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 34);
            this.label3.TabIndex = 110;
            this.label3.Text = "Employment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 34);
            this.label2.TabIndex = 109;
            this.label2.Text = "Job Location / Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 34);
            this.label1.TabIndex = 108;
            this.label1.Text = "Job Position / Title";
            // 
            // JP_PostJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_PostJobForm";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.TextBox hourly_input;
        private System.Windows.Forms.Label paymenttype_label;
        private System.Windows.Forms.ComboBox payment_combo;
        private System.Windows.Forms.TextBox monthly_input;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button post_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.RichTextBox responsibilities_richbox;
        private System.Windows.Forms.RichTextBox about_job_richbox;
        private System.Windows.Forms.RichTextBox preferred_qualification_richbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox min_qualification_richbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton fully_office_radiobtn;
        private System.Windows.Forms.RadioButton hybrid_radiobtn;
        private System.Windows.Forms.RadioButton fully_remote_radiobtn;
        private System.Windows.Forms.CheckBox full_time_checkbox;
        private System.Windows.Forms.CheckBox part_time_checkbox;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.TextBox title_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
