namespace JobNear.Forms
{
    partial class ForgotPasswordForm
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
            this.back_button = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.changepass_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.newpass_input = new System.Windows.Forms.TextBox();
            this.confirmnewpass_input = new System.Windows.Forms.TextBox();
            this.app_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // app_panel
            // 
            this.app_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.app_panel.Controls.Add(this.back_button);
            this.app_panel.Controls.Add(this.panel2);
            this.app_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app_panel.Location = new System.Drawing.Point(0, 0);
            this.app_panel.Name = "app_panel";
            this.app_panel.Size = new System.Drawing.Size(1231, 705);
            this.app_panel.TabIndex = 1;
            // 
            // back_button
            // 
            this.back_button.Image = global::JobNear.Properties.Resources.left_arrow;
            this.back_button.Location = new System.Drawing.Point(5, 5);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(24, 24);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.back_button.TabIndex = 1;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.confirmnewpass_input);
            this.panel2.Controls.Add(this.newpass_input);
            this.panel2.Controls.Add(this.email_input);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.changepass_button);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(387, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 491);
            this.panel2.TabIndex = 23;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(118, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "Let’s get you back in!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(35, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "No worries, we all forget sometimes. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(102, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Confirm New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 48);
            this.label5.TabIndex = 30;
            this.label5.Text = "Forgot Password?";
            // 
            // changepass_button
            // 
            this.changepass_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.changepass_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepass_button.ForeColor = System.Drawing.Color.White;
            this.changepass_button.Location = new System.Drawing.Point(98, 416);
            this.changepass_button.Name = "changepass_button";
            this.changepass_button.Size = new System.Drawing.Size(277, 42);
            this.changepass_button.TabIndex = 16;
            this.changepass_button.Text = "Change Password";
            this.changepass_button.UseVisualStyleBackColor = false;
            this.changepass_button.Click += new System.EventHandler(this.changepass_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(102, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(101, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(98, 204);
            this.email_input.Multiline = true;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(277, 41);
            this.email_input.TabIndex = 41;
            // 
            // newpass_input
            // 
            this.newpass_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass_input.Location = new System.Drawing.Point(99, 278);
            this.newpass_input.Multiline = true;
            this.newpass_input.Name = "newpass_input";
            this.newpass_input.Size = new System.Drawing.Size(277, 41);
            this.newpass_input.TabIndex = 42;
            // 
            // confirmnewpass_input
            // 
            this.confirmnewpass_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmnewpass_input.Location = new System.Drawing.Point(98, 352);
            this.confirmnewpass_input.Multiline = true;
            this.confirmnewpass_input.Name = "confirmnewpass_input";
            this.confirmnewpass_input.Size = new System.Drawing.Size(277, 41);
            this.confirmnewpass_input.TabIndex = 43;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 705);
            this.Controls.Add(this.app_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.app_panel.ResumeLayout(false);
            this.app_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel app_panel;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changepass_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmnewpass_input;
        private System.Windows.Forms.TextBox newpass_input;
        private System.Windows.Forms.TextBox email_input;
    }
}