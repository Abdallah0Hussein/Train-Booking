using System;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class BookingForm : Form
    {
        public static int LastTicket;
        public BookingForm()
        {
            InitializeComponent();
            LastTicket = ShowTripsFrom.intializeLastTicket();
        }


        private void ShowTrips_Click(object sender, EventArgs e)
        {
            ShowTripsFrom showTripsFrom = new ShowTripsFrom();
            showTripsFrom.DTime = DepatureTime.Value;
            showTripsFrom.ATime = ArrivalTime.Value;
            showTripsFrom.SStaion = SrcStation.Text;
            showTripsFrom.DStation = DestStation.Text;
            showTripsFrom.TicketType = TicketType.Text;
            showTripsFrom.NumofSeats = (int) NumofSeats.Value;

            showTripsFrom.ShowDialog();
        }
    }
}

