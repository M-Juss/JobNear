namespace JobNear.JobSeekerDashboardUserControl
{
    partial class UserControlPractice
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
            this.address_input = new System.Windows.Forms.TextBox();
            this.address_listbox = new System.Windows.Forms.ListBox();
            this.lat_label = new System.Windows.Forms.Label();
            this.lng_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // address_input
            // 
            this.address_input.Location = new System.Drawing.Point(286, 86);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(489, 20);
            this.address_input.TabIndex = 0;
            this.address_input.TextChanged += new System.EventHandler(this.address_input_TextChanged);
            // 
            // address_listbox
            // 
            this.address_listbox.FormattingEnabled = true;
            this.address_listbox.Location = new System.Drawing.Point(259, 141);
            this.address_listbox.Name = "address_listbox";
            this.address_listbox.Size = new System.Drawing.Size(549, 147);
            this.address_listbox.TabIndex = 1;
            this.address_listbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.address_listbox_MouseClick);
            this.address_listbox.SelectedIndexChanged += new System.EventHandler(this.address_listbox_SelectedIndexChanged);
            // 
            // lat_label
            // 
            this.lat_label.AutoSize = true;
            this.lat_label.Location = new System.Drawing.Point(420, 399);
            this.lat_label.Name = "lat_label";
            this.lat_label.Size = new System.Drawing.Size(35, 13);
            this.lat_label.TabIndex = 2;
            this.lat_label.Text = "label1";
            // 
            // lng_label
            // 
            this.lng_label.AutoSize = true;
            this.lng_label.Location = new System.Drawing.Point(496, 399);
            this.lng_label.Name = "lng_label";
            this.lng_label.Size = new System.Drawing.Size(35, 13);
            this.lng_label.TabIndex = 3;
            this.lng_label.Text = "label2";
            // 
            // UserControlPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lng_label);
            this.Controls.Add(this.lat_label);
            this.Controls.Add(this.address_listbox);
            this.Controls.Add(this.address_input);
            this.Name = "UserControlPractice";
            this.Size = new System.Drawing.Size(1031, 705);
            this.Load += new System.EventHandler(this.UserControlPractice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.ListBox address_listbox;
        private System.Windows.Forms.Label lat_label;
        private System.Windows.Forms.Label lng_label;
    }
}
