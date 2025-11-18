namespace JobNear.Forms
{
    partial class JobSeekerLoginForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.forgot_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
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
            this.app_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.app_panel_Paint);
            // 
            // back_button
            // 
            this.back_button.Image = global::JobNear.Properties.Resources.left_arrow;
            this.back_button.Location = new System.Drawing.Point(5, 5);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(24, 24);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.back_button.TabIndex = 23;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.password_input);
            this.panel2.Controls.Add(this.password_checkbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.email_input);
            this.panel2.Controls.Add(this.forgot_label);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.signup_label);
            this.panel2.Controls.Add(this.login_button);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(387, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 542);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // password_checkbox
            // 
            this.password_checkbox.AutoSize = true;
            this.password_checkbox.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_checkbox.Location = new System.Drawing.Point(90, 355);
            this.password_checkbox.Name = "password_checkbox";
            this.password_checkbox.Size = new System.Drawing.Size(112, 23);
            this.password_checkbox.TabIndex = 25;
            this.password_checkbox.Text = "Show Password";
            this.password_checkbox.UseVisualStyleBackColor = true;
            this.password_checkbox.CheckedChanged += new System.EventHandler(this.password_checkbox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(34, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = " Opportunities are waiting for you.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(129, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Welcome back!";
            // 
            // email_input
            // 
            this.email_input.BackColor = System.Drawing.SystemColors.Window;
            this.email_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(88, 217);
            this.email_input.Multiline = true;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(277, 41);
            this.email_input.TabIndex = 22;
            this.email_input.TextChanged += new System.EventHandler(this.email_input_TextChanged);
            // 
            // forgot_label
            // 
            this.forgot_label.AutoSize = true;
            this.forgot_label.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_label.Location = new System.Drawing.Point(138, 473);
            this.forgot_label.Name = "forgot_label";
            this.forgot_label.Size = new System.Drawing.Size(175, 22);
            this.forgot_label.TabIndex = 21;
            this.forgot_label.Text = "Forgot password? Click here";
            this.forgot_label.Click += new System.EventHandler(this.forgot_label_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 56);
            this.label5.TabIndex = 19;
            this.label5.Text = "Job Seeker";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label.Location = new System.Drawing.Point(122, 454);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(204, 22);
            this.signup_label.TabIndex = 17;
            this.signup_label.Text = "Don\'t have an account? Click me";
            this.signup_label.Click += new System.EventHandler(this.signup_label_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.login_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(89, 396);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(277, 42);
            this.login_button.TabIndex = 16;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(91, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(91, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(88, 306);
            this.password_input.Multiline = true;
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(277, 41);
            this.password_input.TabIndex = 26;
            // 
            // JobSeekerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 705);
            this.Controls.Add(this.app_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobSeekerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobSeekerLoginForm";
            this.Load += new System.EventHandler(this.JobSeekerLoginForm_Load);
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
        private System.Windows.Forms.Label forgot_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox password_checkbox;
        private System.Windows.Forms.TextBox password_input;
    }
}