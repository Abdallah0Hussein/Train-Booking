using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TrainBooking
{
    public class Train
    {
        public int TrainID;
        public string TrainName;
        public string TrainStatus;
        public int Capacity;

        public Train(int trainID, string trainName, string trainStatus, int capacity)
        {
            TrainID = trainID;
            TrainName = trainName;
            TrainStatus = trainStatus;
            Capacity = capacity;
        }

    }
}