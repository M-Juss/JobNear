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
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.name_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lng_input = new System.Windows.Forms.TextBox();
            this.lat_input = new System.Windows.Forms.TextBox();
            this.address_input = new System.Windows.Forms.TextBox();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.website_input = new System.Windows.Forms.TextBox();
            this.industry_input = new System.Windows.Forms.TextBox();
            this.remarks_richtext = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.description_richbox = new System.Windows.Forms.RichTextBox();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.description_richbox);
            this.sidebar_panel.Controls.Add(this.cancel_button);
            this.sidebar_panel.Controls.Add(this.submit_button);
            this.sidebar_panel.Controls.Add(this.status_combo);
            this.sidebar_panel.Controls.Add(this.label12);
            this.sidebar_panel.Controls.Add(this.image_flowlayout);
            this.sidebar_panel.Controls.Add(this.name_label);
            this.sidebar_panel.Controls.Add(this.panel1);
            this.sidebar_panel.Controls.Add(this.lng_input);
            this.sidebar_panel.Controls.Add(this.lat_input);
            this.sidebar_panel.Controls.Add(this.address_input);
            this.sidebar_panel.Controls.Add(this.phone_input);
            this.sidebar_panel.Controls.Add(this.email_input);
            this.sidebar_panel.Controls.Add(this.website_input);
            this.sidebar_panel.Controls.Add(this.industry_input);
            this.sidebar_panel.Controls.Add(this.remarks_richtext);
            this.sidebar_panel.Controls.Add(this.label11);
            this.sidebar_panel.Controls.Add(this.label10);
            this.sidebar_panel.Controls.Add(this.label9);
            this.sidebar_panel.Controls.Add(this.label8);
            this.sidebar_panel.Controls.Add(this.label7);
            this.sidebar_panel.Controls.Add(this.label6);
            this.sidebar_panel.Controls.Add(this.label5);
            this.sidebar_panel.Controls.Add(this.label3);
            this.sidebar_panel.Controls.Add(this.label2);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.profile_picture);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 74;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(680, 645);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(127, 36);
            this.cancel_button.TabIndex = 101;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(825, 645);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(127, 36);
            this.submit_button.TabIndex = 100;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Pending",
            "Verified",
            "Incomplete",
            "Rejected"});
            this.status_combo.Location = new System.Drawing.Point(83, 543);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(299, 30);
            this.status_combo.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(77, 342);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 28);
            this.label12.TabIndex = 98;
            this.label12.Text = "Business Credentials / Certificates";
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.Location = new System.Drawing.Point(83, 373);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(869, 116);
            this.image_flowlayout.TabIndex = 97;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(75, 16);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 39);
            this.name_label.TabIndex = 96;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(83, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 1);
            this.panel1.TabIndex = 95;
            // 
            // lng_input
            // 
            this.lng_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lng_input.Location = new System.Drawing.Point(583, 297);
            this.lng_input.Margin = new System.Windows.Forms.Padding(2);
            this.lng_input.Name = "lng_input";
            this.lng_input.Size = new System.Drawing.Size(132, 28);
            this.lng_input.TabIndex = 94;
            // 
            // lat_input
            // 
            this.lat_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat_input.Location = new System.Drawing.Point(415, 297);
            this.lat_input.Margin = new System.Windows.Forms.Padding(2);
            this.lat_input.Name = "lat_input";
            this.lat_input.Size = new System.Drawing.Size(141, 28);
            this.lat_input.TabIndex = 93;
            // 
            // address_input
            // 
            this.address_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(415, 227);
            this.address_input.Margin = new System.Windows.Forms.Padding(2);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(300, 28);
            this.address_input.TabIndex = 92;
            // 
            // phone_input
            // 
            this.phone_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.Location = new System.Drawing.Point(415, 159);
            this.phone_input.Margin = new System.Windows.Forms.Padding(2);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(300, 28);
            this.phone_input.TabIndex = 91;
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(415, 98);
            this.email_input.Margin = new System.Windows.Forms.Padding(2);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(300, 28);
            this.email_input.TabIndex = 90;
            // 
            // website_input
            // 
            this.website_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website_input.Location = new System.Drawing.Point(82, 159);
            this.website_input.Margin = new System.Windows.Forms.Padding(2);
            this.website_input.Name = "website_input";
            this.website_input.Size = new System.Drawing.Size(299, 28);
            this.website_input.TabIndex = 87;
            // 
            // industry_input
            // 
            this.industry_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.industry_input.Location = new System.Drawing.Point(82, 98);
            this.industry_input.Margin = new System.Windows.Forms.Padding(2);
            this.industry_input.Name = "industry_input";
            this.industry_input.Size = new System.Drawing.Size(299, 28);
            this.industry_input.TabIndex = 86;
            // 
            // remarks_richtext
            // 
            this.remarks_richtext.Location = new System.Drawing.Point(415, 542);
            this.remarks_richtext.Margin = new System.Windows.Forms.Padding(2);
            this.remarks_richtext.Name = "remarks_richtext";
            this.remarks_richtext.Size = new System.Drawing.Size(537, 91);
            this.remarks_richtext.TabIndex = 85;
            this.remarks_richtext.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 512);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 28);
            this.label11.TabIndex = 84;
            this.label11.Text = "Remarks:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 83;
            this.label10.Text = "Full Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 82;
            this.label9.Text = "Email Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 28);
            this.label8.TabIndex = 81;
            this.label8.Text = "Longitude:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 512);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 28);
            this.label7.TabIndex = 80;
            this.label7.Text = "Set Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 79;
            this.label6.Text = "Latitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 78;
            this.label5.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 28);
            this.label3.TabIndex = 76;
            this.label3.Text = "Business Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 28);
            this.label2.TabIndex = 75;
            this.label2.Text = "Business Website URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 74;
            this.label1.Text = "Business Industry:";
            // 
            // profile_picture
            // 
            this.profile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_picture.Image = global::JobNear.Properties.Resources.default_profile;
            this.profile_picture.Location = new System.Drawing.Point(752, 67);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(200, 200);
            this.profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_picture.TabIndex = 73;
            this.profile_picture.TabStop = false;
            // 
            // description_richbox
            // 
            this.description_richbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_richbox.Location = new System.Drawing.Point(78, 229);
            this.description_richbox.Name = "description_richbox";
            this.description_richbox.Size = new System.Drawing.Size(304, 96);
            this.description_richbox.TabIndex = 102;
            this.description_richbox.Text = "";
            // 
            // JP_ViewBusinessDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_ViewBusinessDetails";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lng_input;
        private System.Windows.Forms.TextBox lat_input;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox website_input;
        private System.Windows.Forms.TextBox industry_input;
        private System.Windows.Forms.RichTextBox remarks_richtext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profile_picture;
        private System.Windows.Forms.RichTextBox description_richbox;
    }
}
