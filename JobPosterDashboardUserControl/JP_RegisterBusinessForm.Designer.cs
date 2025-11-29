namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_RegisterBusinessForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.supporting_panel = new System.Windows.Forms.Panel();
            this.attach_file = new System.Windows.Forms.Button();
            this.address_panel = new System.Windows.Forms.Panel();
            this.website_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address_input = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upload_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.header_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.industry_input = new System.Windows.Forms.ComboBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.review_button = new System.Windows.Forms.Button();
            this.business_panel = new System.Windows.Forms.Panel();
            this.description_richbox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.supporting_panel.SuspendLayout();
            this.address_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.business_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.AutoScroll = true;
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.industry_input);
            this.sidebar_panel.Controls.Add(this.name_input);
            this.sidebar_panel.Controls.Add(this.panel1);
            this.sidebar_panel.Controls.Add(this.supporting_panel);
            this.sidebar_panel.Controls.Add(this.address_panel);
            this.sidebar_panel.Controls.Add(this.image_flowlayout);
            this.sidebar_panel.Controls.Add(this.label12);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.upload_button);
            this.sidebar_panel.Controls.Add(this.cancel_button);
            this.sidebar_panel.Controls.Add(this.profile_picture);
            this.sidebar_panel.Controls.Add(this.header_label);
            this.sidebar_panel.Controls.Add(this.label16);
            this.sidebar_panel.Controls.Add(this.label8);
            this.sidebar_panel.Controls.Add(this.review_button);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Controls.Add(this.update_button);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(476, 1149);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 89;
            // 
            // supporting_panel
            // 
            this.supporting_panel.Controls.Add(this.attach_file);
            this.supporting_panel.Location = new System.Drawing.Point(16, 776);
            this.supporting_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supporting_panel.Name = "supporting_panel";
            this.supporting_panel.Size = new System.Drawing.Size(773, 163);
            this.supporting_panel.TabIndex = 54;
            // 
            // attach_file
            // 
            this.attach_file.BackColor = System.Drawing.Color.White;
            this.attach_file.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_file.ForeColor = System.Drawing.Color.DimGray;
            this.attach_file.Location = new System.Drawing.Point(13, 14);
            this.attach_file.Name = "attach_file";
            this.attach_file.Size = new System.Drawing.Size(748, 138);
            this.attach_file.TabIndex = 48;
            this.attach_file.Text = "Attach the following files to verify your business. These are mandatory:\r\n> SEC\r\n" +
    "> DTI\r\n> Barangay Permit";
            this.attach_file.UseVisualStyleBackColor = false;
            this.attach_file.Click += new System.EventHandler(this.attach_file_Click);
            // 
            // address_panel
            // 
            this.address_panel.Controls.Add(this.website_input);
            this.address_panel.Controls.Add(this.label5);
            this.address_panel.Controls.Add(this.address_input);
            this.address_panel.Controls.Add(this.label13);
            this.address_panel.Controls.Add(this.email_input);
            this.address_panel.Controls.Add(this.label11);
            this.address_panel.Controls.Add(this.phone_input);
            this.address_panel.Controls.Add(this.label10);
            this.address_panel.Location = new System.Drawing.Point(16, 486);
            this.address_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.address_panel.Name = "address_panel";
            this.address_panel.Size = new System.Drawing.Size(773, 243);
            this.address_panel.TabIndex = 88;
            // 
            // website_input
            // 
            this.website_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website_input.Location = new System.Drawing.Point(10, 188);
            this.website_input.Multiline = true;
            this.website_input.Name = "website_input";
            this.website_input.Size = new System.Drawing.Size(751, 32);
            this.website_input.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 28);
            this.label5.TabIndex = 48;
            this.label5.Text = "Business Website:";
            // 
            // address_input
            // 
            this.address_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(10, 38);
            this.address_input.Multiline = true;
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(751, 32);
            this.address_input.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(6, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 28);
            this.label13.TabIndex = 46;
            this.label13.Text = "Business Full Address:";
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(10, 115);
            this.email_input.Multiline = true;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(370, 32);
            this.email_input.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(6, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 28);
            this.label11.TabIndex = 38;
            this.label11.Text = "Business Email Address:";
            // 
            // phone_input
            // 
            this.phone_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.Location = new System.Drawing.Point(396, 115);
            this.phone_input.Multiline = true;
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(365, 32);
            this.phone_input.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(392, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 28);
            this.label10.TabIndex = 40;
            this.label10.Text = "Business Phone Number:";
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.image_flowlayout.Location = new System.Drawing.Point(16, 945);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(773, 116);
            this.image_flowlayout.TabIndex = 55;
            this.image_flowlayout.WrapContents = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(10, 743);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(349, 34);
            this.label12.TabIndex = 53;
            this.label12.Text = "Business Credentials / Certificates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 34);
            this.label1.TabIndex = 86;
            this.label1.Text = "Business Information";
            // 
            // upload_button
            // 
            this.upload_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_button.Location = new System.Drawing.Point(802, 308);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(200, 32);
            this.upload_button.TabIndex = 84;
            this.upload_button.Text = "Upload picture here";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(692, 1092);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(125, 36);
            this.cancel_button.TabIndex = 82;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click_1);
            // 
            // profile_picture
            // 
            this.profile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_picture.Image = global::JobNear.Properties.Resources.default_profile;
            this.profile_picture.Location = new System.Drawing.Point(802, 95);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(201, 199);
            this.profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_picture.TabIndex = 79;
            this.profile_picture.TabStop = false;
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.ForeColor = System.Drawing.Color.DimGray;
            this.header_label.Location = new System.Drawing.Point(-3, 1);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(316, 56);
            this.header_label.TabIndex = 74;
            this.header_label.Text = "Register Business";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 748);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 34);
            this.label16.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(383, 34);
            this.label8.TabIndex = 64;
            this.label8.Text = "Business Address and Contact Details";
            // 
            // industry_input
            // 
            this.industry_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.industry_input.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.industry_input.FormattingEnabled = true;
            this.industry_input.Items.AddRange(new object[] {
            "Agriculture",
            "Forestry",
            "Fishing",
            "Mining",
            "Oil and Gas Extraction",
            "Quarrying",
            "Manufacturing",
            "Food and Beverage Production",
            "Textile and Apparel",
            "Automotive",
            "Chemical Industry",
            "Electronics and Electrical",
            "Metal and Machinery",
            "Construction",
            "Aerospace",
            "Shipbuilding",
            "Retail and Wholesale",
            "Transportation and Logistics",
            "Tourism and Hospitality",
            "Banking and Finance",
            "Insurance",
            "Real Estate",
            "Healthcare and Medical Services",
            "Education and Training",
            "Entertainment and Media",
            "Telecommunications",
            "Information Technology",
            "Consulting and Professional Services",
            "Legal Services",
            "Marketing and Advertising",
            "Public Administration and Government",
            "Research and Development",
            "Biotechnology",
            "Data Analytics",
            "Software Development",
            "Artificial Intelligence",
            "Education Technology",
            "Financial Technology",
            "Non-Governmental Organizations",
            "Non-Profit and Charitable Services",
            "Government Leadership and Policy Making",
            "Cultural and Arts Management",
            "Executive and Strategic Management"});
            this.industry_input.Location = new System.Drawing.Point(28, 206);
            this.industry_input.Name = "industry_input";
            this.industry_input.Size = new System.Drawing.Size(746, 30);
            this.industry_input.TabIndex = 61;
            // 
            // name_input
            // 
            this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(28, 134);
            this.name_input.Multiline = true;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(746, 32);
            this.name_input.TabIndex = 60;
            // 
            // review_button
            // 
            this.review_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_button.Location = new System.Drawing.Point(837, 1092);
            this.review_button.Name = "review_button";
            this.review_button.Size = new System.Drawing.Size(161, 36);
            this.review_button.TabIndex = 83;
            this.review_button.Text = "Submit for review";
            this.review_button.UseVisualStyleBackColor = true;
            this.review_button.Click += new System.EventHandler(this.review_button_Click_1);
            // 
            // business_panel
            // 
            this.business_panel.Controls.Add(this.label9);
            this.business_panel.Controls.Add(this.label7);
            this.business_panel.Controls.Add(this.label6);
            this.business_panel.Controls.Add(this.description_richbox);
            this.business_panel.Location = new System.Drawing.Point(16, 95);
            this.business_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(773, 336);
            this.business_panel.TabIndex = 87;
            // 
            // description_richbox
            // 
            this.description_richbox.Location = new System.Drawing.Point(13, 178);
            this.description_richbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description_richbox.Multiline = true;
            this.description_richbox.Name = "description_richbox";
            this.description_richbox.Size = new System.Drawing.Size(746, 142);
            this.description_richbox.TabIndex = 0;
            this.description_richbox.TextChanged += new System.EventHandler(this.description_richbox_TextChanged);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(837, 1092);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(161, 36);
            this.update_button.TabIndex = 85;
            this.update_button.Text = "Update Business";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Business Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(7, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "Business Industry";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(8, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 28);
            this.label9.TabIndex = 52;
            this.label9.Text = "Business Description";
            // 
            // JP_RegisterBusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_RegisterBusinessForm";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.supporting_panel.ResumeLayout(false);
            this.address_panel.ResumeLayout(false);
            this.address_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.business_panel.ResumeLayout(false);
            this.business_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button review_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.PictureBox profile_picture;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox industry_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description_richbox;
        private System.Windows.Forms.Panel address_panel;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox website_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel supporting_panel;
        private System.Windows.Forms.Button attach_file;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
