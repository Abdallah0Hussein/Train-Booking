using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Diagnostics;

namespace TrainBooking
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            this.Load += avilableTrips_Load; // Add the event handler to the Load event
        }
        private void avilableTrips_Load(object sender, EventArgs e)
        {
            /*DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            // Retrieve the desired attributes from the Station table for "Source" column
            string sourceQuery = "SELECT Name FROM Station WHERE Station_Type like 'Source'";

            // Retrieve the desired attributes from the Station table for "Destination" column
            string destinationQuery = "SELECT Name FROM Station WHERE Station_Type like 'Destination'";

            // Create a new DataTable to hold the retrieved data for "Source" column
            DataTable dtblSource = new DataTable();
            SqlDataAdapter sqlDaSource = new SqlDataAdapter(sourceQuery, connection);
            sqlDaSource.Fill(dtblSource);

            // Create a new DataTable to hold the retrieved data for "Destination" column
            DataTable dtblDestination = new DataTable();
            SqlDataAdapter sqlDaDestination = new SqlDataAdapter(destinationQuery, connection);
            sqlDaDestination.Fill(dtblDestination);

            // Bind the "Source" DataTable to the "Source" column in the DataGridView
            dgv1.Columns.Add("Source", "Source");
            foreach (DataRow row in dtblSource.Rows)
            {
                dgv1.Rows.Add(row["Name"]);
            }

            // Bind the "Destination" DataTable to the "Destination" column in the DataGridView
            foreach (DataRow row in dtblDestination.Rows)
            {
                dgv1.Rows[dgv1.Rows.Count - 1].Cells["Destination"].Value = row["Name"];
            }

            int TicketNum = Customer.cus.CustomerID;
            TicketID.Text = TicketNum.ToString();
            TicketID.Enabled = false;

            connection.Close();*/
        }




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

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingDataSet.Train' table. You can move, or remove it, as needed.
            this.trainTableAdapter.Fill(this.bookingDataSet.Train);

        }

        private void ShowTrips_Click(object sender, EventArgs e)
        {
            ShowTripsFrom showTripsFrom = new ShowTripsFrom();
            showTripsFrom.ShowDialog();
        }
    }
    }

