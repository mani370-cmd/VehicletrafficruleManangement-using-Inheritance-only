using System;
using System.Security.Cryptography.X509Certificates;
using Vehicle_Management;

public partial class Program
{
    public static void Main(string[] args)
    {
        Vehicles bikeobj = new Vehicles("Yamaga", "MT15", "200 km/h");
        bikeobj.DisplayInfo();
        Trafficpolice trafficPoliceObj = new Trafficpolice("Yamaga", "MT15", "200 km/h", "Stop", "Ready", "Go",10000);
        trafficPoliceObj.DisplayTrafficPoliceInfo();
        Console.WriteLine("Traffic Signal to learn");
        trafficPoliceObj.DisplayTrafficSignalInfo();
        Console.WriteLine("Misused the rules you get fine");
        trafficPoliceObj.DisplayFineInfo();
        Government governmentObj = new Government("Yamaga", "MT15", "200 km/h", "Stop", "Ready", "Go", 10000, 5000, 3000, 1000);
        governmentObj.DisplayGovernmentInfo();
        Console.WriteLine("Government Vehicle rules  fine:");
        // End of the program
    }
}


