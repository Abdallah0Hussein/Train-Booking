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

        public bool setTrainID(int ID)
        {
            DBConnection conn = new DBConnection();
            SqlConnection connection = conn.ConnectToDatabase();
            SqlCommand command = new SqlCommand($"SELECT Count(TrainID) FROM Train WHERE TrainID = {ID}", connection);

            int isExist = (int)command.ExecuteScalar();
            TrainID = ID;
            return isExist == 1;
        }


    }
}
