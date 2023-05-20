using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    internal class Bookingattribuits
    {
        public void Bookingattribuitsreg(SqlConnection connection, int TripID, DateTime DepartureTime, DateTime ArrivalTime)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Trip] ( DepartureTime, ArrivalTime) VALUES ('" + DepartureTime + "', '" + ArrivalTime + "')", connection);
            command.ExecuteNonQuery();
        }
    }
}
