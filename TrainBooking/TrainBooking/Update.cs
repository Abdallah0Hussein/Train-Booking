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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Sign_upButton_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            UserAuthentication login = new UserAuthentication();
            string name = this.name.Text;
            string email = Email.Text;
            string password = Password.Text;
           
        }
    }
}
