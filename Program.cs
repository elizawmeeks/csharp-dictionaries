using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yay Eliza!");

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GE", "General Electric");
            stocks.Add("CAB", "Cabela's Inc");
            
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "GM", shares: 15, price: 11.54));
            purchases.Add((ticker: "GM", shares: 240, price: 23.44));
            purchases.Add((ticker: "CAT", shares: 53, price: 5.66));
            purchases.Add((ticker: "CAB", shares: 16, price: 23.16));
            purchases.Add((ticker: "CAB", shares: 143, price: 26.17));
            
            /* 
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */
            
            Dictionary<string, double> aggroPurchase = new Dictionary<string, double>();

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                string currentKey = stocks[purchase.ticker];
                if (aggroPurchase.ContainsKey(currentKey)){
                    aggroPurchase[currentKey] = aggroPurchase[currentKey] + purchase.price;
                    Console.WriteLine($"{currentKey} total value is {aggroPurchase[currentKey]:C}");
                } else {
                    aggroPurchase.Add(currentKey, purchase.price);
                    Console.WriteLine($"{currentKey} total value is {aggroPurchase[currentKey]:C}");
                }

                // If it does, update the total valuation

                // If not, add the new key and set its value
            }
        }
    }
}
