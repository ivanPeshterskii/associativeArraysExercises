using System;
using System.Collections.Generic;

namespace AMinerTask;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,long> resources = new Dictionary<string,long>();

        while (true)
        {
            string resource = Console.ReadLine();

            if (resource == "stop")
            {
                break;
            }

            long quantity = long.Parse(Console.ReadLine());

            if (resources.ContainsKey(resource))
            {
                resources[resource] += quantity;
            }
            else
            {
                resources[resource] = quantity;
            }
        }
        foreach (KeyValuePair<string,long> keyValuePair in resources)
        {
            Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
        }
    }
}