using System;

namespace vehicles {
    public class Water : Vehicle, IWaterVehicle
    {
        // public string Type { get; set;}
        // public int Doors { get ; set; }
        // public int PassengerCapacity { get ; set ; }
        // public double EngineVolume { get ; set ; }
        public string TransmissionType { get ; set ; }
        public double MaxWaterSpeed { get ; set ; }

        public override void Drive()
        {
            Console.WriteLine($"The {this.Type} glides through the water");
        }

        public override void Start()
        {
            Console.WriteLine($"The {this.Type} is fired up and ready to go!");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stop driving the {this.Type}");
        }
    }
}