using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    public class Bookingattribuits
    {
        public void Bookingattribuitsreg(SqlConnection connection, int PassengerID, int TicketNumber, DateTime DepartureTime)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Booking] (PassengerID, TicketNumber, BookingDate) VALUES ({PassengerID}, {TicketNumber}, Convert(DateTime, '{DepartureTime.ToShortDateString() + " " + DepartureTime.ToShortTimeString()}'));", connection);
            command.ExecuteNonQuery();
        }
        public void BookingTypeTicket(SqlConnection connection, int PassngerID, int TripID, int seatNumber, string TypeTicket, decimal price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Ticket] (PassngerID, TripID, seatNumber ,ticketType, price) VALUES ('" + PassngerID + "','" + TripID + "','" + seatNumber + "','" + TypeTicket + "','" + price + "')", connection);
            command.ExecuteNonQuery();
        }
    }
}
