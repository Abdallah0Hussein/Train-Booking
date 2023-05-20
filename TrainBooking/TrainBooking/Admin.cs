using System;
using System.Collections.Generic;
using System.Data;
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
            /*
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            SqlCommand command = new SqlCommand($"INSERT INTO Trip (TrainID, DriverID, NumberOfPassengers, DepatureTime, ArrivalTime) VALUES ({trip.TrainID}, {trip.DriverID}, 75, CONVERT(datetime, '{trip.depatureT}'), CONVERT(datetime, '{trip.arrivalT}')", connection);
            command.ExecuteNonQuery();
            */
            
            return;
        }

        public void updateTrip(int trainID, int DriverID, string depatureTime, string arrivalTime, string srcStation, string destStation)
        {
            return;
        }
    }
}
