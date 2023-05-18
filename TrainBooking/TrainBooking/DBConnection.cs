using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public class DBConnection
    {
        public SqlConnection ConnectToDatabase()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TrainBooking.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connection to DB is successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to DB is failed: " + ex.Message);
            }
            return connection;
        }
    }
}
