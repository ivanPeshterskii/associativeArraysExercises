using System;
using System.Collections.Generic;
using System.Linq;
using Orders;

namespace Orders;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string input = string.Empty;

        while((input = Console.ReadLine()) != "buy")
        {
            string[] info = input.Split().ToArray();

            string name = info[0];
            decimal price = decimal.Parse(info[1]);
            int quantity = int.Parse(info[2]);

            if (!products.ContainsKey(name))
            {
                products[name] = new Product { Price = price, Quantity = quantity };
            }
            else
            {
                products[name].Quantity += quantity;
                products[name].Price = price;
            }
        }

        foreach (KeyValuePair<string,Product> keyValuePair in products)
        {
            decimal totalPrice = keyValuePair.Value.Price * keyValuePair.Value.Quantity;
            Console.WriteLine($"{keyValuePair.Key} -> {totalPrice:f2}");
        }
    }
}