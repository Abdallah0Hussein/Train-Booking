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
        public static int trainID = 0;
        public UpdateTrainForm1()
        {
            InitializeComponent();
        }

        private void SendTrainID_Click(object sender, EventArgs e)
        {
            trainID = (int) nTrainID.Value;


            UpdateTrainForm2 form2 = new UpdateTrainForm2();
            form2.ShowDialog();
        }
    }
}
