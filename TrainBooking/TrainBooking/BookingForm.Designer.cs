namespace TrainBooking
{
    partial class BookingForm
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
            this.DestStation = new System.Windows.Forms.ComboBox();
            this.SrcStation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DepatureTime = new System.Windows.Forms.DateTimePicker();
            this.Booking = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TicketType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ticket = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainBookingDataSet = new TrainBooking.TrainBookingDataSet();
            this.trainBookingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TicketID = new System.Windows.Forms.TextBox();
            this.bookingDataSet = new TrainBooking.BookingDataSet();
            this.bookingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTableAdapter = new TrainBooking.BookingDataSetTableAdapters.TrainTableAdapter();
            this.trainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ShowTrips = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).BeginInit();
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
            this.DestStation.Location = new System.Drawing.Point(309, 235);
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
            this.SrcStation.Location = new System.Drawing.Point(309, 167);
            this.SrcStation.Name = "SrcStation";
            this.SrcStation.Size = new System.Drawing.Size(407, 34);
            this.SrcStation.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(74, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "Destination Station";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(75, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 64;
            this.label6.Text = "Source Station";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.CustomFormat = "dd / MM / yyyy  hh:mm tt";
            this.ArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTime.Location = new System.Drawing.Point(309, 71);
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
            this.label5.Location = new System.Drawing.Point(75, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 62;
            this.label5.Text = "Arrival Time";
            // 
            // DepatureTime
            // 
            this.DepatureTime.CustomFormat = "dd / MM / yyyy  hh:mm tt";
            this.DepatureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DepatureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepatureTime.Location = new System.Drawing.Point(309, 4);
            this.DepatureTime.Name = "DepatureTime";
            this.DepatureTime.Size = new System.Drawing.Size(407, 34);
            this.DepatureTime.TabIndex = 61;
            this.DepatureTime.Value = new System.DateTime(2023, 5, 19, 9, 55, 39, 0);
            // 
            // Booking
            // 
            this.Booking.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.Booking.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Booking.Location = new System.Drawing.Point(297, 514);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(187, 49);
            this.Booking.TabIndex = 60;
            this.Booking.Text = "Book";
            this.Booking.UseVisualStyleBackColor = true;
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(75, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Depature Time";
            // 
            // TicketType
            // 
            this.TicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.TicketType.FormattingEnabled = true;
            this.TicketType.Items.AddRange(new object[] {
            "VIP Ticket",
            "Econmic Ticket"});
            this.TicketType.Location = new System.Drawing.Point(309, 302);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(407, 34);
            this.TicketType.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(76, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ticket Price";
            // 
            // Ticket
            // 
            this.Ticket.AutoSize = true;
            this.Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Ticket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ticket.Location = new System.Drawing.Point(74, 302);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(140, 29);
            this.Ticket.TabIndex = 69;
            this.Ticket.Text = "Ticket Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(75, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 73;
            this.label2.Text = "TicketID";
            // 
            // trainBookingDataSet
            // 
            this.trainBookingDataSet.DataSetName = "TrainBookingDataSet";
            this.trainBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainBookingDataSetBindingSource
            // 
            this.trainBookingDataSetBindingSource.DataSource = this.trainBookingDataSet;
            this.trainBookingDataSetBindingSource.Position = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(386, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 29);
            this.label7.TabIndex = 78;
            this.label7.Text = "VIP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(384, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 29);
            this.label9.TabIndex = 79;
            this.label9.Text = "520";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(544, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 29);
            this.label10.TabIndex = 81;
            this.label10.Text = "260";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(517, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 29);
            this.label11.TabIndex = 80;
            this.label11.Text = "Econmic";
            // 
            // TicketID
            // 
            this.TicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TicketID.Location = new System.Drawing.Point(297, 456);
            this.TicketID.Name = "TicketID";
            this.TicketID.Size = new System.Drawing.Size(419, 34);
            this.TicketID.TabIndex = 82;
            // 
            // bookingDataSet
            // 
            this.bookingDataSet.DataSetName = "BookingDataSet";
            this.bookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingDataSetBindingSource
            // 
            this.bookingDataSetBindingSource.DataSource = this.bookingDataSet;
            this.bookingDataSetBindingSource.Position = 0;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.bookingDataSet;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // trainBindingSource1
            // 
            this.trainBindingSource1.DataMember = "Train";
            this.trainBindingSource1.DataSource = this.bookingDataSetBindingSource;
            // 
            // ShowTrips
            // 
            this.ShowTrips.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.ShowTrips.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ShowTrips.Location = new System.Drawing.Point(570, 514);
            this.ShowTrips.Name = "ShowTrips";
            this.ShowTrips.Size = new System.Drawing.Size(187, 49);
            this.ShowTrips.TabIndex = 84;
            this.ShowTrips.Text = "Show All Trips";
            this.ShowTrips.UseVisualStyleBackColor = true;
            this.ShowTrips.Click += new System.EventHandler(this.ShowTrips_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(961, 616);
            this.Controls.Add(this.ShowTrips);
            this.Controls.Add(this.TicketID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TicketType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ticket);
            this.Controls.Add(this.DestStation);
            this.Controls.Add(this.SrcStation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ArrivalTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepatureTime);
            this.Controls.Add(this.Booking);
            this.Controls.Add(this.label4);
            this.Name = "BookingForm";
            this.Text = "BookingScreen";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DestStation;
        private System.Windows.Forms.ComboBox SrcStation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ArrivalTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DepatureTime;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TicketType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ticket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource trainBookingDataSetBindingSource;
        private TrainBookingDataSet trainBookingDataSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TicketID;
        private System.Windows.Forms.BindingSource bookingDataSetBindingSource;
        private BookingDataSet bookingDataSet;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private BookingDataSetTableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.BindingSource trainBindingSource1;
        private System.Windows.Forms.Button ShowTrips;
    }
}