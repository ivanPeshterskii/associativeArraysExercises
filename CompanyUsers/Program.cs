using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> employee = new Dictionary<string, List<string>>();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] array = input
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            string companyName = array[0];
            string id = array[1];

            if (!employee.ContainsKey(companyName))
            {
                employee[companyName] = new List<string>();
            }
            if (!employee[companyName].Contains(id))
            {
                employee[companyName].Add(id);
            }
        }
        foreach (var item in employee)
        {
            Console.WriteLine($"{item.Key}");
            foreach (var id in item.Value)
            {
                Console.WriteLine($"-- {id}");
            }
        }
    }
}