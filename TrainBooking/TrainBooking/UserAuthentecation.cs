using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    public class UserAuthentication
    {
        public bool CheckCredentials(SqlConnection connection, string email, string password)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Email = @email AND Password = @password", connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }
        public void Register(SqlConnection connection, string name, string email, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [User] (Name, Email, Password) VALUES ('" + name + "', '" + email + "', '" + password + "')", connection);
            command.ExecuteNonQuery();
        }
    }
}
