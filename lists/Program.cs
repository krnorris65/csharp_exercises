using System;
using System.Collections.Generic;


namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            foreach( string planet in planetList) {
                Console.WriteLine(planet);
            }

            List<Dictionary<string, List<string>>> spacecraft = new List<Dictionary<string, List<string>>>();

            string mariner = "Mariner 10";
            List<string> marinerDestinations = new List<string>{"Mercury"};
            Dictionary<string, List<string>> mariner10 = new Dictionary<string, List<string>>();

            mariner10.Add(mariner, marinerDestinations);


            // Create Voyager 1 info
            string voyager1 = "Voyager 1";
            List<string> voyager1Destinations = new List<string>{
                "Jupiter", "Saturn"
            };
            Dictionary<string, List<string>> voyager1Dict = new Dictionary<string, List<string>>();
            voyager1Dict.Add(voyager1, voyager1Destinations);


            // Create Voyager 2 info
            string voyager2 = "Voyager 2";
            List<string> voyager2Destinations = new List<string>{
                "Jupiter", "Saturn", "Uranus", "Neptune"
            };
            Dictionary<string, List<string>> voyager2Dict = new Dictionary<string, List<string>>();
            voyager2Dict.Add(voyager2, voyager1Destinations);


            // Add all dictionaries to spacecraft collection
            spacecraft.Add(mariner10);
            spacecraft.Add(voyager1Dict);
            spacecraft.Add(voyager2Dict);

            foreach(string planet in planetList) {
                // writes planets to the console
                Console.Write(planet);
                
                List<string> visitedPlanets = new List<string>();

                // iterate over each spacecraft 
                foreach (Dictionary<string, List<string>> craft in spacecraft)
                {
                    // iterate over each of the planets that the spacecraft visited
                    foreach (KeyValuePair<string, List<string>> item in craft)
                    {
                        // if the spacecraft went to the current planet add it to visited planets
                        if(item.Value.Contains(planet)) {
                            visitedPlanets.Add(item.Key);
                        }

                    }

                }

                // write all the spacecrafts that visited each planet after the name of that planet
                visitedPlanets.ForEach(p => Console.Write($" {p}"));
                
                // makes a new line for each planet/spacecraft list
                Console.WriteLine();
            }


        }
    }
}
