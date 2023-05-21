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
            this.UpdateTrip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TicketPrice = new System.Windows.Forms.ComboBox();
            this.TicketType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ticket = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketID = new System.Windows.Forms.ComboBox();
            this.trainBookingDataSet = new TrainBooking.TrainBookingDataSet();
            this.trainBookingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
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
            this.DestStation.Location = new System.Drawing.Point(309, 239);
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
            this.label8.Location = new System.Drawing.Point(74, 240);
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
            // UpdateTrip
            // 
            this.UpdateTrip.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.UpdateTrip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateTrip.Location = new System.Drawing.Point(309, 514);
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
            this.label4.Location = new System.Drawing.Point(75, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Depature Time";
            // 
            // TicketPrice
            // 
            this.TicketPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.TicketPrice.FormattingEnabled = true;
            this.TicketPrice.Items.AddRange(new object[] {
            "Rhodes",
            "Valentine",
            "Van Horn",
            "Saint Denis",
            "Black Water",
            "Strawberry",
            "Annesburg",
            "Riggs Station"});
            this.TicketPrice.Location = new System.Drawing.Point(309, 393);
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.Size = new System.Drawing.Size(407, 34);
            this.TicketPrice.TabIndex = 72;
            // 
            // TicketType
            // 
            this.TicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.TicketType.FormattingEnabled = true;
            this.TicketType.Items.AddRange(new object[] {
            "Rhodes",
            "Valentine",
            "Van Horn",
            "Saint Denis",
            "Black Water",
            "Strawberry",
            "Annesburg",
            "Riggs Station"});
            this.TicketType.Location = new System.Drawing.Point(309, 325);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(407, 34);
            this.TicketType.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(74, 393);
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
            this.Ticket.Location = new System.Drawing.Point(74, 326);
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
            // TicketID
            // 
            this.TicketID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.TicketID.FormattingEnabled = true;
            this.TicketID.Items.AddRange(new object[] {
            "Rhodes",
            "Valentine",
            "Van Horn",
            "Saint Denis",
            "Black Water",
            "Strawberry",
            "Annesburg",
            "Riggs Station"});
            this.TicketID.Location = new System.Drawing.Point(309, 456);
            this.TicketID.Name = "TicketID";
            this.TicketID.Size = new System.Drawing.Size(407, 34);
            this.TicketID.TabIndex = 74;
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
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Destination});
            this.dgv1.Location = new System.Drawing.Point(749, 71);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(337, 502);
            this.dgv1.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(839, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "Avilable Trips";
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.MinimumWidth = 6;
            this.Source.Name = "Source";
            this.Source.Width = 125;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 6;
            this.Destination.Name = "Destination";
            this.Destination.Width = 125;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1098, 616);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.TicketID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TicketPrice);
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
            this.Controls.Add(this.UpdateTrip);
            this.Controls.Add(this.label4);
            this.Name = "BookingForm";
            this.Text = "BookingScreen";
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
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
        private System.Windows.Forms.Button UpdateTrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TicketPrice;
        private System.Windows.Forms.ComboBox TicketType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ticket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TicketID;
        private System.Windows.Forms.BindingSource trainBookingDataSetBindingSource;
        private TrainBookingDataSet trainBookingDataSet;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
    }
}