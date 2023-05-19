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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AddTrainLink_Click(object sender, EventArgs e)
        {
            AddTrainForm AddTrainForm = new AddTrainForm();
            AddTrainForm.ShowDialog();
        }

        private void AddTripLink_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateTrainLink_Click(object sender, EventArgs e)
        {
            UpdateTrainForm1 updateTrainForm = new UpdateTrainForm1();
            updateTrainForm.ShowDialog();
        }

        private void UpdateTripLink_Click(object sender, EventArgs e)
        {

        }
    }
}
