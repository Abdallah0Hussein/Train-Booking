using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class ShowTripsFrom : Form
    {
        public DateTime DTime { get; set; }
        public DateTime ATime { get; set; }
        public string SStaion { get; set; }
        public string DStation { get; set; }
        public int ticketID { get; set; }
        public string TicketType { get; set; }

        public ShowTripsFrom()
        {
            InitializeComponent();
        }

        private void ShowTripsFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainBookingDataSet2.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter.Fill(this.trainBookingDataSet2.Station);
            // TODO: This line of code loads data into the 'trainBookingDataSet1.Train' table. You can move, or remove it, as needed.
            this.trainTableAdapter.Fill(this.trainBookingDataSet1.Train);
            // TODO: This line of code loads data into the 'trainBookingDataSet1.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.trainBookingDataSet1.Trip);

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            // Create DataTables to hold data from each table
            DataTable table1 = new DataTable();

            // Retrieve the desired attributes from the Station table for "Source" column
            string sourceQuery = "SELECT Trip.TripID, Driver.Name as DriverName, Trip.DepartureTime, Trip.ArrivalTime, SourceStation.Name AS Source, DestinationStation.Name AS Destination FROM Trip JOIN Station AS SourceStation ON Trip.TripID = SourceStation.TripID AND SourceStation.station_type = 'Source' JOIN Station AS DestinationStation ON Trip.TripID = DestinationStation.TripID AND DestinationStation.station_type = 'Destination' JOIN Driver ON Trip.DriverID = Driver.DriverID";


            SqlDataAdapter sqlDaSource = new SqlDataAdapter(sourceQuery, connection);
            sqlDaSource.Fill(table1);


            // Set the merged DataTable as the DataSource of the DataGridView
            dataGridView4.DataSource = table1;

        }

        private void Booking_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            Booking Bk = new Booking();
            DateTime departureTime = DTime;
            int PassengerID = Customer.cus.CustomerID;
            int TicketNumber = 2;
            Booking bookingattribuits = new Booking();
            bookingattribuits.AddBooking(connection, PassengerID, TicketNumber, departureTime);




            string Type = TicketType;
            if (Type == "VIP Ticket")
            {
                decimal price = 520;
                int TripID = 5;
                Bk.AddTicket(connection, PassengerID, TripID, Type, price);
                int seatNumber = Bk.UpdateSeatNumber(connection, TripID);
                Bk.UpdateTicket(connection, PassengerID, TripID, seatNumber);
            }
            else if (Type == "Econmic Ticket")
            {
                decimal price = 260;
                int tripID = int.Parse(TripID.Text);
                Bk.AddTicket(connection, PassengerID, tripID, Type, price);
                int seatNumber = Bk.UpdateSeatNumber(connection, tripID);
                Bk.UpdateTicket(connection, PassengerID, tripID, seatNumber);
            }
        }

    }
}
