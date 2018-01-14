using System;

namespace vehicles
{
    public class Air : Vehicle, IAirVehicle
    {
        // public string Type { get; set;}
        public int Wheels { get; set; }
        // public int Doors { get; set; }
        // public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        // public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }


        public override void Drive()
        {
            Console.WriteLine($"The {this.Type} is making its way to the runway");
        }

        public void Fly()
        {
            Console.WriteLine($"The {this.Type} effortlessly glides through the sky");
        }

        public override void Start()
        {
            Console.WriteLine($"The {this.Type} is ready to fly");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {this.Type} has landed");
        }
    }
}