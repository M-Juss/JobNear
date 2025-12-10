namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_ViewReportDetails
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
            this.details_panel = new System.Windows.Forms.Panel();
            this.description_lbl = new System.Windows.Forms.TextBox();
            this.subject_lbl = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.stat_lbl = new System.Windows.Forms.Label();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.complainee_panel = new System.Windows.Forms.Panel();
            this.complainee_phone = new System.Windows.Forms.Label();
            this.complainee_email = new System.Windows.Forms.Label();
            this.complainee_name = new System.Windows.Forms.Label();
            this.complainee_picture = new System.Windows.Forms.PictureBox();
            this.complainant_panel = new System.Windows.Forms.Panel();
            this.complainant_phone = new System.Windows.Forms.Label();
            this.complainant_email = new System.Windows.Forms.Label();
            this.complainant_name = new System.Windows.Forms.Label();
            this.complainant_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.complainant_lbl = new System.Windows.Forms.Label();
            this.complainee_lbl = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.details_panel.SuspendLayout();
            this.complainee_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complainee_picture)).BeginInit();
            this.complainant_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complainant_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.details_panel);
            this.sidebar_panel.Controls.Add(this.complainee_panel);
            this.sidebar_panel.Controls.Add(this.complainant_panel);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.complainant_lbl);
            this.sidebar_panel.Controls.Add(this.complainee_lbl);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            // 
            // details_panel
            // 
            this.details_panel.BackColor = System.Drawing.Color.White;
            this.details_panel.Controls.Add(this.description_lbl);
            this.details_panel.Controls.Add(this.subject_lbl);
            this.details_panel.Controls.Add(this.cancel_button);
            this.details_panel.Controls.Add(this.submit_button);
            this.details_panel.Controls.Add(this.stat_lbl);
            this.details_panel.Controls.Add(this.status_combo);
            this.details_panel.Controls.Add(this.label3);
            this.details_panel.Controls.Add(this.image_flowlayout);
            this.details_panel.Controls.Add(this.label2);
            this.details_panel.Controls.Add(this.label9);
            this.details_panel.Controls.Add(this.back_button);
            this.details_panel.Location = new System.Drawing.Point(47, 290);
            this.details_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.details_panel.Name = "details_panel";
            this.details_panel.Size = new System.Drawing.Size(1280, 550);
            this.details_panel.TabIndex = 109;
            // 
            // description_lbl
            // 
            this.description_lbl.Enabled = false;
            this.description_lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.Location = new System.Drawing.Point(159, 82);
            this.description_lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description_lbl.Multiline = true;
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_lbl.Size = new System.Drawing.Size(1103, 127);
            this.description_lbl.TabIndex = 120;
            // 
            // subject_lbl
            // 
            this.subject_lbl.Enabled = false;
            this.subject_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_lbl.Location = new System.Drawing.Point(159, 16);
            this.subject_lbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subject_lbl.Multiline = true;
            this.subject_lbl.Name = "subject_lbl";
            this.subject_lbl.Size = new System.Drawing.Size(1103, 50);
            this.subject_lbl.TabIndex = 119;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(984, 491);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(131, 44);
            this.cancel_button.TabIndex = 116;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(1127, 491);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(135, 44);
            this.submit_button.TabIndex = 115;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // stat_lbl
            // 
            this.stat_lbl.AutoSize = true;
            this.stat_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat_lbl.Location = new System.Drawing.Point(9, 421);
            this.stat_lbl.Name = "stat_lbl";
            this.stat_lbl.Size = new System.Drawing.Size(86, 36);
            this.stat_lbl.TabIndex = 112;
            this.stat_lbl.Text = "Status:";
            // 
            // status_combo
            // 
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Valid",
            "Invalid"});
            this.status_combo.Location = new System.Drawing.Point(101, 421);
            this.status_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(397, 42);
            this.status_combo.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 36);
            this.label3.TabIndex = 110;
            this.label3.Text = "Supporting Documents:";
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.Location = new System.Drawing.Point(16, 260);
            this.image_flowlayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(1247, 143);
            this.image_flowlayout.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 108;
            this.label2.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 36);
            this.label9.TabIndex = 107;
            this.label9.Text = "Subject:";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(1127, 491);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(135, 44);
            this.back_button.TabIndex = 118;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // complainee_panel
            // 
            this.complainee_panel.BackColor = System.Drawing.Color.White;
            this.complainee_panel.Controls.Add(this.complainee_phone);
            this.complainee_panel.Controls.Add(this.complainee_email);
            this.complainee_panel.Controls.Add(this.complainee_name);
            this.complainee_panel.Controls.Add(this.complainee_picture);
            this.complainee_panel.Location = new System.Drawing.Point(715, 100);
            this.complainee_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.complainee_panel.Name = "complainee_panel";
            this.complainee_panel.Size = new System.Drawing.Size(612, 172);
            this.complainee_panel.TabIndex = 5;
            // 
            // complainee_phone
            // 
            this.complainee_phone.AutoEllipsis = true;
            this.complainee_phone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainee_phone.Location = new System.Drawing.Point(213, 122);
            this.complainee_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainee_phone.Name = "complainee_phone";
            this.complainee_phone.Size = new System.Drawing.Size(380, 38);
            this.complainee_phone.TabIndex = 81;
            // 
            // complainee_email
            // 
            this.complainee_email.AutoEllipsis = true;
            this.complainee_email.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainee_email.Location = new System.Drawing.Point(215, 66);
            this.complainee_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainee_email.Name = "complainee_email";
            this.complainee_email.Size = new System.Drawing.Size(380, 38);
            this.complainee_email.TabIndex = 80;
            // 
            // complainee_name
            // 
            this.complainee_name.AutoEllipsis = true;
            this.complainee_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainee_name.Location = new System.Drawing.Point(215, 12);
            this.complainee_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainee_name.Name = "complainee_name";
            this.complainee_name.Size = new System.Drawing.Size(380, 38);
            this.complainee_name.TabIndex = 79;
            // 
            // complainee_picture
            // 
            this.complainee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.complainee_picture.Image = global::JobNear.Properties.Resources.default_profile;
            this.complainee_picture.Location = new System.Drawing.Point(17, 12);
            this.complainee_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.complainee_picture.Name = "complainee_picture";
            this.complainee_picture.Size = new System.Drawing.Size(187, 147);
            this.complainee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.complainee_picture.TabIndex = 75;
            this.complainee_picture.TabStop = false;
            // 
            // complainant_panel
            // 
            this.complainant_panel.BackColor = System.Drawing.Color.White;
            this.complainant_panel.Controls.Add(this.complainant_phone);
            this.complainant_panel.Controls.Add(this.complainant_email);
            this.complainant_panel.Controls.Add(this.complainant_name);
            this.complainant_panel.Controls.Add(this.complainant_picture);
            this.complainant_panel.Location = new System.Drawing.Point(45, 100);
            this.complainant_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.complainant_panel.Name = "complainant_panel";
            this.complainant_panel.Size = new System.Drawing.Size(612, 172);
            this.complainant_panel.TabIndex = 4;
            // 
            // complainant_phone
            // 
            this.complainant_phone.AutoEllipsis = true;
            this.complainant_phone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainant_phone.Location = new System.Drawing.Point(213, 122);
            this.complainant_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainant_phone.Name = "complainant_phone";
            this.complainant_phone.Size = new System.Drawing.Size(380, 38);
            this.complainant_phone.TabIndex = 78;
            // 
            // complainant_email
            // 
            this.complainant_email.AutoEllipsis = true;
            this.complainant_email.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainant_email.Location = new System.Drawing.Point(213, 66);
            this.complainant_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainant_email.Name = "complainant_email";
            this.complainant_email.Size = new System.Drawing.Size(380, 38);
            this.complainant_email.TabIndex = 77;
            // 
            // complainant_name
            // 
            this.complainant_name.AutoEllipsis = true;
            this.complainant_name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainant_name.Location = new System.Drawing.Point(213, 12);
            this.complainant_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainant_name.Name = "complainant_name";
            this.complainant_name.Size = new System.Drawing.Size(380, 38);
            this.complainant_name.TabIndex = 76;
            // 
            // complainant_picture
            // 
            this.complainant_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.complainant_picture.Image = global::JobNear.Properties.Resources.default_profile;
            this.complainant_picture.Location = new System.Drawing.Point(17, 12);
            this.complainant_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.complainant_picture.Name = "complainant_picture";
            this.complainant_picture.Size = new System.Drawing.Size(187, 147);
            this.complainant_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.complainant_picture.TabIndex = 74;
            this.complainant_picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, -4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Report Details";
            // 
            // complainant_lbl
            // 
            this.complainant_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainant_lbl.Location = new System.Drawing.Point(49, 60);
            this.complainant_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainant_lbl.Name = "complainant_lbl";
            this.complainant_lbl.Size = new System.Drawing.Size(201, 34);
            this.complainant_lbl.TabIndex = 0;
            this.complainant_lbl.Text = "Complainant";
            this.complainant_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // complainee_lbl
            // 
            this.complainee_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainee_lbl.Location = new System.Drawing.Point(719, 60);
            this.complainee_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complainee_lbl.Name = "complainee_lbl";
            this.complainee_lbl.Size = new System.Drawing.Size(201, 34);
            this.complainee_lbl.TabIndex = 110;
            this.complainee_lbl.Text = "Complainee";
            this.complainee_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin_ViewReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_ViewReportDetails";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.details_panel.ResumeLayout(false);
            this.details_panel.PerformLayout();
            this.complainee_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.complainee_picture)).EndInit();
            this.complainant_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.complainant_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel complainant_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel complainee_panel;
        private System.Windows.Forms.Label complainant_lbl;
        private System.Windows.Forms.Panel details_panel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label stat_lbl;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label complainee_lbl;
        private System.Windows.Forms.PictureBox complainant_picture;
        private System.Windows.Forms.PictureBox complainee_picture;
        private System.Windows.Forms.Label complainant_name;
        private System.Windows.Forms.Label complainee_phone;
        private System.Windows.Forms.Label complainee_email;
        private System.Windows.Forms.Label complainee_name;
        private System.Windows.Forms.Label complainant_phone;
        private System.Windows.Forms.Label complainant_email;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox description_lbl;
        private System.Windows.Forms.TextBox subject_lbl;
    }
}
