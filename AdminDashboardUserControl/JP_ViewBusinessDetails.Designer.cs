namespace JobNear.AdminDashboardUserControl
{
    partial class JP_ViewBusinessDetails
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.lng_input = new System.Windows.Forms.TextBox();
            this.lat_input = new System.Windows.Forms.TextBox();
            this.address_input = new System.Windows.Forms.TextBox();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.website_input = new System.Windows.Forms.TextBox();
            this.industry_input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.description_richbox = new System.Windows.Forms.TextBox();
            this.remarks_richtext = new System.Windows.Forms.TextBox();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.business_panel = new System.Windows.Forms.Panel();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.business_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.cancel_button);
            this.sidebar_panel.Controls.Add(this.submit_button);
            this.sidebar_panel.Controls.Add(this.profile_picture);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Controls.Add(this.name_label);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 74;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(236, 813);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(135, 44);
            this.cancel_button.TabIndex = 101;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(93, 813);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(135, 44);
            this.submit_button.TabIndex = 100;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(84, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(79, 50);
            this.name_label.TabIndex = 96;
            this.name_label.Text = "TEst";
            // 
            // lng_input
            // 
            this.lng_input.Enabled = false;
            this.lng_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lng_input.Location = new System.Drawing.Point(694, 319);
            this.lng_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lng_input.Multiline = true;
            this.lng_input.Name = "lng_input";
            this.lng_input.Size = new System.Drawing.Size(199, 50);
            this.lng_input.TabIndex = 94;
            // 
            // lat_input
            // 
            this.lat_input.Enabled = false;
            this.lat_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat_input.Location = new System.Drawing.Point(474, 319);
            this.lat_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lat_input.Multiline = true;
            this.lat_input.Name = "lat_input";
            this.lat_input.Size = new System.Drawing.Size(201, 50);
            this.lat_input.TabIndex = 93;
            // 
            // address_input
            // 
            this.address_input.Enabled = false;
            this.address_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(474, 235);
            this.address_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_input.Multiline = true;
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(423, 50);
            this.address_input.TabIndex = 92;
            // 
            // phone_input
            // 
            this.phone_input.Enabled = false;
            this.phone_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.Location = new System.Drawing.Point(474, 144);
            this.phone_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_input.Multiline = true;
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(423, 50);
            this.phone_input.TabIndex = 91;
            // 
            // email_input
            // 
            this.email_input.Enabled = false;
            this.email_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(474, 53);
            this.email_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_input.Multiline = true;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(423, 50);
            this.email_input.TabIndex = 90;
            // 
            // website_input
            // 
            this.website_input.Enabled = false;
            this.website_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website_input.Location = new System.Drawing.Point(30, 145);
            this.website_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.website_input.Multiline = true;
            this.website_input.Name = "website_input";
            this.website_input.Size = new System.Drawing.Size(421, 50);
            this.website_input.TabIndex = 87;
            // 
            // industry_input
            // 
            this.industry_input.Enabled = false;
            this.industry_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.industry_input.Location = new System.Drawing.Point(30, 53);
            this.industry_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.industry_input.Multiline = true;
            this.industry_input.Name = "industry_input";
            this.industry_input.Size = new System.Drawing.Size(421, 50);
            this.industry_input.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(468, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 36);
            this.label10.TabIndex = 83;
            this.label10.Text = "Full Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 36);
            this.label9.TabIndex = 82;
            this.label9.Text = "Email Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(692, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 36);
            this.label8.TabIndex = 81;
            this.label8.Text = "Longitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 36);
            this.label6.TabIndex = 79;
            this.label6.Text = "Latitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 36);
            this.label5.TabIndex = 78;
            this.label5.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 36);
            this.label3.TabIndex = 76;
            this.label3.Text = "Business Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 36);
            this.label2.TabIndex = 75;
            this.label2.Text = "Business Website URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 74;
            this.label1.Text = "Business Industry:";
            // 
            // profile_picture
            // 
            this.profile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_picture.Image = global::JobNear.Properties.Resources.default_profile;
            this.profile_picture.Location = new System.Drawing.Point(1063, 57);
            this.profile_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(266, 246);
            this.profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_picture.TabIndex = 73;
            this.profile_picture.TabStop = false;
            // 
            // description_richbox
            // 
            this.description_richbox.Enabled = false;
            this.description_richbox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_richbox.Location = new System.Drawing.Point(32, 235);
            this.description_richbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description_richbox.Multiline = true;
            this.description_richbox.Name = "description_richbox";
            this.description_richbox.Size = new System.Drawing.Size(421, 134);
            this.description_richbox.TabIndex = 103;
            // 
            // remarks_richtext
            // 
            this.remarks_richtext.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarks_richtext.Location = new System.Drawing.Point(263, 594);
            this.remarks_richtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remarks_richtext.Multiline = true;
            this.remarks_richtext.Name = "remarks_richtext";
            this.remarks_richtext.Size = new System.Drawing.Size(630, 113);
            this.remarks_richtext.TabIndex = 109;
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Pending",
            "Verified",
            "Incomplete",
            "Rejected"});
            this.status_combo.Location = new System.Drawing.Point(30, 594);
            this.status_combo.Margin = new System.Windows.Forms.Padding(4);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(206, 38);
            this.status_combo.TabIndex = 108;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 36);
            this.label12.TabIndex = 107;
            this.label12.Text = "Supporting Documents:";
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.Enabled = false;
            this.image_flowlayout.Location = new System.Drawing.Point(30, 415);
            this.image_flowlayout.Margin = new System.Windows.Forms.Padding(4);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(863, 143);
            this.image_flowlayout.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(257, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 36);
            this.label11.TabIndex = 105;
            this.label11.Text = "Remarks:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 36);
            this.label7.TabIndex = 104;
            this.label7.Text = "Set Status:";
            // 
            // business_panel
            // 
            this.business_panel.Controls.Add(this.remarks_richtext);
            this.business_panel.Controls.Add(this.status_combo);
            this.business_panel.Controls.Add(this.label12);
            this.business_panel.Controls.Add(this.image_flowlayout);
            this.business_panel.Controls.Add(this.label11);
            this.business_panel.Controls.Add(this.label7);
            this.business_panel.Controls.Add(this.description_richbox);
            this.business_panel.Controls.Add(this.lng_input);
            this.business_panel.Controls.Add(this.lat_input);
            this.business_panel.Controls.Add(this.address_input);
            this.business_panel.Controls.Add(this.phone_input);
            this.business_panel.Controls.Add(this.email_input);
            this.business_panel.Controls.Add(this.website_input);
            this.business_panel.Controls.Add(this.industry_input);
            this.business_panel.Controls.Add(this.label10);
            this.business_panel.Controls.Add(this.label9);
            this.business_panel.Controls.Add(this.label5);
            this.business_panel.Controls.Add(this.label3);
            this.business_panel.Controls.Add(this.label2);
            this.business_panel.Controls.Add(this.label1);
            this.business_panel.Controls.Add(this.label8);
            this.business_panel.Controls.Add(this.label6);
            this.business_panel.Location = new System.Drawing.Point(93, 57);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(923, 743);
            this.business_panel.TabIndex = 110;
            // 
            // JP_ViewBusinessDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JP_ViewBusinessDetails";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.business_panel.ResumeLayout(false);
            this.business_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remarks_richtext;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.PictureBox profile_picture;
        private System.Windows.Forms.TextBox description_richbox;
        private System.Windows.Forms.TextBox lng_input;
        private System.Windows.Forms.TextBox lat_input;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox website_input;
        private System.Windows.Forms.TextBox industry_input;
    }
}
