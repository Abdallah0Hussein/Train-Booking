using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainBooking
{
    public class Booking
    {
        public void AddBooking(SqlConnection connection, int PassengerID, int TicketNumber, DateTime DepartureTime)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Booking] (PassengerID, TicketNumber, BookingDate) VALUES ({PassengerID}, {TicketNumber}, Convert(DateTime, '{DepartureTime.ToShortDateString() + " " + DepartureTime.ToShortTimeString()}'));", connection);
            command.ExecuteNonQuery();
        }
        public void AddTicket(SqlConnection connection, int PassngerID, int TripID, string TypeTicket, decimal price,int seatNumber = 1)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Ticket] (PassengerID, TripID, seatNumber ,ticketType, price) VALUES ('" + PassngerID + "','" + TripID + "','" + seatNumber + "','" + TypeTicket + "','" + price + "')", connection);
            command.ExecuteNonQuery();
        }
        public int UpdateSeatNumber(SqlConnection connection, int TripID)
        {
            SqlCommand command = new SqlCommand(" SELECT COUNT(TripID) FROM Ticket WHERE TripID = @TripID", connection);
            command.Parameters.AddWithValue("@TripID", TripID);

            int seat = (int)command.ExecuteScalar();
            return seat;
        }
            public void UpdateTicket(SqlConnection connection, int PassngerID, int TripID, int seatNumber)
        {
            SqlCommand command = new SqlCommand("UPDATE[Ticket] SET seatNumber = '"+seatNumber+"' where PassengerID = '"+PassngerID+"' and TripID = '"+TripID+"'", connection);
            command.ExecuteNonQuery();
        }
    }
}
