using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainBooking
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new HomeForm());*/
<<<<<<< HEAD
            Application.Run(new BookingForm());
=======
            Application.Run(new HomeForm());
>>>>>>> 60d04b13f80c89c59020425addf4341f66f36eeb
        }
    }
}
