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
    public partial class UpdateTrainForm2 : Form
    {
        public UpdateTrainForm2()
        {
            InitializeComponent();
        }

        private void UpdateTrain_Click(object sender, EventArgs e)
        {
            int trainID = UpdateTrainForm1.instance.trainID;
            string name = TrainName.Text;
            string status = TrainStatus.Text;
            // Want Validation if its really a number
            int capacity = Convert.ToInt32(TrainCapacity.Text);

            Admin admin = new Admin();
            admin.updateTrain(trainID, name, status, capacity);
        }
    }
}
