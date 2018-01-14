using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            Air glider = new Air(){
                Type = "Glider",
                Wheels = 2,
                Doors = 1,
                PassengerCapacity = 2,
                Winged = true,
                EngineVolume = 20,
                MaxAirSpeed = 120
            };

            Air cessna = new Air(){
                Type = "Cessna",
                Wheels = 3,
                Doors = 3,
                PassengerCapacity = 113,
                Winged = true,
                EngineVolume = 31.1,
                MaxAirSpeed = 309.0
            };

            List<Air> airVehicles = new List<Air>(){
                glider,
                cessna
            };

            // With a single `foreach`, have each vehicle Fly()
            foreach(Air vehicle in airVehicles){
                vehicle.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            Ground car = new Ground(){
                Type = "Car",
                Wheels = 4,
                Doors = 4,
                PassengerCapacity = 5,
                TransmissionType = "Automatic",
                EngineVolume = 2.5,
                MaxLandSpeed = 250
            };

            Ground motorcycle = new Ground(){
                Type = "Motorcycle",
                Wheels = 2,
                Doors = 0,
                PassengerCapacity = 2,
                TransmissionType = "Manual",
                EngineVolume = 1.3,
                MaxLandSpeed = 160.4
            };

            List<Ground> groundVehicles = new List<Ground>(){
                car,
                motorcycle
            };
    
            // With a single `foreach`, have each road vehicle Drive()
            foreach(Ground vehicle in groundVehicles){
                vehicle.Drive();
            }


            // Build a collection of all vehicles that operate on water
            Water jetski = new Water(){
                Type="Jetski" ,
                Doors = 0,
                PassengerCapacity = 2,
                EngineVolume = 1.5,
                TransmissionType = "Belt",
                MaxWaterSpeed = 70
            };

            Water boat = new Water(){
                Type="Boat",
                Doors = 0,
                PassengerCapacity = 8,
                EngineVolume = 1.8,
                TransmissionType = "Marine",
                MaxWaterSpeed = 200
            };

            List<Water> waterVehicles = new List<Water>(){
            jetski,
            boat
            };

            // With a single `foreach`, have each water vehicle Drive()
            foreach(Water vehicle in waterVehicles){
                vehicle.Drive();
            }
            
            Console.WriteLine("Interfaces");
        }
    }
}
