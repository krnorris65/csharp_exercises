﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }
    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        public static double Sqrt(double d){
            return d;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 7");

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = from fruit in fruits
                where fruit.StartsWith("L")
                select fruit;


            // // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre" 
            };

            IEnumerable<string> descend = from name in names
                orderby name descending
                select name; 

            // Build a collection of the numbers sorted in ascending order (numbers list above)

            IEnumerable<int> ascending = from n in numbers
                orderby n ascending
                select n;

            // Output how many numbers are in this list (numbers list above)
            int counting = numbers.Count();

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double sumMoney = Math.Round(purchases.Sum(), 2);

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double highItem = prices.Max();

            //Store each number in the following List until a perfect squareis detected.
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            //returns all instances of perfect squares
            IEnumerable<int> perfectSquare = from n in wheresSquaredo
                where Math.Sqrt(n) % 1 == 0
                select n;

            //returns the first instance of a perfect square
            int perfectSquare2 = wheresSquaredo.Find(n => Math.Sqrt(n) % 1 == 0);

            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
                new Bank(){ Name="First Tennessee", Symbol="FTB"},
                new Bank(){ Name="Wells Fargo", Symbol="WF"},
                new Bank(){ Name="Bank of America", Symbol="BOA"},
                new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var millionBank = from c in customers 
                group c by c.Bank into b
                select new { Bank = b.Key, Customers = b.Count()};

            foreach(var b in millionBank){
                Console.WriteLine($"{b.Bank}: {b.Customers}");
            }

            
            var millionaireReport = from c in customers
                join b in banks on c.Bank equals b.Symbol into bn
                from b in bn
                select new {Name = c.Name, Bank = b.Name};

            foreach (var customer in millionaireReport)
            {
                Console.WriteLine($"{customer.Name} at {customer.Bank}");
            }


            Console.WriteLine("breakpoint");
        }
    }
}
