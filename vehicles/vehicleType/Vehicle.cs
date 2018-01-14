using System;

namespace vehicles
{
    public class Vehicle
    {
        public string Type {get; set;} 
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public double EngineVolume { get; set; }
        
        public virtual void Drive() {
            Console.WriteLine($"Driving the {this.Type}");
        }
        public virtual void Start() {
            Console.WriteLine($"Starting the {this.Type}");

        }
        public virtual void Stop(){
            Console.WriteLine($"Stopping the {this.Type}");

        }
    }
}