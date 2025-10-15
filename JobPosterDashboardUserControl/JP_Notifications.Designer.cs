namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_Notifications
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
            this.search_field = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.notification_dataGrid = new System.Windows.Forms.DataGridView();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.senders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.notification_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notifications";
            // 
            // search_field
            // 
            this.search_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_field.Location = new System.Drawing.Point(431, 112);
            this.search_field.Name = "search_field";
            this.search_field.Size = new System.Drawing.Size(350, 23);
            this.search_field.TabIndex = 1;
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(821, 112);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(67, 23);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // notification_dataGrid
            // 
            this.notification_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notification_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.senders,
            this.subject,
            this.date,
            this.time,
            this.status});
            this.notification_dataGrid.Location = new System.Drawing.Point(96, 183);
            this.notification_dataGrid.Name = "notification_dataGrid";
            this.notification_dataGrid.Size = new System.Drawing.Size(792, 480);
            this.notification_dataGrid.TabIndex = 3;
            // 
            // checkBox
            // 
            this.checkBox.FillWeight = 50F;
            this.checkBox.HeaderText = "";
            this.checkBox.Name = "checkBox";
            this.checkBox.Width = 50;
            // 
            // senders
            // 
            this.senders.FillWeight = 200F;
            this.senders.HeaderText = "From";
            this.senders.Name = "senders";
            this.senders.Width = 200;
            // 
            // subject
            // 
            this.subject.FillWeight = 310F;
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.Width = 310;
            // 
            // date
            // 
            this.date.FillWeight = 80F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 80;
            // 
            // time
            // 
            this.time.FillWeight = 60F;
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.Width = 60;
            // 
            // status
            // 
            this.status.FillWeight = 50F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 50;
            // 
            // JP_Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notification_dataGrid);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_field);
            this.Controls.Add(this.label1);
            this.Name = "JP_Notifications";
            this.Size = new System.Drawing.Size(1031, 705);
            ((System.ComponentModel.ISupportInitialize)(this.notification_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_field;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView notification_dataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn senders;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn status;
    }
}
