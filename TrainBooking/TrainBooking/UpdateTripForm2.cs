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
    public partial class UpdateTripForm2 : Form
    {
        public UpdateTripForm2()
        {
            InitializeComponent();
        }

        private void UpdateTrip_Click(object sender, EventArgs e)
        {
            int tripID = UpdateTripForm1.instance.tripID;
            int trainID = (int)TrainID.Value;
            int driverID = (int)DriverID.Value;
            DateTime depatureT = DepatureTime.Value;
            DateTime arrivalT = ArrivalTime.Value;
            string srcName = SrcStation.Text;
            string destName = DestStation.Text;
        }

    }
}
