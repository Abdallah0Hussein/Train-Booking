using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

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
            return;
        }

        public void updateTrip(int trainID, int DriverID, string depatureTime, string arrivalTime, string srcStation, string destStation)
        {
            return;
        }
    }
}
