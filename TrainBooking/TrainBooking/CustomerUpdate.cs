using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
            this.Load += CustomerUpdate_Load; // Add the event handler to the Load event
        }

        private void CustomerUpdate_Load(object sender, EventArgs e) {
            // Your code to retrieve and assign values to textboxes
            int cID = Customer.cus.CustomerID;
            string cName = Customer.cus.Name;
            string cEmail = Customer.cus.Email;
            string cPassword = Customer.cus.Password;

            ID.Text = cID.ToString();
            this.name.Text = cName;
            Email.Text = cEmail;
            Password.Text = cPassword;

            ID.Enabled = false;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            UserAuthentication login = new UserAuthentication();

            string name = this.name.Text;
            string email = Email.Text;
            string password = Password.Text;
            int cID = Customer.cus.CustomerID;
            
            login.updateCustomer(connection, cID, name, email, password);
            Customer.cus.UpdateDetails(name, email, password);
            MessageBox.Show("Updated!")
        }
    }
}
