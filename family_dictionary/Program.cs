using System;
using System.Collections.Generic;
using System.Linq;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Family Dictionary");

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Jimmy"},
                {"age", "25"}
            });
            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Margaret"},
                {"age", "64"}
            });
            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Jim"},
                {"age", "62"}
            });
            myFamily.Add("dog", new Dictionary<string, string>(){
                {"name", "Raleigh"},
                {"age", "3"}
            });


            foreach(KeyValuePair<string, Dictionary<string, string>> role in myFamily){

                var pName = role.Value.Where(p => p.Key == "name").Select(p => p.Value).Single();
                
                var pAge = role.Value.Where(p => p.Key == "age").Select(p => p.Value).Single();
                                
                Console.WriteLine($"{pName} is my {role.Key} and is {pAge} years old");
            }
           

        }
    }
}
