﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class ListBookingForm : Form
    {
        public ListBookingForm()
        {
            InitializeComponent();
        }

        private void ListBopking_Load(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            int PassengerID = Customer.cus.CustomerID;
            // Create DataTables to hold data from each table
            DataTable table1 = new DataTable();

            // Retrieve the desired attributes from the Station table for "Source" column
            string sourceQuery = "SELECT B.BookingId, BC.TicketNumber, B.BookingDate FROM Booking B INNER JOIN BookingContains BC ON B.BookingId = BC.BookingID WHERE B.PassengerID = '" + PassengerID + "';";


            SqlDataAdapter sqlDaSource = new SqlDataAdapter(sourceQuery, connection);
            sqlDaSource.Fill(table1);


            // Set the merged DataTable as the DataSource of the DataGridView
            dataGridView1.DataSource = table1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            Booking booking = new Booking();
            int bookingID = (int) BookingID.Value;
            int ticketnum = (int) TicketID.Value;
            booking.DeleteTicket(connection, ticketnum);
            booking.DeleteBooking(connection, bookingID, ticketnum);
            MessageBox.Show("Your Booking is Canceled");
        }
    }
}
