using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> parking = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string userName = command[1];
            
            string keyWord = command[0];

            switch (keyWord)
            {
                case "register":
                    string licensePlateNumber = command[2];
                    Register(userName,licensePlateNumber,parking);
                    break;

                case "unregister":
                    
                    Unregister(userName, parking);
                    break;
            }
        }

        foreach (KeyValuePair<string,string> kvp in parking)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }

        static void Register(string username, string licensePlateNumber, Dictionary<string,string> parking)
        {
            if (!parking.ContainsKey(username))
            {
                parking[username] = licensePlateNumber;
                Console.WriteLine($"{username} registered {parking[username]} successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
        }

        static void Unregister(string username, Dictionary<string, string> parking)
        {
            if (parking.ContainsKey(username) == false)
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                parking.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
        }
    }
}