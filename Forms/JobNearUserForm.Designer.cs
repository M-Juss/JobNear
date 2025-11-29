namespace JobNear.Forms
{
    partial class JobNearUserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.app_panel = new System.Windows.Forms.Panel();
            this.close_image = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_button = new System.Windows.Forms.Button();
            this.jp_button = new System.Windows.Forms.Button();
            this.js_button = new System.Windows.Forms.Button();
            this.app_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_image)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // app_panel
            // 
            this.app_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.app_panel.Controls.Add(this.close_image);
            this.app_panel.Controls.Add(this.panel);
            this.app_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app_panel.Location = new System.Drawing.Point(0, 0);
            this.app_panel.Margin = new System.Windows.Forms.Padding(4);
            this.app_panel.Name = "app_panel";
            this.app_panel.Size = new System.Drawing.Size(1641, 868);
            this.app_panel.TabIndex = 0;
            this.app_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.app_panel_Paint);
            // 
            // close_image
            // 
            this.close_image.Location = new System.Drawing.Point(1591, 5);
            this.close_image.Margin = new System.Windows.Forms.Padding(4);
            this.close_image.Name = "close_image";
            this.close_image.Size = new System.Drawing.Size(44, 39);
            this.close_image.TabIndex = 2;
            this.close_image.TabStop = false;
            this.close_image.Click += new System.EventHandler(this.close_image_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.admin_button);
            this.panel.Controls.Add(this.jp_button);
            this.panel.Controls.Add(this.js_button);
            this.panel.Location = new System.Drawing.Point(516, 108);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(624, 651);
            this.panel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 48);
            this.label5.TabIndex = 21;
            this.label5.Text = "Local Opportunity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 48);
            this.label4.TabIndex = 20;
            this.label4.Text = "Where Local Talent meets";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobNear.Properties.Resources.JobnearLogo;
            this.pictureBox1.Location = new System.Drawing.Point(231, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // admin_button
            // 
            this.admin_button.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_button.ForeColor = System.Drawing.Color.White;
            this.admin_button.Location = new System.Drawing.Point(117, 520);
            this.admin_button.Margin = new System.Windows.Forms.Padding(4);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(398, 66);
            this.admin_button.TabIndex = 2;
            this.admin_button.Text = "Continue as Administrator";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // jp_button
            // 
            this.jp_button.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jp_button.ForeColor = System.Drawing.Color.White;
            this.jp_button.Location = new System.Drawing.Point(117, 422);
            this.jp_button.Margin = new System.Windows.Forms.Padding(4);
            this.jp_button.Name = "jp_button";
            this.jp_button.Size = new System.Drawing.Size(398, 66);
            this.jp_button.TabIndex = 1;
            this.jp_button.Text = "Continue as Job Poster";
            this.jp_button.UseVisualStyleBackColor = true;
            this.jp_button.Click += new System.EventHandler(this.jp_button_Click);
            // 
            // js_button
            // 
            this.js_button.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.js_button.ForeColor = System.Drawing.Color.White;
            this.js_button.Location = new System.Drawing.Point(117, 324);
            this.js_button.Margin = new System.Windows.Forms.Padding(4);
            this.js_button.Name = "js_button";
            this.js_button.Size = new System.Drawing.Size(398, 66);
            this.js_button.TabIndex = 0;
            this.js_button.Text = "Continue as Job Seeker";
            this.js_button.UseVisualStyleBackColor = true;
            this.js_button.Click += new System.EventHandler(this.js_button_Click);
            // 
            // JobNearUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 868);
            this.Controls.Add(this.app_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobNearUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobNearUser";
            this.Load += new System.EventHandler(this.JobNearUser_Load);
            this.app_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_image)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel app_panel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button jp_button;
        private System.Windows.Forms.Button js_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox close_image;
    }
}