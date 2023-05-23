namespace TrainBooking
{
    partial class UpdateTrainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTrainForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendTrainID = new System.Windows.Forms.Button();
            this.nTrainID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nTrainID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Train ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 48);
            this.label4.TabIndex = 12;
            this.label4.Text = "Update a Train";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendTrainID
            // 
            this.SendTrainID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.SendTrainID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SendTrainID.Location = new System.Drawing.Point(359, 181);
            this.SendTrainID.Name = "SendTrainID";
            this.SendTrainID.Size = new System.Drawing.Size(187, 49);
            this.SendTrainID.TabIndex = 17;
            this.SendTrainID.Text = "Send";
            this.SendTrainID.UseVisualStyleBackColor = true;
            this.SendTrainID.Click += new System.EventHandler(this.SendTrainID_Click);
            // 
            // nTrainID
            // 
            this.nTrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nTrainID.Location = new System.Drawing.Point(230, 123);
            this.nTrainID.Name = "nTrainID";
            this.nTrainID.Size = new System.Drawing.Size(301, 34);
            this.nTrainID.TabIndex = 0;
            // 
            // UpdateTrainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(569, 242);
            this.Controls.Add(this.nTrainID);
            this.Controls.Add(this.SendTrainID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "UpdateTrainForm1";
            this.Text = "Update a Train";
            ((System.ComponentModel.ISupportInitialize)(this.nTrainID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendTrainID;
        private System.Windows.Forms.NumericUpDown nTrainID;
    }
}