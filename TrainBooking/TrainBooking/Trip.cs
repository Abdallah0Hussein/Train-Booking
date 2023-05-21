using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrainBooking
{
    public class Trip
    {
        private int tripID = 0;
        private int trainID;
        private int driverID;
        public string departureT;
        public string arrivalT;

        public int TrainID { get => trainID; }
        public int DriverID { get => driverID; }
        public int TripID { get => tripID; set => tripID = value; }
        
        public Trip(DateTime departureT, DateTime arrivalT)
        {
            this.departureT = departureT.ToShortDateString() + " " + departureT.ToShortTimeString();
            this.arrivalT = arrivalT.ToShortDateString() + " " + arrivalT.ToShortTimeString();
        }

        public bool setTrainID(int ID)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            SqlCommand command = new SqlCommand($"SELECT Count(TrainID) FROM Train WHERE TrainID = {ID}", connection);

            int isExist = (int)command.ExecuteScalar();
            trainID = ID;
            return isExist == 1;
        }

        public bool setDriverID(int ID)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            SqlCommand command = new SqlCommand($"SELECT Count(DriverID) FROM Driver WHERE DriverID = {ID}", connection);

            int isExist = (int)command.ExecuteScalar();
            driverID = ID;
            return isExist == 1;
        }
    }
}
