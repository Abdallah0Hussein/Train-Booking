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
    public partial class AddTripForm : Form
    {
        public AddTripForm()
        {
            InitializeComponent();
        }

        private void AddTrip_Click(object sender, EventArgs e)
        {
            int trainID = (int)TrainID.Value;
            int driverID = (int)DriverID.Value;
            DateTime depatureT = DepatureTime.Value;
            DateTime arrivalT = ArrivalTime.Value;
            string srcName = SrcStation.Text;
            string destName = DestStation.Text;
        }
    }
}
