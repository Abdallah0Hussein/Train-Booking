using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainBooking
{
    public class Train
    {
<<<<<<< Updated upstream
        public int TrainID;
        public string TrainName;
        public string TrainStatus;
        public int Capacity;
=======
        private int TrainID;
        private string TrainName;
        private string TrainStatus;
        private int Capacity;
>>>>>>> Stashed changes

        public Train(int trainID, string trainName, string trainStatus, int capacity)
        {
            TrainID = trainID;
            TrainName = trainName;
            TrainStatus = trainStatus;
            Capacity = capacity;
        }

    }
<<<<<<< Updated upstream
}
=======

}

>>>>>>> Stashed changes
