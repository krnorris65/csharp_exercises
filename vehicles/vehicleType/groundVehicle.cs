using System;

namespace vehicles
{
    public class Ground : Vehicle, IGroundVehicle
    {
        // public string Type { get; set;}
        public int Wheels { get; set; }
        // public int Doors { get; set; }
        // public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        // public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {this.Type} drives down the winding road");
        }

        public override void Start()
        {
            Console.WriteLine($"The {this.Type} is ready to go");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stop driving the {this.Type}");
        }
    }
}