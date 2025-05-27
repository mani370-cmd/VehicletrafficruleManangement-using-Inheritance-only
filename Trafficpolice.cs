using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Management
{
    public class Trafficpolice : Vehicles, IFine
    {
        // Properties specific to traffic police vehicles
        public string Redsignal { get; set; }
        public string YellowSignal { get; set; }
        public string Greensignal { get; set; }
        public float Fine { get; set; }



        // Constructor to initialize the traffic police properties
        public Trafficpolice(string motortype, string vehiclemodel, string speed, string redsignal, string yellowsignal, string greensignal, float fine)
            : base(motortype, vehiclemodel, speed)


        {
            Redsignal = redsignal;
            YellowSignal = yellowsignal;
            Greensignal = greensignal;
            Fine = fine;
           

        }
        // Method to display traffic police information
        public void DisplayTrafficPoliceInfo()
        {
            Console.WriteLine($"Traffic Police Vehicle - Motor Type: {Motortype}, Vehicle Model: {Vehiclemodel}, Speed: {Speed}");
        }
        public void DisplayTrafficSignalInfo()
        {
            Console.WriteLine($"Traffic Signals - Red: {Redsignal}, Yellow: {YellowSignal}, Green: {Greensignal}");
        }
        public void DisplayFineInfo()
        {
            Console.WriteLine($"Fine Amount: {Fine}");
        }

    }
}

