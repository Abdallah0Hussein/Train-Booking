using System.Data.SqlClient;

namespace TrainBooking
{
    public class UserAuthentication
    {
        public bool customerCheckCredentials(SqlConnection connection, string email, string password)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Email = @email AND Password = @password", connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            int count = (int)command.ExecuteScalar();
            return count == 1;
        }
        public void customerRegister(SqlConnection connection, string name, string email, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [User] (Name, Email, Password) VALUES ('" + name + "', '" + email + "', '" + password + "')", connection);
            command.ExecuteNonQuery();
        }
        public bool adminCheckCredentials(SqlConnection connection, string email, string password)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [Admin] WHERE Email = @email AND Password = @password", connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            int count = (int)command.ExecuteScalar();
            return count == 1;
        }
        public void adminRegister(SqlConnection connection, string name, string email, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Admin] (Name, Email, Password) VALUES ('" + name + "', '" + email + "', '" + password + "')", connection);
            command.ExecuteNonQuery();
        }
    }
}
