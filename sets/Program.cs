using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashsets");

            HashSet<string> Showroom = new HashSet<string>();

            Showroom.Add("Fit");
            Showroom.Add("Accord");
            Showroom.Add("RAM");
            Showroom.Add("Mountaineer");
            

            Console.WriteLine("Cars in showroom: " + Showroom.Count);

            Showroom.Add("Fit");

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Civic");
            UsedLot.Add("CR-V");

            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Mountaineer");

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Fit");
            Junkyard.Add("Range Rover");
            Junkyard.Add("Jeep");
            Junkyard.Add("Civic");

            // Junkyard.IntersectWith(Showroom);

            Showroom.UnionWith(Junkyard);

            Showroom.Remove("Jeep");

            foreach(string c in Junkyard){
                Console.WriteLine("ShowJunk " + c);
            }




        }
    }
}
