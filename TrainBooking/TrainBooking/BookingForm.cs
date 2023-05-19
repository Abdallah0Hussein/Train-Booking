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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void UpdateTrip_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();

            Bookingattribuits Bk = new Bookingattribuits();
            
            string trainID = TrainID.Text;
            string dest = DestStation.Text;
            string source = SrcStation.Text;
            DateTime dateTime = DateTime.Parse(DepatureTime.Text);
        }
    }
}
