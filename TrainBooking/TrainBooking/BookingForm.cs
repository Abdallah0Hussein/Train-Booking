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
            DBConnection conn = new DBConnection();
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



            connection.Close();
        }




        private void UpdateTrip_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            Bookingattribuits Bk = new Bookingattribuits();
            DateTime departureTime = DateTime.Parse(DepatureTime.Text);
            int passenger = 1;
            int TicketNumber = 2;
            int BookingID = 1;
            Bookingattribuits bookingattribuits = new Bookingattribuits();
            bookingattribuits.Bookingattribuitsreg(connection, passenger, TicketNumber, departureTime);

            string Type = TicketType.Text;
            Bk.BookingTypeTicket(connection, Type);

            int TicketNum = Customer.cus.CustomerID;
            TicketID.Text = TicketNum.ToString();
            TicketID.Enabled = false;
        }
        }
    }

