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
            this.business_name_textbox = new System.Windows.Forms.TextBox();
            this.business_industry_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.business_description_richbox = new System.Windows.Forms.RichTextBox();
            this.business_email_address_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.business_contact_textbox = new System.Windows.Forms.TextBox();
            this.business_website_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.business_address_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.postal_code_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.document_table = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.document_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.add_document_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.save_draft_button = new System.Windows.Forms.Button();
            this.clear_draft_button = new System.Windows.Forms.Button();
            this.country_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.document_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Business Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Business Industry";
            // 
            // business_name_textbox
            // 
            this.business_name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_name_textbox.Location = new System.Drawing.Point(113, 154);
            this.business_name_textbox.Name = "business_name_textbox";
            this.business_name_textbox.Size = new System.Drawing.Size(360, 23);
            this.business_name_textbox.TabIndex = 3;
            // 
            // business_industry_combobox
            // 
            this.business_industry_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.business_industry_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_industry_combobox.FormattingEnabled = true;
            this.business_industry_combobox.Items.AddRange(new object[] {
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
            this.business_industry_combobox.Location = new System.Drawing.Point(544, 154);
            this.business_industry_combobox.Name = "business_industry_combobox";
            this.business_industry_combobox.Size = new System.Drawing.Size(357, 24);
            this.business_industry_combobox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Business Description";
            // 
            // business_description_richbox
            // 
            this.business_description_richbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_description_richbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_description_richbox.Location = new System.Drawing.Point(113, 211);
            this.business_description_richbox.Name = "business_description_richbox";
            this.business_description_richbox.Size = new System.Drawing.Size(788, 150);
            this.business_description_richbox.TabIndex = 6;
            this.business_description_richbox.Text = "";
            // 
            // business_email_address_textbox
            // 
            this.business_email_address_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_email_address_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_email_address_textbox.Location = new System.Drawing.Point(113, 453);
            this.business_email_address_textbox.Name = "business_email_address_textbox";
            this.business_email_address_textbox.Size = new System.Drawing.Size(360, 23);
            this.business_email_address_textbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Business Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Business Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Business Contact Details";
            // 
            // business_contact_textbox
            // 
            this.business_contact_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_contact_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_contact_textbox.Location = new System.Drawing.Point(544, 453);
            this.business_contact_textbox.Name = "business_contact_textbox";
            this.business_contact_textbox.Size = new System.Drawing.Size(357, 23);
            this.business_contact_textbox.TabIndex = 11;
            // 
            // business_website_textbox
            // 
            this.business_website_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_website_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_website_textbox.Location = new System.Drawing.Point(113, 514);
            this.business_website_textbox.Name = "business_website_textbox";
            this.business_website_textbox.Size = new System.Drawing.Size(788, 23);
            this.business_website_textbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Business Website URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Country";
            // 
            // business_address_textbox
            // 
            this.business_address_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_address_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_address_textbox.Location = new System.Drawing.Point(113, 628);
            this.business_address_textbox.Name = "business_address_textbox";
            this.business_address_textbox.Size = new System.Drawing.Size(788, 23);
            this.business_address_textbox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(110, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Business Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(108, 572);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 30);
            this.label12.TabIndex = 14;
            this.label12.Text = "Business Address";
            // 
            // postal_code_textbox
            // 
            this.postal_code_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postal_code_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postal_code_textbox.Location = new System.Drawing.Point(544, 691);
            this.postal_code_textbox.Name = "postal_code_textbox";
            this.postal_code_textbox.Size = new System.Drawing.Size(109, 23);
            this.postal_code_textbox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 671);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Postal/ Zip Code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(108, 748);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(385, 30);
            this.label16.TabIndex = 23;
            this.label16.Text = "Business Credentials/ Certificates";
            // 
            // document_table
            // 
            this.document_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.document_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.document_title,
            this.issue_date,
            this.expiration_date,
            this.remove,
            this.edit});
            this.document_table.Location = new System.Drawing.Point(113, 820);
            this.document_table.Name = "document_table";
            this.document_table.Size = new System.Drawing.Size(788, 183);
            this.document_table.TabIndex = 24;
            // 
            // image
            // 
            this.image.FillWeight = 110F;
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.Width = 110;
            // 
            // document_title
            // 
            this.document_title.FillWeight = 335F;
            this.document_title.HeaderText = "Document Title";
            this.document_title.Name = "document_title";
            this.document_title.Width = 335;
            // 
            // issue_date
            // 
            this.issue_date.HeaderText = "Issue Date";
            this.issue_date.Name = "issue_date";
            // 
            // expiration_date
            // 
            this.expiration_date.HeaderText = "Expiration Date/ Valid Until";
            this.expiration_date.Name = "expiration_date";
            // 
            // remove
            // 
            this.remove.FillWeight = 50F;
            this.remove.HeaderText = "Remove";
            this.remove.Name = "remove";
            this.remove.Text = "Remove";
            this.remove.Width = 50;
            // 
            // edit
            // 
            this.edit.FillWeight = 50F;
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.Width = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(110, 800);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Credentials/ Documents";
            // 
            // add_document_button
            // 
            this.add_document_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_document_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_document_button.Location = new System.Drawing.Point(813, 787);
            this.add_document_button.Name = "add_document_button";
            this.add_document_button.Size = new System.Drawing.Size(88, 30);
            this.add_document_button.TabIndex = 26;
            this.add_document_button.Text = "Add Document";
            this.add_document_button.UseVisualStyleBackColor = false;
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Location = new System.Drawing.Point(667, 1031);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(74, 30);
            this.register_button.TabIndex = 27;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // save_draft_button
            // 
            this.save_draft_button.BackColor = System.Drawing.Color.White;
            this.save_draft_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_draft_button.Location = new System.Drawing.Point(747, 1031);
            this.save_draft_button.Name = "save_draft_button";
            this.save_draft_button.Size = new System.Drawing.Size(74, 30);
            this.save_draft_button.TabIndex = 28;
            this.save_draft_button.Text = "Save Draft";
            this.save_draft_button.UseVisualStyleBackColor = false;
            // 
            // clear_draft_button
            // 
            this.clear_draft_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear_draft_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_draft_button.Location = new System.Drawing.Point(827, 1031);
            this.clear_draft_button.Name = "clear_draft_button";
            this.clear_draft_button.Size = new System.Drawing.Size(74, 30);
            this.clear_draft_button.TabIndex = 29;
            this.clear_draft_button.Text = "Clear Draft";
            this.clear_draft_button.UseVisualStyleBackColor = false;
            this.clear_draft_button.Click += new System.EventHandler(this.clear_draft_button_Click);
            // 
            // country_textbox
            // 
            this.country_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.country_textbox.Enabled = false;
            this.country_textbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_textbox.Location = new System.Drawing.Point(113, 689);
            this.country_textbox.Name = "country_textbox";
            this.country_textbox.Size = new System.Drawing.Size(279, 24);
            this.country_textbox.TabIndex = 30;
            this.country_textbox.Text = "Philippines";
            // 
            // JP_RegisterBusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.country_textbox);
            this.Controls.Add(this.clear_draft_button);
            this.Controls.Add(this.save_draft_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.add_document_button);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.document_table);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.postal_code_textbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.business_address_textbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.business_website_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.business_contact_textbox);
            this.Controls.Add(this.business_email_address_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.business_description_richbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.business_industry_combobox);
            this.Controls.Add(this.business_name_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JP_RegisterBusinessForm";
            this.Size = new System.Drawing.Size(963, 705);
            ((System.ComponentModel.ISupportInitialize)(this.document_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox business_name_textbox;
        private System.Windows.Forms.ComboBox business_industry_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox business_description_richbox;
        private System.Windows.Forms.TextBox business_email_address_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox business_contact_textbox;
        private System.Windows.Forms.TextBox business_website_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox business_address_textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox postal_code_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView document_table;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button add_document_button;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn document_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button save_draft_button;
        private System.Windows.Forms.Button clear_draft_button;
        private System.Windows.Forms.TextBox country_textbox;
    }
}
