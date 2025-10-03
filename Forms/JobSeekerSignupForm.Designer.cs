namespace JobNear.Forms
{
    partial class JobSeekerSignupForm
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
            this.password_checkbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.confirm_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.app_panel.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Image = global::JobNear.Properties.Resources.left_arrow;
            this.back_button.Location = new System.Drawing.Point(5, 5);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(24, 24);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.back_button.TabIndex = 22;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.password_checkbox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.username_input);
            this.panel2.Controls.Add(this.confirm_input);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.password_input);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.login_label);
            this.panel2.Controls.Add(this.register_button);
            this.panel2.Controls.Add(this.email_input);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.phone_input);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(381, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 633);
            this.panel2.TabIndex = 21;
            // 
            // password_checkbox
            // 
            this.password_checkbox.AutoSize = true;
            this.password_checkbox.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_checkbox.Location = new System.Drawing.Point(102, 520);
            this.password_checkbox.Name = "password_checkbox";
            this.password_checkbox.Size = new System.Drawing.Size(112, 23);
            this.password_checkbox.TabIndex = 36;
            this.password_checkbox.Text = "Show Password";
            this.password_checkbox.UseVisualStyleBackColor = true;
            this.password_checkbox.CheckedChanged += new System.EventHandler(this.password_checkbox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(99, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 37);
            this.label7.TabIndex = 28;
            this.label7.Text = "take the first step today.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(62, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 37);
            this.label8.TabIndex = 27;
            this.label8.Text = "Your career journey begins here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 48);
            this.label5.TabIndex = 26;
            this.label5.Text = "Job Seeker";
            // 
            // username_input
            // 
            this.username_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_input.Location = new System.Drawing.Point(107, 192);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(277, 31);
            this.username_input.TabIndex = 25;
            // 
            // confirm_input
            // 
            this.confirm_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_input.Location = new System.Drawing.Point(102, 487);
            this.confirm_input.Name = "confirm_input";
            this.confirm_input.Size = new System.Drawing.Size(277, 31);
            this.confirm_input.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(102, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Confirm Password";
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(102, 414);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(277, 31);
            this.password_input.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(102, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(126, 595);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(222, 22);
            this.login_label.TabIndex = 17;
            this.login_label.Text = "Already have an account? Click me.";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.register_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.White;
            this.register_button.Location = new System.Drawing.Point(102, 546);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(277, 42);
            this.register_button.TabIndex = 16;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(102, 340);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(277, 31);
            this.email_input.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(102, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email Address";
            // 
            // phone_input
            // 
            this.phone_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.Location = new System.Drawing.Point(102, 266);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(277, 31);
            this.phone_input.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(102, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(102, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // JobSeekerSignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 705);
            this.Controls.Add(this.app_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobSeekerSignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobSeekerSignupForm";
            this.Load += new System.EventHandler(this.JobSeekerSignupForm_Load);
            this.app_panel.ResumeLayout(false);
            this.app_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel app_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirm_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox password_checkbox;
    }
}