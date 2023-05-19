using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            if (depatureT >= arrivalT){
                Depature_Arrival.SetError(DepatureTime, "Depature Date must be lower than Arrival Time");
                MessageBox.Show("Depature Date must be lower than Arrival Time");
            } else{
                Depature_Arrival.Clear();
            }

            if (srcName == destName) {
                SrcEqDest.SetError(SrcStation, "Source Station Cannot be the same as Destination Station");
                MessageBox.Show("Source Station Cannot be the same as Destination Station");
            } else {
                SrcEqDest.Clear();
            }
            

            Trip trip = new Trip(depatureT, arrivalT);
            if (!trip.setDriverID(driverID))
            {

            } else { 

            }

            if (!trip.setTrainID(trainID))
            {

            } else { 

            }

            Admin admin = new Admin();
        }
    }
}
