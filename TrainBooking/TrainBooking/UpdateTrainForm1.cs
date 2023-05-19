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
    public partial class UpdateTrainForm1 : Form
    {
        public static UpdateTrainForm1 instance;
        public String trainID;
        public UpdateTrainForm1()
        {
            InitializeComponent();
            instance = this;
            trainID = TrainID.Text;
        }

        private void SendTrainID_Click(object sender, EventArgs e)
        {
           // Want to check if TrainID is actual number && want to check whether its in the database or not
            UpdateTrainForm2 form2 = new UpdateTrainForm2();
            form2.ShowDialog();
        }
    }
}
