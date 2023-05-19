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
    public partial class CustomerHomeForm : Form
    {
        public CustomerHomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingForm homeCustomer = new BookingForm();
            homeCustomer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerUpdate customerUpdate = new CustomerUpdate();
            customerUpdate.ShowDialog();
        }
    }
}
