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

