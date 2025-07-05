using System;
using System.Collections.Generic;

namespace Count_CharsnaString;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        Dictionary<char, int> countChars = new Dictionary<char, int>();

        foreach (char character in text)
        {
            if(character==' ')
            {
                continue;
            }
            if (countChars.ContainsKey(character))
            {
                countChars[character]++;
            }
            else
            {
                countChars[character] = 1; 
            }
        }

        foreach ((char character, int count) in countChars)
        {
            Console.WriteLine($"{character} -> {count}");
        }
    }
}