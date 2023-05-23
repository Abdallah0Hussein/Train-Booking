namespace TrainBooking
{
    partial class UpdateTripForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTripForm1));
            this.nTripID = new System.Windows.Forms.NumericUpDown();
            this.SendTripID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tripIDErr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nTripID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripIDErr)).BeginInit();
            this.SuspendLayout();
            // 
            // nTripID
            // 
            this.nTripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.nTripID.Location = new System.Drawing.Point(230, 125);
            this.nTripID.Name = "nTripID";
            this.nTripID.Size = new System.Drawing.Size(301, 33);
            this.nTripID.TabIndex = 18;
            // 
            // SendTripID
            // 
            this.SendTripID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.SendTripID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SendTripID.Location = new System.Drawing.Point(358, 184);
            this.SendTripID.Name = "SendTripID";
            this.SendTripID.Size = new System.Drawing.Size(187, 49);
            this.SendTripID.TabIndex = 21;
            this.SendTripID.Text = "Send";
            this.SendTripID.UseVisualStyleBackColor = true;
            this.SendTripID.Click += new System.EventHandler(this.SendTripID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Trip ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 48);
            this.label4.TabIndex = 19;
            this.label4.Text = "Update a Trip";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tripIDErr
            // 
            this.tripIDErr.ContainerControl = this;
            // 
            // UpdateTripForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(577, 248);
            this.Controls.Add(this.nTripID);
            this.Controls.Add(this.SendTripID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "UpdateTripForm1";
            this.Text = "Update a Trip";
            ((System.ComponentModel.ISupportInitialize)(this.nTripID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripIDErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nTripID;
        private System.Windows.Forms.Button SendTripID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider tripIDErr;
    }
}