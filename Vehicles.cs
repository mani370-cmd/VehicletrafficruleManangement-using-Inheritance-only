using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Management
{
    public class Vehicles
    {
        public string Motortype { get; set; }
        public string Vehiclemodel { get; set; }
        public string Speed  { get; set; }
        // Constructor to initialize the vehicle properties
        public Vehicles(string motortype,string vehiclemodel,string speed)
        {
            Motortype = motortype;
            Vehiclemodel = vehiclemodel;
            Speed = speed;
        }
        // Method to display vehicle information
        public void DisplayInfo()
        {
            Console.WriteLine($"Motor Type: {Motortype},VehicleModel:{Vehiclemodel},Speed: {Speed}");
           
        }
    }
}
