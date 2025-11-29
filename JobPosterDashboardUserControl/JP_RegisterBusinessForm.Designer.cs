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
            this.upload_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.header_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.industry_input = new System.Windows.Forms.ComboBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.review_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.business_panel = new System.Windows.Forms.Panel();
            this.description_richbox = new System.Windows.Forms.TextBox();
            this.address_panel = new System.Windows.Forms.Panel();
            this.address_input = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.website_input = new System.Windows.Forms.TextBox();
            this.supporting_panel = new System.Windows.Forms.Panel();
            this.attach_file = new System.Windows.Forms.Button();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.business_panel.SuspendLayout();
            this.address_panel.SuspendLayout();
            this.supporting_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.AutoScroll = true;
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.sidebar_panel.Controls.Add(this.label4);
            this.sidebar_panel.Controls.Add(this.industry_input);
            this.sidebar_panel.Controls.Add(this.name_input);
            this.sidebar_panel.Controls.Add(this.label3);
            this.sidebar_panel.Controls.Add(this.label2);
            this.sidebar_panel.Controls.Add(this.review_button);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Controls.Add(this.update_button);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // upload_button
            // 
            this.upload_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_button.Location = new System.Drawing.Point(1070, 379);
            this.upload_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(267, 39);
            this.upload_button.TabIndex = 84;
            this.upload_button.Text = "Upload picture here";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(923, 1344);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(167, 44);
            this.cancel_button.TabIndex = 82;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click_1);
            // 
            // profile_picture
            // 
            this.profile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_picture.Image = global::JobNear.Properties.Resources.default_profile;
            this.profile_picture.Location = new System.Drawing.Point(1070, 117);
            this.profile_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(267, 245);
            this.profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_picture.TabIndex = 79;
            this.profile_picture.TabStop = false;
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.Location = new System.Drawing.Point(-4, 1);
            this.header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(391, 70);
            this.header_label.TabIndex = 74;
            this.header_label.Text = "Register Business";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 921);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 42);
            this.label16.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 553);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 42);
            this.label8.TabIndex = 64;
            this.label8.Text = "Business Address and Contact Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 36);
            this.label4.TabIndex = 62;
            this.label4.Text = "Business Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.industry_input.Location = new System.Drawing.Point(38, 253);
            this.industry_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.industry_input.Name = "industry_input";
            this.industry_input.Size = new System.Drawing.Size(993, 34);
            this.industry_input.TabIndex = 61;
            // 
            // name_input
            // 
            this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(38, 165);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_input.Multiline = true;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(994, 50);
            this.name_input.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 36);
            this.label3.TabIndex = 59;
            this.label3.Text = "Business Industry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 58;
            this.label2.Text = "Business Name";
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(1116, 1344);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(215, 44);
            this.update_button.TabIndex = 85;
            this.update_button.Text = "Update Business";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // review_button
            // 
            this.review_button.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_button.Location = new System.Drawing.Point(1116, 1344);
            this.review_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.review_button.Name = "review_button";
            this.review_button.Size = new System.Drawing.Size(215, 44);
            this.review_button.TabIndex = 83;
            this.review_button.Text = "Submit for review";
            this.review_button.UseVisualStyleBackColor = true;
            this.review_button.Click += new System.EventHandler(this.review_button_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 42);
            this.label1.TabIndex = 86;
            this.label1.Text = "Business Information";
            // 
            // business_panel
            // 
            this.business_panel.Controls.Add(this.description_richbox);
            this.business_panel.Location = new System.Drawing.Point(21, 117);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(1031, 414);
            this.business_panel.TabIndex = 87;
            // 
            // description_richbox
            // 
            this.description_richbox.Location = new System.Drawing.Point(17, 219);
            this.description_richbox.Multiline = true;
            this.description_richbox.Name = "description_richbox";
            this.description_richbox.Size = new System.Drawing.Size(993, 174);
            this.description_richbox.TabIndex = 0;
            this.description_richbox.TextChanged += new System.EventHandler(this.description_richbox_TextChanged);
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
            this.address_panel.Location = new System.Drawing.Point(21, 598);
            this.address_panel.Name = "address_panel";
            this.address_panel.Size = new System.Drawing.Size(1031, 299);
            this.address_panel.TabIndex = 88;
            // 
            // address_input
            // 
            this.address_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(13, 47);
            this.address_input.Margin = new System.Windows.Forms.Padding(4);
            this.address_input.Multiline = true;
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(1000, 50);
            this.address_input.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(8, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 36);
            this.label13.TabIndex = 46;
            this.label13.Text = "Business Full Address:";
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(13, 142);
            this.email_input.Margin = new System.Windows.Forms.Padding(4);
            this.email_input.Multiline = true;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(492, 50);
            this.email_input.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(8, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 36);
            this.label11.TabIndex = 38;
            this.label11.Text = "Business Email Address:";
            // 
            // phone_input
            // 
            this.phone_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.Location = new System.Drawing.Point(528, 142);
            this.phone_input.Margin = new System.Windows.Forms.Padding(4);
            this.phone_input.Multiline = true;
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(485, 50);
            this.phone_input.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(522, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 36);
            this.label10.TabIndex = 40;
            this.label10.Text = "Business Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(8, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 36);
            this.label5.TabIndex = 48;
            this.label5.Text = "Business Website:";
            // 
            // website_input
            // 
            this.website_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website_input.Location = new System.Drawing.Point(14, 231);
            this.website_input.Margin = new System.Windows.Forms.Padding(4);
            this.website_input.Multiline = true;
            this.website_input.Name = "website_input";
            this.website_input.Size = new System.Drawing.Size(1000, 50);
            this.website_input.TabIndex = 49;
            // 
            // supporting_panel
            // 
            this.supporting_panel.Controls.Add(this.attach_file);
            this.supporting_panel.Location = new System.Drawing.Point(21, 955);
            this.supporting_panel.Name = "supporting_panel";
            this.supporting_panel.Size = new System.Drawing.Size(1031, 201);
            this.supporting_panel.TabIndex = 54;
            // 
            // attach_file
            // 
            this.attach_file.BackColor = System.Drawing.Color.White;
            this.attach_file.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_file.ForeColor = System.Drawing.Color.DimGray;
            this.attach_file.Location = new System.Drawing.Point(17, 17);
            this.attach_file.Margin = new System.Windows.Forms.Padding(4);
            this.attach_file.Name = "attach_file";
            this.attach_file.Size = new System.Drawing.Size(997, 170);
            this.attach_file.TabIndex = 48;
            this.attach_file.Text = "Attach files that will help us verify your details and contact information";
            this.attach_file.UseVisualStyleBackColor = false;
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.image_flowlayout.Location = new System.Drawing.Point(21, 1163);
            this.image_flowlayout.Margin = new System.Windows.Forms.Padding(4);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(1031, 143);
            this.image_flowlayout.TabIndex = 55;
            this.image_flowlayout.WrapContents = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(14, 915);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(439, 42);
            this.label12.TabIndex = 53;
            this.label12.Text = "Business Credentials / Certificates";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(634, 1414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 89;
            // 
            // JP_RegisterBusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JP_RegisterBusinessForm";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.business_panel.ResumeLayout(false);
            this.business_panel.PerformLayout();
            this.address_panel.ResumeLayout(false);
            this.address_panel.PerformLayout();
            this.supporting_panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox industry_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
    }
}
