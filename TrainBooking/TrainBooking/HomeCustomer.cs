﻿using System;
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
    public partial class HomeCustomer : Form
    {
        public HomeCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingScreen homeCustomer = new BookingScreen();
            homeCustomer.ShowDialog();
        }
    }
}
