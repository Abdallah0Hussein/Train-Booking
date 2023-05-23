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
            this.nTripID.Location = new System.Drawing.Point(159, 99);
            this.nTripID.Margin = new System.Windows.Forms.Padding(2);
            this.nTripID.Name = "nTripID";
            this.nTripID.Size = new System.Drawing.Size(226, 28);
            this.nTripID.TabIndex = 18;
            // 
            // SendTripID
            // 
            this.SendTripID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.SendTripID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SendTripID.Location = new System.Drawing.Point(261, 151);
            this.SendTripID.Margin = new System.Windows.Forms.Padding(2);
            this.SendTripID.Name = "SendTripID";
            this.SendTripID.Size = new System.Drawing.Size(140, 40);
            this.SendTripID.TabIndex = 21;
            this.SendTripID.Text = "Send";
            this.SendTripID.UseVisualStyleBackColor = true;
            this.SendTripID.Click += new System.EventHandler(this.SendTripID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Trip ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 39);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(412, 202);
            this.Controls.Add(this.nTripID);
            this.Controls.Add(this.SendTripID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
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