using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrainBooking
{
    public class Admin
    {
        private static Dictionary<string, string> StationLocations = new Dictionary<string, string>()
        {
            {"Valentine",  "The Heartlands"},
            {"Rhodes",  "Scarlett Meadows"},
            {"Blackwater",  "Great Plains"},
            {"Saint Denis",  "Bayou Nwa"},
            {"Van Horn",  "Roanoke Ridge"},
            {"Annesburg",  "Roanoke Ridge"},
            {"Riggs Station",  "Big Valley"},
            {"Emerald Station",  "The Heartlands"},
            {"Bacchus Station",  "Cumberland Forest"}
        };

        public void addTrain(string name, string status, int capacity)
        {
            return;
        }

        public void updateTrain(int trainID , string name, string status, int capacity)
        {
            return;
        }

        public void addTrip(Trip trip, string srcStation, string destStation)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            SqlCommand command = new SqlCommand($"INSERT INTO Trip (TrainID, DriverID, DepartureTime, ArrivalTime) VALUES ({trip.TrainID}, {trip.DriverID}, CONVERT(datetime, '{trip.departureT}'), CONVERT(datetime, '{trip.arrivalT}'));", connection);
            command.ExecuteNonQuery();

            command = new SqlCommand($"SELECT MAX(TripID) FROM Trip;", connection);
            SqlDataReader TripIDReader = command.ExecuteReader();
            int tripID = 0;
            if (TripIDReader.HasRows)
            {
                // read the first (and only) row of the result set
                TripIDReader.Read();

                // get the value of the first (and only) column
                tripID = TripIDReader.GetInt32(0);
                TripIDReader.Close();

                command = new SqlCommand($"INSERT INTO Station VALUES({tripID}, '{srcStation}', '{StationLocations[srcStation]}', 'Source')", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand($"INSERT INTO Station VALUES({tripID}, '{destStation}', '{StationLocations[destStation]}', 'Destination')", connection);
                command.ExecuteNonQuery();
            }
            MessageBox.Show($"Trip {tripID} Has been Added to System Successfully :)");
            connection.Close();
            return;
        }

        public void updateTrip(int trainID, int DriverID, string depatureTime, string arrivalTime, string srcStation, string destStation)
        {
            return;
        }
    }
}
