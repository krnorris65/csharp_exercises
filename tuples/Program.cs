using System;
using System.Collections.Generic;
using System.Linq;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("Shoes", 5.99, 6));
            transactions.Add(("Shirts", 6.99, 5));
            transactions.Add(("Pants", 7.50, 2));
            transactions.Add(("Socks", 1.99, 10));
            transactions.Add(("Coats", 10.00, 1));
            transactions.Add(("Hats", 3.99, 8));

            // lists to add the number of items sold and the revenue from that item
            List<int> itemsSold = new List<int>();
            List<double> totalRevenue = new List<double>();

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                itemsSold.Add(t.quantity);
                totalRevenue.Add(t.amount);
            }

            //write to console
            Console.WriteLine($@"
            Items sold: {itemsSold.Sum()} 
            Total Revenue: {totalRevenue.Sum():f2}");

        }
    }
}
