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

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // Call the ConnectToDatabase function to establish a connection to the database
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            UserAuthentication login = new UserAuthentication();
            string type = Type.Text;
            string email = Email.Text;
            string password = Password.Text;
            if (type == "Customer")
            {
                // Check if the email and password match the database
                if (login.customerCheckCredentials(connection, email, password))
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            else
            {
                // Check if the email and password match the database
                if (login.adminCheckCredentials(connection, email, password))
                {
                    MessageBox.Show("Login successful!");
                    AdminPage adminPage = new AdminPage();
                    adminPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!");
                }
            }
            // Close the database connection
            connection.Close();
        }

    }
}
