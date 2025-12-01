namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_ReportBusiness
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
            this.button2 = new System.Windows.Forms.Button();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.info_panel = new System.Windows.Forms.Panel();
            this.description_input = new System.Windows.Forms.TextBox();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.attach_file = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.subject_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.business_panel = new System.Windows.Forms.Panel();
            this.footer_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.company_logo_picturebox = new System.Windows.Forms.PictureBox();
            this.sidebar_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1024, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.label3);
            this.sidebar_panel.Controls.Add(this.info_panel);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 37);
            this.label3.TabIndex = 53;
            this.label3.Text = "Report this business";
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.description_input);
            this.info_panel.Controls.Add(this.image_flowlayout);
            this.info_panel.Controls.Add(this.attach_file);
            this.info_panel.Controls.Add(this.submit_button);
            this.info_panel.Controls.Add(this.cancel_button);
            this.info_panel.Controls.Add(this.subject_input);
            this.info_panel.Controls.Add(this.label1);
            this.info_panel.Controls.Add(this.label2);
            this.info_panel.Location = new System.Drawing.Point(15, 279);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(1000, 406);
            this.info_panel.TabIndex = 52;
            // 
            // description_input
            // 
            this.description_input.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_input.Location = new System.Drawing.Point(144, 62);
            this.description_input.Margin = new System.Windows.Forms.Padding(2);
            this.description_input.Multiline = true;
            this.description_input.Name = "description_input";
            this.description_input.Size = new System.Drawing.Size(827, 86);
            this.description_input.TabIndex = 54;
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.image_flowlayout.Location = new System.Drawing.Point(28, 214);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(943, 129);
            this.image_flowlayout.TabIndex = 53;
            this.image_flowlayout.WrapContents = false;
            // 
            // attach_file
            // 
            this.attach_file.BackColor = System.Drawing.Color.White;
            this.attach_file.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_file.ForeColor = System.Drawing.Color.DimGray;
            this.attach_file.Location = new System.Drawing.Point(28, 157);
            this.attach_file.Name = "attach_file";
            this.attach_file.Size = new System.Drawing.Size(943, 47);
            this.attach_file.TabIndex = 49;
            this.attach_file.Text = "Attach files that will help us verify your report.";
            this.attach_file.UseVisualStyleBackColor = false;
            this.attach_file.Click += new System.EventHandler(this.attach_file_Click);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(878, 360);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(93, 35);
            this.submit_button.TabIndex = 47;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(777, 360);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(85, 35);
            this.cancel_button.TabIndex = 46;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // subject_input
            // 
            this.subject_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_input.Location = new System.Drawing.Point(145, 12);
            this.subject_input.Multiline = true;
            this.subject_input.Name = "subject_input";
            this.subject_input.Size = new System.Drawing.Size(826, 41);
            this.subject_input.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // business_panel
            // 
            this.business_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.business_panel.Controls.Add(this.footer_label);
            this.business_panel.Controls.Add(this.description_label);
            this.business_panel.Controls.Add(this.name_label);
            this.business_panel.Controls.Add(this.company_logo_picturebox);
            this.business_panel.Location = new System.Drawing.Point(15, 50);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(1000, 211);
            this.business_panel.TabIndex = 51;
            this.business_panel.Click += new System.EventHandler(this.business_panel_Click);
            // 
            // footer_label
            // 
            this.footer_label.AutoEllipsis = true;
            this.footer_label.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer_label.ForeColor = System.Drawing.Color.Gray;
            this.footer_label.Location = new System.Drawing.Point(246, 177);
            this.footer_label.Name = "footer_label";
            this.footer_label.Size = new System.Drawing.Size(710, 22);
            this.footer_label.TabIndex = 8;
            // 
            // description_label
            // 
            this.description_label.AutoEllipsis = true;
            this.description_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(246, 50);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(710, 135);
            this.description_label.TabIndex = 9;
            // 
            // name_label
            // 
            this.name_label.AllowDrop = true;
            this.name_label.AutoEllipsis = true;
            this.name_label.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(242, 14);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(714, 36);
            this.name_label.TabIndex = 7;
            // 
            // company_logo_picturebox
            // 
            this.company_logo_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.company_logo_picturebox.Location = new System.Drawing.Point(39, 22);
            this.company_logo_picturebox.Name = "company_logo_picturebox";
            this.company_logo_picturebox.Size = new System.Drawing.Size(190, 176);
            this.company_logo_picturebox.TabIndex = 6;
            this.company_logo_picturebox.TabStop = false;
            // 
            // JS_ReportBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Controls.Add(this.button2);
            this.Name = "JS_ReportBusiness";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.business_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Button attach_file;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox subject_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.TextBox description_input;
        private System.Windows.Forms.Label footer_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox company_logo_picturebox;
    }
}
