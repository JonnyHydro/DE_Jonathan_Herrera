using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace VehicleSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Vehicle vehicle;
                Console.WriteLine("Type a vehicle: ");
                string opc = Console.ReadLine().ToLower();

                switch (opc)
                {
                    case "car":
                        vehicle = new Car();
                        vehicle.VehicleSounds();
                        break;
                    case "train":
                        vehicle = new Train();
                        vehicle.VehicleSounds();
                        break;
                    case "truck":
                        vehicle = new Truck();
                        vehicle.VehicleSounds();
                        break;
                    default:
                        Console.WriteLine("Vehicle not found");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }   
            }
        }
    }
}
