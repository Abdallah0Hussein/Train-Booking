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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            Signup signup = new Signup();
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            signup.Register(connection,name,email,password);
            MessageBox.Show("Signup is successful!");
        }
    }
}
