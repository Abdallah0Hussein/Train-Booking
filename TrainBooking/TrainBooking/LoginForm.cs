using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the ConnectToDatabase function to establish a connection to the database
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            UserAuthentication login = new UserAuthentication();
            string email = textBox1.Text;
            string password = textBox2.Text;
            // Check if the email and password match the database
            if (login.CheckCredentials(connection, email, password))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
            // Close the database connection
            connection.Close();
        }
    }
}
