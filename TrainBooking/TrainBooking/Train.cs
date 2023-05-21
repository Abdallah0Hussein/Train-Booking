using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public class Train
    {

        private int TrainID;
        private string TrainName;
        private string TrainStatus;
        private int Capacity;


        public Train(int trainID, string trainName, string trainStatus, int capacity)
        {
            TrainID = trainID;
            TrainName = trainName;
            TrainStatus = trainStatus;
            Capacity = capacity;
        }

    }

}


