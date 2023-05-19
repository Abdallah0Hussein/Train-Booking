namespace TrainBooking
{
    partial class AdminPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddTrainLink = new System.Windows.Forms.Button();
            this.UpdateTrainLink = new System.Windows.Forms.Button();
            this.AddTripLink = new System.Windows.Forms.Button();
            this.UpdateTripLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(193, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Admin";
            // 
            // AddTrainLink
            // 
            this.AddTrainLink.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.AddTrainLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddTrainLink.Location = new System.Drawing.Point(40, 156);
            this.AddTrainLink.Name = "AddTrainLink";
            this.AddTrainLink.Size = new System.Drawing.Size(237, 73);
            this.AddTrainLink.TabIndex = 1;
            this.AddTrainLink.Text = "Add Train";
            this.AddTrainLink.UseVisualStyleBackColor = true;
            this.AddTrainLink.Click += new System.EventHandler(this.AddTrainLink_Click);
            // 
            // UpdateTrainLink
            // 
            this.UpdateTrainLink.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.UpdateTrainLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateTrainLink.Location = new System.Drawing.Point(40, 297);
            this.UpdateTrainLink.Name = "UpdateTrainLink";
            this.UpdateTrainLink.Size = new System.Drawing.Size(237, 73);
            this.UpdateTrainLink.TabIndex = 2;
            this.UpdateTrainLink.Text = "Update Train\'s Data";
            this.UpdateTrainLink.UseVisualStyleBackColor = true;
            this.UpdateTrainLink.Click += new System.EventHandler(this.UpdateTrainLink_Click);
            // 
            // AddTripLink
            // 
            this.AddTripLink.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.AddTripLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddTripLink.Location = new System.Drawing.Point(389, 156);
            this.AddTripLink.Name = "AddTripLink";
            this.AddTripLink.Size = new System.Drawing.Size(237, 73);
            this.AddTripLink.TabIndex = 3;
            this.AddTripLink.Text = "Add Trip";
            this.AddTripLink.UseVisualStyleBackColor = true;
            this.AddTripLink.Click += new System.EventHandler(this.AddTripLink_Click);
            // 
            // UpdateTripLink
            // 
            this.UpdateTripLink.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.UpdateTripLink.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateTripLink.Location = new System.Drawing.Point(389, 297);
            this.UpdateTripLink.Name = "UpdateTripLink";
            this.UpdateTripLink.Size = new System.Drawing.Size(237, 73);
            this.UpdateTripLink.TabIndex = 4;
            this.UpdateTripLink.Text = "Update Trip\'s data";
            this.UpdateTripLink.UseVisualStyleBackColor = true;
            this.UpdateTripLink.Click += new System.EventHandler(this.UpdateTripLink_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(684, 444);
            this.Controls.Add(this.UpdateTripLink);
            this.Controls.Add(this.AddTripLink);
            this.Controls.Add(this.UpdateTrainLink);
            this.Controls.Add(this.AddTrainLink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPage";
            this.Text = "Admin_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTrainLink;
        private System.Windows.Forms.Button UpdateTrainLink;
        private System.Windows.Forms.Button AddTripLink;
        private System.Windows.Forms.Button UpdateTripLink;
    }
}