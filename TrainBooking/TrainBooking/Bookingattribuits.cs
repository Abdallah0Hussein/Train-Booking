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
            SqlCommand command = new SqlCommand($"INSERT INTO [Booking] (PassengerID, TicketNumber, BookingDate) VALUES ({PassengerID}, {TicketNumber}, Convert(DateTime, '{DepartureTime.ToShortDateString() + " " + DepartureTime.ToShortTimeString()}'));", connection);
            command.ExecuteNonQuery();
        }
        public void BookingTypeTicket(SqlConnection connection, string TypeTicket)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Ticket] (ticketType) VALUES ('" + TypeTicket + "')", connection);
            command.ExecuteNonQuery();
        }
    }
}
