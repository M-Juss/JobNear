namespace JobNear
{
    partial class JobNear
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_btn = new System.Windows.Forms.Button();
            this.business_btn = new System.Windows.Forms.Button();
            this.worker_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 412);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.admin_btn);
            this.panel2.Controls.Add(this.business_btn);
            this.panel2.Controls.Add(this.worker_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(359, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 412);
            this.panel2.TabIndex = 0;
            // 
            // admin_btn
            // 
            this.admin_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.Location = new System.Drawing.Point(41, 283);
            this.admin_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(281, 58);
            this.admin_btn.TabIndex = 2;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = true;
            // 
            // business_btn
            // 
            this.business_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_btn.Location = new System.Drawing.Point(41, 182);
            this.business_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.business_btn.Name = "business_btn";
            this.business_btn.Size = new System.Drawing.Size(281, 58);
            this.business_btn.TabIndex = 1;
            this.business_btn.Text = "Job Poster";
            this.business_btn.UseVisualStyleBackColor = true;
            // 
            // worker_btn
            // 
            this.worker_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker_btn.Location = new System.Drawing.Point(41, 78);
            this.worker_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.worker_btn.Name = "worker_btn";
            this.worker_btn.Size = new System.Drawing.Size(281, 58);
            this.worker_btn.TabIndex = 0;
            this.worker_btn.Text = "Job Seeker";
            this.worker_btn.UseVisualStyleBackColor = true;
            this.worker_btn.Click += new System.EventHandler(this.worker_btn_Click);
            // 
            // JobNear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JobNear";
            this.Text = "JobNear";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button worker_btn;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button business_btn;
    }
}

