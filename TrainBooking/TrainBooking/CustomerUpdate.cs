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
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            UserAuthentication login = new UserAuthentication();
            string cName = Customer.cus.Name;
            string cEmail = Customer.cus.Email;
            string cPassword = Customer.cus.Password;
            /*this.name.Text = cName;
            Email.Text = cName;
            Password.Text = cName;*/
            string name = this.name.Text;
            string email = Email.Text;
            string password = Password.Text;
            int cID = Customer.cus.CustomerID;
            
            login.updateCustomer(connection, cID, name, email, password);
        }
    }
}
