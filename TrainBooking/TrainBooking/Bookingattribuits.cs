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
        public void Bookingattribuitsreg(SqlConnection connection, int PassengerID, int TicketNumber, DateTime DepartureTime)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Booking] ( PassengerID, TicketNumber, BookingDate) VALUES ('" + PassengerID + "', '" + TicketNumber + "','" + DepartureTime.ToShortDateString() + "')", connection);
            command.ExecuteNonQuery();
        }
    }
}
