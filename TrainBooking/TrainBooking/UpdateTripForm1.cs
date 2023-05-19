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
    public partial class UpdateTripForm1 : Form
    {
        public static UpdateTripForm1 instance;
        public int tripID = 0;
        public UpdateTripForm1()
        {
            InitializeComponent();
            instance = this;
            tripID = (int)nTripID.Value;
        }

        private void SendTripID_Click(object sender, EventArgs e)
        {
            UpdateTripForm2 form2 = new UpdateTripForm2();
            form2.ShowDialog();
        }
    }
}
