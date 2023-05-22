using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    public partial class ShowTripsFrom : Form
    {
        public ShowTripsFrom()
        {
            InitializeComponent();
        }

        private void ShowTripsFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainBookingDataSet1.Train' table. You can move, or remove it, as needed.
            this.trainTableAdapter.Fill(this.trainBookingDataSet1.Train);
            // TODO: This line of code loads data into the 'trainBookingDataSet1.Trip' table. You can move, or remove it, as needed.
            this.tripTableAdapter.Fill(this.trainBookingDataSet1.Trip);

        }

    }
}
