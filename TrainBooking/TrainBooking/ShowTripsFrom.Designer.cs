namespace TrainBooking
{
    partial class ShowTripsFrom
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tripIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBookingDataSet1 = new TrainBooking.TrainBookingDataSet1();
            this.tripTableAdapter = new TrainBooking.TrainBookingDataSet1TableAdapters.TripTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTableAdapter = new TrainBooking.TrainBookingDataSet1TableAdapters.TrainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripIDDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tripBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-56, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tripIDDataGridViewTextBoxColumn
            // 
            this.tripIDDataGridViewTextBoxColumn.DataPropertyName = "TripID";
            this.tripIDDataGridViewTextBoxColumn.HeaderText = "TripID";
            this.tripIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tripIDDataGridViewTextBoxColumn.Name = "tripIDDataGridViewTextBoxColumn";
            this.tripIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tripIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.trainBookingDataSet1;
            // 
            // trainBookingDataSet1
            // 
            this.trainBookingDataSet1.DataSetName = "TrainBookingDataSet1";
            this.trainBookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.trainBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(485, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(221, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.trainBookingDataSet1;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // ShowTripsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowTripsFrom";
            this.Text = "ShowTripsFrom";
            this.Load += new System.EventHandler(this.ShowTripsFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainBookingDataSet1 trainBookingDataSet1;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private TrainBookingDataSet1TableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private TrainBookingDataSet1TableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
    }
}