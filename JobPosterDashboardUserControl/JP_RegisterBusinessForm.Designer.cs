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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.industry_input = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.description_richbox = new System.Windows.Forms.RichTextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.website_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address_input = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.attach_file = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.review_button = new System.Windows.Forms.Button();
            this.draft_button = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Business Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Business Industry";
            // 
            // name_input
            // 
            this.name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(35, 167);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(994, 37);
            this.name_input.TabIndex = 3;
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
            this.industry_input.Location = new System.Drawing.Point(35, 256);
            this.industry_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.industry_input.Name = "industry_input";
            this.industry_input.Size = new System.Drawing.Size(993, 34);
            this.industry_input.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Business Description";
            // 
            // description_richbox
            // 
            this.description_richbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_richbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_richbox.Location = new System.Drawing.Point(35, 343);
            this.description_richbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.description_richbox.Name = "description_richbox";
            this.description_richbox.Size = new System.Drawing.Size(995, 90);
            this.description_richbox.TabIndex = 6;
            this.description_richbox.Text = "";
            // 
            // email_input
            // 
            this.email_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(35, 633);
            this.email_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(414, 37);
            this.email_input.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 599);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Business Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 599);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "Business Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 457);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 42);
            this.label8.TabIndex = 7;
            this.label8.Text = "Business Address and Contact Details";
            // 
            // phone_input
            // 
            this.phone_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.Location = new System.Drawing.Point(528, 633);
            this.phone_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(501, 37);
            this.phone_input.TabIndex = 11;
            // 
            // website_input
            // 
            this.website_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.website_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website_input.Location = new System.Drawing.Point(35, 720);
            this.website_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.website_input.Name = "website_input";
            this.website_input.Size = new System.Drawing.Size(993, 37);
            this.website_input.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 682);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Business Website URL";
            // 
            // address_input
            // 
            this.address_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(33, 546);
            this.address_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(995, 37);
            this.address_input.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 513);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 36);
            this.label11.TabIndex = 15;
            this.label11.Text = "Business Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 774);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(439, 42);
            this.label16.TabIndex = 23;
            this.label16.Text = "Business Credentials / Certificates";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-1, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(391, 70);
            this.label14.TabIndex = 32;
            this.label14.Text = "Register Business";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(35, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 1);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(33, 501);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 1);
            this.panel2.TabIndex = 34;
            // 
            // attach_file
            // 
            this.attach_file.BackColor = System.Drawing.Color.White;
            this.attach_file.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_file.Location = new System.Drawing.Point(33, 834);
            this.attach_file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attach_file.Name = "attach_file";
            this.attach_file.Size = new System.Drawing.Size(996, 58);
            this.attach_file.TabIndex = 49;
            this.attach_file.Text = "Attach files that will help us verify your details and contact information";
            this.attach_file.UseVisualStyleBackColor = false;
            this.attach_file.Click += new System.EventHandler(this.attach_file_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(33, 816);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 1);
            this.panel3.TabIndex = 50;
            // 
            // profile_picture
            // 
            this.profile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_picture.Image = global::JobNear.Properties.Resources.default_profile;
            this.profile_picture.Location = new System.Drawing.Point(1071, 124);
            this.profile_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(266, 246);
            this.profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_picture.TabIndex = 51;
            this.profile_picture.TabStop = false;
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.image_flowlayout.Location = new System.Drawing.Point(37, 900);
            this.image_flowlayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(992, 143);
            this.image_flowlayout.TabIndex = 53;
            this.image_flowlayout.WrapContents = false;
            // 
            // review_button
            // 
            this.review_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_button.Location = new System.Drawing.Point(1137, 1081);
            this.review_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.review_button.Name = "review_button";
            this.review_button.Size = new System.Drawing.Size(215, 44);
            this.review_button.TabIndex = 55;
            this.review_button.Text = "Submit for review";
            this.review_button.UseVisualStyleBackColor = true;
            this.review_button.Click += new System.EventHandler(this.review_button_Click);
            // 
            // draft_button
            // 
            this.draft_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draft_button.Location = new System.Drawing.Point(963, 1081);
            this.draft_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.draft_button.Name = "draft_button";
            this.draft_button.Size = new System.Drawing.Size(167, 44);
            this.draft_button.TabIndex = 54;
            this.draft_button.Text = "Save as Draft";
            this.draft_button.UseVisualStyleBackColor = true;
            // 
            // upload_button
            // 
            this.upload_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_button.Location = new System.Drawing.Point(1071, 378);
            this.upload_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(267, 39);
            this.upload_button.TabIndex = 56;
            this.upload_button.Text = "Upload picture here";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(35, 1151);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1049, 1);
            this.panel4.TabIndex = 51;
            // 
            // JP_RegisterBusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.review_button);
            this.Controls.Add(this.draft_button);
            this.Controls.Add(this.image_flowlayout);
            this.Controls.Add(this.profile_picture);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.attach_file);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.address_input);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.website_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_input);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.description_richbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.industry_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JP_RegisterBusinessForm";
            this.Size = new System.Drawing.Size(1375, 1166);
            this.Load += new System.EventHandler(this.JP_RegisterBusinessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.ComboBox industry_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox description_richbox;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.TextBox website_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button attach_file;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox profile_picture;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.Button review_button;
        private System.Windows.Forms.Button draft_button;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Panel panel4;
    }
}
