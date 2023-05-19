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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace TrainBooking
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void Sign_upButton_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            UserAuthentication signup = new UserAuthentication();

            string type = Type.Text;
            string name = this.name.Text;
            string email = Email.Text;
            string password = Password.Text;
            if (type == "Customer")
            {
                signup.customerRegister(connection, name, email, password);
                MessageBox.Show("Signup is successful!");
            }
            else
            {
                signup.adminRegister(connection, name, email, password);
                MessageBox.Show("Signup is successful!");
            }
            connection.Close();
        }

    }
}
/*string type = Type.Text;
string name = Name.Text;
string email = Email.Text;
string password = Password.Text;
if (type == "Customer")
{
    signup.customerRegister(connection, name, email, password);
    MessageBox.Show("Signup is successful!");
}
else
{
    signup.adminRegister(connection, name, email, password);
    MessageBox.Show("Signup is successful!");
}*/