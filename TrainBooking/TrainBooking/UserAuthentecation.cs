using System.Data.SqlClient;
using System.Text.RegularExpressions;

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
        public bool isValidEmail(string email)
        {
            // A Form of E-mail following IETF standards
            string emailPattern = @"^[^@.]+(.[^@.]+)?(@[A-Za-z0-9]+)(\\-[A-Za-z0-9]+)?(.[0-9]*[A-Za-z]+[0-9]*(\\-[A-Za-z0-9]+)?)+$";
            // If the user's email follow the regex form return true, false otherwise
            return Regex.IsMatch(email, emailPattern);
        }
        public int CostumerID(SqlConnection connection, string email, string password)
        {
            SqlCommand command = new SqlCommand("SELECT UserID FROM [User] WHERE Email = @email AND Password = @password", connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            int count = (int)command.ExecuteScalar();
            return count;
        }

        public string NameCostumer(SqlConnection connection, string email, string password)
        {
            SqlCommand command = new SqlCommand("SELECT Name FROM [User] WHERE Email = @email AND Password = @password", connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            string count = (string)command.ExecuteScalar();
            return count;
        }
        public void updateCustomer(SqlConnection connection, int ID, string name, string email, string password)
        {
            SqlCommand command = new SqlCommand("UPDATE [User] SET Name = @name, Password = @password,Email = @email WHERE UserID = @ID", connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@ID", ID);
            command.ExecuteNonQuery();
        }
        public bool IsEmailExist(SqlConnection connection, string email)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Email = @Email", connection);

            command.Parameters.AddWithValue("@Email", email);
            int count = (int)command.ExecuteScalar();
            return count == 1;

        }
    }

}

