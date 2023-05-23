using System;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();

        }


<<<<<<< HEAD
=======


        private void Booking_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            Booking Bk = new Booking();
            DateTime departureTime = DepatureTime.Value;
            int PassengerID = Customer.cus.CustomerID;
            int TicketNumber = 2;
            Booking bookingattribuits = new Booking();
            bookingattribuits.AddBooking(connection, PassengerID, TicketNumber, departureTime);


  
            string Type = TicketType.Text;
            if (Type == "VIP Ticket")
            {
                decimal price = 520;
                int TripID = 5;
                Bk.AddTicket(connection, PassengerID, TripID, Type, price);
                int seatNumber = Bk.UpdateSeatNumber(connection,TripID);
                Bk.UpdateTicket(connection, PassengerID, TripID, seatNumber);
            }
            else if (Type == "Econmic Ticket")
            {
                decimal price = 260;
                int TripID = 5;
                Bk.AddTicket(connection, PassengerID, TripID, Type, price);
                int seatNumber = Bk.UpdateSeatNumber(connection, TripID);
                Bk.UpdateTicket(connection, PassengerID, TripID, seatNumber);
            }
        }

>>>>>>> 60d04b13f80c89c59020425addf4341f66f36eeb
        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingDataSet.Train' table. You can move, or remove it, as needed.
            this.trainTableAdapter.Fill(this.bookingDataSet.Train);

        }

        private void ShowTrips_Click(object sender, EventArgs e)
        {
            ShowTripsFrom showTripsFrom = new ShowTripsFrom();
            showTripsFrom.DTime = DepatureTime.Value;
            showTripsFrom.ATime = DateTime.Parse(ArrivalTime.Text);
            showTripsFrom.SStaion = SrcStation.Text;
            showTripsFrom.DStation = DestStation.Text;
            showTripsFrom.ticketID = int.Parse(TicketID.Text);
            showTripsFrom.ShowDialog();
        }
    }
}

