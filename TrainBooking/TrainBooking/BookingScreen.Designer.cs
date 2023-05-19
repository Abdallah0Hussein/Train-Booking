namespace TrainBooking
{
    partial class BookingScreen
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
            this.DestStation = new System.Windows.Forms.ComboBox();
            this.SrcStation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TrainID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DepatureTime = new System.Windows.Forms.DateTimePicker();
            this.UpdateTrip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lablel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrainID)).BeginInit();
            this.SuspendLayout();
            // 
            // DestStation
            // 
            this.DestStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.DestStation.FormattingEnabled = true;
            this.DestStation.Items.AddRange(new object[] {
            "Rhodes",
            "Valentine",
            "Van Horn",
            "Saint Denis",
            "Black Water",
            "Strawberry",
            "Annesburg",
            "Riggs Station"});
            this.DestStation.Location = new System.Drawing.Point(309, 348);
            this.DestStation.Name = "DestStation";
            this.DestStation.Size = new System.Drawing.Size(407, 34);
            this.DestStation.TabIndex = 68;
            // 
            // SrcStation
            // 
            this.SrcStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SrcStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.SrcStation.FormattingEnabled = true;
            this.SrcStation.Items.AddRange(new object[] {
            "Rhodes",
            "Valentine",
            "Van Horn",
            "Saint Denis",
            "Black Water",
            "Strawberry",
            "Annesburg",
            "Riggs Station"});
            this.SrcStation.Location = new System.Drawing.Point(309, 276);
            this.SrcStation.Name = "SrcStation";
            this.SrcStation.Size = new System.Drawing.Size(407, 34);
            this.SrcStation.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(74, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "Destination Station";
            // 
            // TrainID
            // 
            this.TrainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrainID.Location = new System.Drawing.Point(309, 74);
            this.TrainID.Name = "TrainID";
            this.TrainID.Size = new System.Drawing.Size(407, 34);
            this.TrainID.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(75, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 64;
            this.label6.Text = "Source Station";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ArrivalTime.Location = new System.Drawing.Point(309, 208);
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(407, 34);
            this.ArrivalTime.TabIndex = 63;
            this.ArrivalTime.Value = new System.DateTime(2023, 5, 19, 9, 55, 39, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(75, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 62;
            this.label5.Text = "Arrival Time";
            // 
            // DepatureTime
            // 
            this.DepatureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DepatureTime.Location = new System.Drawing.Point(309, 141);
            this.DepatureTime.Name = "DepatureTime";
            this.DepatureTime.Size = new System.Drawing.Size(407, 34);
            this.DepatureTime.TabIndex = 61;
            this.DepatureTime.Value = new System.DateTime(2023, 5, 19, 9, 55, 39, 0);
            // 
            // UpdateTrip
            // 
            this.UpdateTrip.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.UpdateTrip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateTrip.Location = new System.Drawing.Point(309, 439);
            this.UpdateTrip.Name = "UpdateTrip";
            this.UpdateTrip.Size = new System.Drawing.Size(187, 49);
            this.UpdateTrip.TabIndex = 60;
            this.UpdateTrip.Text = "Booking";
            this.UpdateTrip.UseVisualStyleBackColor = true;
            this.UpdateTrip.Click += new System.EventHandler(this.UpdateTrip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(75, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Depature Time";
            // 
            // lablel
            // 
            this.lablel.AutoSize = true;
            this.lablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lablel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lablel.Location = new System.Drawing.Point(74, 79);
            this.lablel.Name = "lablel";
            this.lablel.Size = new System.Drawing.Size(92, 29);
            this.lablel.TabIndex = 58;
            this.lablel.Text = "TrainID";
            // 
            // BookingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.DestStation);
            this.Controls.Add(this.SrcStation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TrainID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ArrivalTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepatureTime);
            this.Controls.Add(this.UpdateTrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lablel);
            this.Name = "BookingScreen";
            this.Text = "BookingScreen";
            ((System.ComponentModel.ISupportInitialize)(this.TrainID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DestStation;
        private System.Windows.Forms.ComboBox SrcStation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown TrainID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ArrivalTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DepatureTime;
        private System.Windows.Forms.Button UpdateTrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lablel;
    }
}