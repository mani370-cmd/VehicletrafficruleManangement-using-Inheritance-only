using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Management
{
    public class Government : Trafficpolice
    {
        public float Redsignalfine { get; set; }
        public float Yellowsignalfine { get; set; }
        public float Greensignalfine { get; set; }

        // Constructor to initialize the government properties  
        public Government(string motortype, string vehiclemodel, string speed, string redsignal, string yellowsignal, string greensignal, float fine, float redsignalfine, float yellowsignalfine, float greensignalfine)
            : base(motortype, vehiclemodel, speed, redsignal, yellowsignal, greensignal, fine)
        {
            Redsignalfine = redsignalfine;
            Yellowsignalfine = yellowsignalfine;
            Greensignalfine = greensignalfine;
        }

        // Method to display government vehicle information  
        public void DisplayGovernmentInfo()
        {
            Console.WriteLine($"Red Signal Fine: {Redsignalfine}, Yellow Signal Fine: {Yellowsignalfine}, Green Signal Fine: {Greensignalfine}");
        }
    }
}
