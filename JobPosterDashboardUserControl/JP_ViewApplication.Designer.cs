namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_ViewApplication
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
            this.view_lbl = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.remarks_richtext = new System.Windows.Forms.TextBox();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.documents_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.business_panel = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.header_label = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.sub_lbl = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.panel1);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Controls.Add(this.sub_lbl);
            this.sidebar_panel.Controls.Add(this.header_label);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.view_lbl);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.submit_button);
            this.panel1.Controls.Add(this.remarks_richtext);
            this.panel1.Controls.Add(this.status_combo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.image_flowlayout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.documents_lbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(49, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 491);
            this.panel1.TabIndex = 77;
            // 
            // view_lbl
            // 
            this.view_lbl.AutoSize = true;
            this.view_lbl.BackColor = System.Drawing.Color.Transparent;
            this.view_lbl.Font = new System.Drawing.Font("Poppins", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.view_lbl.Location = new System.Drawing.Point(160, 16);
            this.view_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.view_lbl.Name = "view_lbl";
            this.view_lbl.Size = new System.Drawing.Size(161, 30);
            this.view_lbl.TabIndex = 108;
            this.view_lbl.Text = "View Cover Letter";
            this.view_lbl.Click += new System.EventHandler(this.view_lbl_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.LightGray;
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(953, 435);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(141, 44);
            this.cancel_button.TabIndex = 107;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.LightGray;
            this.submit_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(1104, 435);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(141, 44);
            this.submit_button.TabIndex = 106;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // remarks_richtext
            // 
            this.remarks_richtext.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarks_richtext.Location = new System.Drawing.Point(437, 311);
            this.remarks_richtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remarks_richtext.Multiline = true;
            this.remarks_richtext.Name = "remarks_richtext";
            this.remarks_richtext.Size = new System.Drawing.Size(808, 114);
            this.remarks_richtext.TabIndex = 104;
            // 
            // status_combo
            // 
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Accepted",
            "Rejected"});
            this.status_combo.Location = new System.Drawing.Point(29, 311);
            this.status_combo.Margin = new System.Windows.Forms.Padding(4);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(360, 44);
            this.status_combo.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(24, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 36);
            this.label2.TabIndex = 64;
            this.label2.Text = "Set Status:";
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.image_flowlayout.Location = new System.Drawing.Point(24, 95);
            this.image_flowlayout.Margin = new System.Windows.Forms.Padding(4);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(1221, 169);
            this.image_flowlayout.TabIndex = 63;
            this.image_flowlayout.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 61;
            this.label1.Text = "Cover Letter:";
            // 
            // documents_lbl
            // 
            this.documents_lbl.AutoSize = true;
            this.documents_lbl.BackColor = System.Drawing.Color.Transparent;
            this.documents_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documents_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.documents_lbl.Location = new System.Drawing.Point(18, 55);
            this.documents_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.documents_lbl.Name = "documents_lbl";
            this.documents_lbl.Size = new System.Drawing.Size(137, 36);
            this.documents_lbl.TabIndex = 62;
            this.documents_lbl.Text = "Documents:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(431, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 36);
            this.label3.TabIndex = 105;
            this.label3.Text = "Remarks:";
            // 
            // business_panel
            // 
            this.business_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.business_panel.Controls.Add(this.address_lbl);
            this.business_panel.Controls.Add(this.phone_lbl);
            this.business_panel.Controls.Add(this.email_lbl);
            this.business_panel.Controls.Add(this.name_label);
            this.business_panel.Controls.Add(this.profile_picture);
            this.business_panel.Location = new System.Drawing.Point(48, 89);
            this.business_panel.Margin = new System.Windows.Forms.Padding(4);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(1273, 251);
            this.business_panel.TabIndex = 76;
            this.business_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.business_panel_Paint);
            // 
            // name_label
            // 
            this.name_label.AllowDrop = true;
            this.name_label.AutoEllipsis = true;
            this.name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_label.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(302, 29);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(869, 43);
            this.name_label.TabIndex = 9;
            // 
            // profile_picture
            // 
            this.profile_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile_picture.Location = new System.Drawing.Point(71, 29);
            this.profile_picture.Margin = new System.Windows.Forms.Padding(4);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(211, 198);
            this.profile_picture.TabIndex = 0;
            this.profile_picture.TabStop = false;
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.ForeColor = System.Drawing.Color.DimGray;
            this.header_label.Location = new System.Drawing.Point(32, 9);
            this.header_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(263, 60);
            this.header_label.TabIndex = 75;
            this.header_label.Text = "Applying For: ";
            // 
            // email_lbl
            // 
            this.email_lbl.AllowDrop = true;
            this.email_lbl.AutoEllipsis = true;
            this.email_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_lbl.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(302, 81);
            this.email_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(869, 43);
            this.email_lbl.TabIndex = 10;
            // 
            // phone_lbl
            // 
            this.phone_lbl.AllowDrop = true;
            this.phone_lbl.AutoEllipsis = true;
            this.phone_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_lbl.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(302, 133);
            this.phone_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(869, 43);
            this.phone_lbl.TabIndex = 11;
            // 
            // address_lbl
            // 
            this.address_lbl.AllowDrop = true;
            this.address_lbl.AutoEllipsis = true;
            this.address_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_lbl.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(302, 184);
            this.address_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(869, 43);
            this.address_lbl.TabIndex = 12;
            // 
            // sub_lbl
            // 
            this.sub_lbl.AutoSize = true;
            this.sub_lbl.BackColor = System.Drawing.Color.Transparent;
            this.sub_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.sub_lbl.Location = new System.Drawing.Point(43, 58);
            this.sub_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sub_lbl.Name = "sub_lbl";
            this.sub_lbl.Size = new System.Drawing.Size(142, 36);
            this.sub_lbl.TabIndex = 109;
            this.sub_lbl.Text = "Cover Letter:";
            // 
            // JP_ViewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_ViewApplication";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.business_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox profile_picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label documents_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.TextBox remarks_richtext;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label view_lbl;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label sub_lbl;
    }
}
