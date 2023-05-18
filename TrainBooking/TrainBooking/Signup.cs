using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    public class Signup
    {
        public void Register(SqlConnection connection, string name, string email, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [User] (Name, Email, Password) VALUES (@name, @email, @password)", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();
        }
    }
}
