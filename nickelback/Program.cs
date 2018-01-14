using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kill Nickelback");

            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();
            allSongs.Add(("Nickelback", "Photograph"));
            allSongs.Add(("Nickelback", "Someday"));
            allSongs.Add(("Nickelback", "Rockstar"));
            allSongs.Add(("Hanson", "Penny and Me"));
            allSongs.Add(("Melodime", "Reasons"));
            allSongs.Add(("Hanson", "Great Divide"));
            allSongs.Add(("Walk The Moon", "One Foot"));

            foreach((string, string) song in allSongs){
                if(!song.Item1.Contains("Nickelback")){
                    goodSongs.Add(song);
                }
            }

            foreach((string, string) good in goodSongs){
                Console.WriteLine($"{good.Item2} by {good.Item1}");
            }

        }
    }
}
