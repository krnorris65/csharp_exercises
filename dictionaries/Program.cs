using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Dictionaries: Exercise 3");

            // dictionary of stocks
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("FB", "Facebook");
            stocks.Add("TWTR", "Twitter");
            stocks.Add("AMZN", "Amazon");


            // stock purchases
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            
            purchases.Add((ticker: "CAT", shares: 90, price: 155.00));
            purchases.Add((ticker: "CAT", shares: 8, price: 159.16));
            purchases.Add((ticker: "CAT", shares: 17, price: 160.05));
            
            purchases.Add((ticker: "FB", shares: 100, price: 184.81));
            purchases.Add((ticker: "FB", shares: 18, price: 185.60));
            purchases.Add((ticker: "FB", shares: 127, price: 185.53));
            
            purchases.Add((ticker: "TWTR", shares: 20, price: 24.05));
            purchases.Add((ticker: "TWTR", shares: 48, price: 23.88));
            purchases.Add((ticker: "TWTR", shares: 168, price: 23.30));
            
            purchases.Add((ticker: "AMZN", shares: 5, price: 1209.16));
            purchases.Add((ticker: "AMZN", shares: 30, price: 1207.73));
            purchases.Add((ticker: "AMZN", shares: 88, price: 1210.30));

            //dictionary of total ownership of stocks
            Dictionary<string, double> ownership = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // gets full company name of the ticker
                string company = stocks[purchase.ticker];
                //value of the current stock purchased
                double addedValue = purchase.shares*purchase.price;

                // Does the company name key already exist in the report dictionary?
                if(!ownership.ContainsKey(company)){
                    // If not, add the new key and set its value
                    ownership.Add(company, addedValue); 

                } else {
                    // If it does, update the total valuation
                    ownership[company] += addedValue;
                };
            }

            //writes the totatl ownership report to the console
            foreach (KeyValuePair<string, double> company in ownership) {
                Console.WriteLine("{1}: valuation ${0:f2}", company.Value, company.Key);
            }

        }
    }
}
