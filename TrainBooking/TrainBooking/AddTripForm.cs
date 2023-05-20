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
            DateTime departureT = DepartureTime.Value;
            DateTime arrivalT = ArrivalTime.Value;
            string srcName = SrcStation.Text;
            string destName = DestStation.Text;

            bool errFlag = false;

            if (departureT >= arrivalT){
                Depature_Arrival.SetError(DepartureTime, "Depature Date must be lower than Arrival Time");
                MessageBox.Show("Depature Date must be lower than Arrival Time");
                errFlag = true;
            } else {
                Depature_Arrival.Clear();
                errFlag = false;
            }

            if (srcName == destName) {
                SrcEqDest.SetError(SrcStation, "Source Station Cannot be the same as Destination Station");
                MessageBox.Show("Source Station Cannot be the same as Destination Station");
                errFlag = true;
            } else {
                SrcEqDest.Clear();
                errFlag = false;
            }
            

            Trip trip = new Trip(departureT, arrivalT);

            if (!trip.setTrainID(trainID))
            {
                TrainIDErr.SetError(TrainID, "This TrainID is not Exist, Try Another One.");
                MessageBox.Show("This TrainID is not Exist, Try Another One.");
                errFlag = true;
            } else { 
                TrainIDErr.Clear();
                errFlag = false;
            }

            if (!trip.setDriverID(driverID))
            {
                DriverIDErr.SetError(DriverID, "This DriverID is not Exist, Try Another One.");
                MessageBox.Show("This DriverID is not Exist, Try Another One.");
                errFlag = true;
            } else {
                DriverIDErr.Clear();
                errFlag = false;
            }
            
            if (!errFlag)
            {
                MessageBox.Show("hey");
                Admin admin = new Admin();
                admin.addTrip(trip, srcName, destName);
            }
        }
    }
}
