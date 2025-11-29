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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fully_office_radiobtn = new System.Windows.Forms.RadioButton();
            this.hybrid_radiobtn = new System.Windows.Forms.RadioButton();
            this.fully_remote_radiobtn = new System.Windows.Forms.RadioButton();
            this.full_time_checkbox = new System.Windows.Forms.CheckBox();
            this.part_time_checkbox = new System.Windows.Forms.CheckBox();
            this.title_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.job_panel = new System.Windows.Forms.Panel();
            this.min_qualification_richbox = new System.Windows.Forms.TextBox();
            this.preferred_qualification_richbox = new System.Windows.Forms.TextBox();
            this.about_job_richbox = new System.Windows.Forms.TextBox();
            this.responsibilities_richbox = new System.Windows.Forms.TextBox();
            this.sidebar_panel.SuspendLayout();
            this.job_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.AutoScroll = true;
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.panel4);
            this.sidebar_panel.Controls.Add(this.label9);
            this.sidebar_panel.Controls.Add(this.job_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // hourly_input
            // 
            this.hourly_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourly_input.Location = new System.Drawing.Point(426, 1222);
            this.hourly_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hourly_input.Multiline = true;
            this.hourly_input.Name = "hourly_input";
            this.hourly_input.Size = new System.Drawing.Size(367, 50);
            this.hourly_input.TabIndex = 137;
            this.hourly_input.TextChanged += new System.EventHandler(this.hourly_input_TextChanged);
            // 
            // paymenttype_label
            // 
            this.paymenttype_label.AutoSize = true;
            this.paymenttype_label.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymenttype_label.Location = new System.Drawing.Point(422, 1182);
            this.paymenttype_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymenttype_label.Name = "paymenttype_label";
            this.paymenttype_label.Size = new System.Drawing.Size(231, 42);
            this.paymenttype_label.TabIndex = 136;
            this.paymenttype_label.Text = "Salary per month";
            this.paymenttype_label.Click += new System.EventHandler(this.paymenttype_label_Click);
            // 
            // payment_combo
            // 
            this.payment_combo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_combo.FormattingEnabled = true;
            this.payment_combo.Items.AddRange(new object[] {
            "Monthly Salary",
            "Hourly Rate "});
            this.payment_combo.Location = new System.Drawing.Point(50, 1225);
            this.payment_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payment_combo.Name = "payment_combo";
            this.payment_combo.Size = new System.Drawing.Size(330, 44);
            this.payment_combo.TabIndex = 135;
            this.payment_combo.SelectedIndexChanged += new System.EventHandler(this.payment_combo_SelectedIndexChanged);
            // 
            // monthly_input
            // 
            this.monthly_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly_input.Location = new System.Drawing.Point(426, 1222);
            this.monthly_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monthly_input.Multiline = true;
            this.monthly_input.Name = "monthly_input";
            this.monthly_input.Size = new System.Drawing.Size(367, 50);
            this.monthly_input.TabIndex = 134;
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Active",
            "Closed",
            "Withdrawn"});
            this.status_combo.Location = new System.Drawing.Point(837, 1223);
            this.status_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(359, 44);
            this.status_combo.TabIndex = 133;
            this.status_combo.SelectedIndexChanged += new System.EventHandler(this.status_combo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(833, 1182);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 42);
            this.label11.TabIndex = 132;
            this.label11.Text = "Status";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 1182);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 42);
            this.label10.TabIndex = 131;
            this.label10.Text = "Payment Type";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(17, 1509);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1049, 1);
            this.panel4.TabIndex = 130;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // post_button
            // 
            this.post_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_button.Location = new System.Drawing.Point(1051, 1304);
            this.post_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.post_button.Name = "post_button";
            this.post_button.Size = new System.Drawing.Size(145, 44);
            this.post_button.TabIndex = 129;
            this.post_button.Text = "Post";
            this.post_button.UseVisualStyleBackColor = true;
            this.post_button.Click += new System.EventHandler(this.post_button_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(898, 1305);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(139, 44);
            this.cancel_button.TabIndex = 128;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 939);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 42);
            this.label8.TabIndex = 124;
            this.label8.Text = "Responsibilities";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 695);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 42);
            this.label7.TabIndex = 123;
            this.label7.Text = "About the Job";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 42);
            this.label6.TabIndex = 122;
            this.label6.Text = "Preferred Qualifications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 42);
            this.label5.TabIndex = 120;
            this.label5.Text = "Minimum Qualifications";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 70);
            this.label9.TabIndex = 119;
            this.label9.Text = "Post a Job";
            // 
            // fully_office_radiobtn
            // 
            this.fully_office_radiobtn.AutoSize = true;
            this.fully_office_radiobtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fully_office_radiobtn.Location = new System.Drawing.Point(719, 165);
            this.fully_office_radiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fully_office_radiobtn.Name = "fully_office_radiobtn";
            this.fully_office_radiobtn.Size = new System.Drawing.Size(173, 40);
            this.fully_office_radiobtn.TabIndex = 118;
            this.fully_office_radiobtn.TabStop = true;
            this.fully_office_radiobtn.Text = "Fully In-Office";
            this.fully_office_radiobtn.UseVisualStyleBackColor = true;
            // 
            // hybrid_radiobtn
            // 
            this.hybrid_radiobtn.AutoSize = true;
            this.hybrid_radiobtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hybrid_radiobtn.Location = new System.Drawing.Point(961, 165);
            this.hybrid_radiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hybrid_radiobtn.Name = "hybrid_radiobtn";
            this.hybrid_radiobtn.Size = new System.Drawing.Size(101, 40);
            this.hybrid_radiobtn.TabIndex = 117;
            this.hybrid_radiobtn.TabStop = true;
            this.hybrid_radiobtn.Text = "Hybrid";
            this.hybrid_radiobtn.UseVisualStyleBackColor = true;
            // 
            // fully_remote_radiobtn
            // 
            this.fully_remote_radiobtn.AutoSize = true;
            this.fully_remote_radiobtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fully_remote_radiobtn.Location = new System.Drawing.Point(481, 165);
            this.fully_remote_radiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fully_remote_radiobtn.Name = "fully_remote_radiobtn";
            this.fully_remote_radiobtn.Size = new System.Drawing.Size(162, 40);
            this.fully_remote_radiobtn.TabIndex = 116;
            this.fully_remote_radiobtn.TabStop = true;
            this.fully_remote_radiobtn.Text = "Fully Remote";
            this.fully_remote_radiobtn.UseVisualStyleBackColor = true;
            // 
            // full_time_checkbox
            // 
            this.full_time_checkbox.AutoSize = true;
            this.full_time_checkbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_time_checkbox.Location = new System.Drawing.Point(279, 165);
            this.full_time_checkbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.full_time_checkbox.Name = "full_time_checkbox";
            this.full_time_checkbox.Size = new System.Drawing.Size(130, 40);
            this.full_time_checkbox.TabIndex = 115;
            this.full_time_checkbox.Text = "Full-Time";
            this.full_time_checkbox.UseVisualStyleBackColor = true;
            // 
            // part_time_checkbox
            // 
            this.part_time_checkbox.AutoSize = true;
            this.part_time_checkbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_time_checkbox.Location = new System.Drawing.Point(44, 165);
            this.part_time_checkbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.part_time_checkbox.Name = "part_time_checkbox";
            this.part_time_checkbox.Size = new System.Drawing.Size(137, 40);
            this.part_time_checkbox.TabIndex = 114;
            this.part_time_checkbox.Text = "Part-Time";
            this.part_time_checkbox.UseVisualStyleBackColor = true;
            // 
            // title_input
            // 
            this.title_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_input.Location = new System.Drawing.Point(41, 66);
            this.title_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.title_input.Multiline = true;
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(1155, 50);
            this.title_input.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 42);
            this.label4.TabIndex = 111;
            this.label4.Text = "Type of Work Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 42);
            this.label3.TabIndex = 110;
            this.label3.Text = "Employment Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 42);
            this.label1.TabIndex = 108;
            this.label1.Text = "Job Position / Title";
            // 
            // job_panel
            // 
            this.job_panel.BackColor = System.Drawing.Color.White;
            this.job_panel.Controls.Add(this.responsibilities_richbox);
            this.job_panel.Controls.Add(this.about_job_richbox);
            this.job_panel.Controls.Add(this.min_qualification_richbox);
            this.job_panel.Controls.Add(this.title_input);
            this.job_panel.Controls.Add(this.paymenttype_label);
            this.job_panel.Controls.Add(this.label1);
            this.job_panel.Controls.Add(this.payment_combo);
            this.job_panel.Controls.Add(this.label3);
            this.job_panel.Controls.Add(this.monthly_input);
            this.job_panel.Controls.Add(this.label4);
            this.job_panel.Controls.Add(this.status_combo);
            this.job_panel.Controls.Add(this.part_time_checkbox);
            this.job_panel.Controls.Add(this.label11);
            this.job_panel.Controls.Add(this.full_time_checkbox);
            this.job_panel.Controls.Add(this.label10);
            this.job_panel.Controls.Add(this.fully_remote_radiobtn);
            this.job_panel.Controls.Add(this.hybrid_radiobtn);
            this.job_panel.Controls.Add(this.post_button);
            this.job_panel.Controls.Add(this.fully_office_radiobtn);
            this.job_panel.Controls.Add(this.cancel_button);
            this.job_panel.Controls.Add(this.label5);
            this.job_panel.Controls.Add(this.label6);
            this.job_panel.Controls.Add(this.label7);
            this.job_panel.Controls.Add(this.label8);
            this.job_panel.Controls.Add(this.preferred_qualification_richbox);
            this.job_panel.Controls.Add(this.hourly_input);
            this.job_panel.Location = new System.Drawing.Point(59, 77);
            this.job_panel.Name = "job_panel";
            this.job_panel.Size = new System.Drawing.Size(1244, 1379);
            this.job_panel.TabIndex = 138;
            // 
            // min_qualification_richbox
            // 
            this.min_qualification_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_qualification_richbox.Location = new System.Drawing.Point(44, 253);
            this.min_qualification_richbox.Margin = new System.Windows.Forms.Padding(4);
            this.min_qualification_richbox.Multiline = true;
            this.min_qualification_richbox.Name = "min_qualification_richbox";
            this.min_qualification_richbox.Size = new System.Drawing.Size(1155, 191);
            this.min_qualification_richbox.TabIndex = 138;
            // 
            // preferred_qualification_richbox
            // 
            this.preferred_qualification_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferred_qualification_richbox.Location = new System.Drawing.Point(47, 494);
            this.preferred_qualification_richbox.Margin = new System.Windows.Forms.Padding(4);
            this.preferred_qualification_richbox.Multiline = true;
            this.preferred_qualification_richbox.Name = "preferred_qualification_richbox";
            this.preferred_qualification_richbox.Size = new System.Drawing.Size(1155, 191);
            this.preferred_qualification_richbox.TabIndex = 139;
            // 
            // about_job_richbox
            // 
            this.about_job_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_job_richbox.Location = new System.Drawing.Point(47, 736);
            this.about_job_richbox.Margin = new System.Windows.Forms.Padding(4);
            this.about_job_richbox.Multiline = true;
            this.about_job_richbox.Name = "about_job_richbox";
            this.about_job_richbox.Size = new System.Drawing.Size(1155, 191);
            this.about_job_richbox.TabIndex = 140;
            // 
            // responsibilities_richbox
            // 
            this.responsibilities_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsibilities_richbox.Location = new System.Drawing.Point(44, 978);
            this.responsibilities_richbox.Margin = new System.Windows.Forms.Padding(4);
            this.responsibilities_richbox.Multiline = true;
            this.responsibilities_richbox.Name = "responsibilities_richbox";
            this.responsibilities_richbox.Size = new System.Drawing.Size(1155, 191);
            this.responsibilities_richbox.TabIndex = 141;
            // 
            // JP_PostJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JP_PostJobForm";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.job_panel.ResumeLayout(false);
            this.job_panel.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton fully_office_radiobtn;
        private System.Windows.Forms.RadioButton hybrid_radiobtn;
        private System.Windows.Forms.RadioButton fully_remote_radiobtn;
        private System.Windows.Forms.CheckBox full_time_checkbox;
        private System.Windows.Forms.CheckBox part_time_checkbox;
        private System.Windows.Forms.TextBox title_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel job_panel;
        private System.Windows.Forms.TextBox min_qualification_richbox;
        private System.Windows.Forms.TextBox responsibilities_richbox;
        private System.Windows.Forms.TextBox about_job_richbox;
        private System.Windows.Forms.TextBox preferred_qualification_richbox;
    }
}
