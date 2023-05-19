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
        public void Bookingattribuitsreg(SqlConnection connection, int BookingID, int PassengerID, int TicketNumber,DateTime BookingDate)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Booking] (BookingId, PassengerId, TicketNumber,BookingDate) VALUES ('" + BookingID + "','" + PassengerID + "', '" + TicketNumber + "', '" + BookingDate +  "')", connection);
            command.ExecuteNonQuery();
        }
    }
}
