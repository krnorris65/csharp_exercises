using System;
using System.Collections.Generic;
using System.Linq;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            // Create a list
            Byte[] b = new Byte[20];
            random.NextBytes(b);

            List<int> ranList = new List<int>();

            for (int i = 0; i <= b.GetUpperBound(0); i++){
                ranList.Add(b[i]);
            }

            List<int> squaredNum = new List<int>();

            foreach(int n in ranList) {
                squaredNum.Add(n*n);
            }

            //remove even numbers from the squaredNum list
            // create a list of the odd numbers then iterate through that list an remove each odd number from the squaredNum list
            List<int> oddNums = squaredNum.Where(n => n % 2 == 1).ToList();

            foreach(int n in oddNums) {
                squaredNum.Remove(n);
            }

            //OR from the beginning only add even squared numbers to the squaredNum list by adding a conditional statement with in the foreach
            // foreach(int n in ranList) {
            //     if((n*n) % 2 == 0) {
            //         squaredNum.Add(n*n);
            //     }
            // }

            // Populate the list
            Console.WriteLine("Squared Randoms");
        }
    }
}
