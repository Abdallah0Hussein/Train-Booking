using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TrainBooking
{
    public class Train
    {
        public int TrainID { get; private set; }
        public string TrainName { get; set; }
        public string TrainStatus { get; set; }
        public int Capacity { get; set; }

        public Train(int trainID, string trainName, string trainStatus, int capacity)
        {
            TrainID = trainID;
            TrainName = trainName;
            TrainStatus = trainStatus;
            Capacity = capacity;
        }
       
        }
}
