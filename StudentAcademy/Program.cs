using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string student = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(student))
            {
                students[student] = new List<double>();
            }
            students[student].Add(grade);
        }
        foreach (KeyValuePair<string,List<double>>student in students)
        {
            if (student.Value.Average() >= 4.50)
            {
                Console.WriteLine($"{student.Key} –> {(student.Value.Average()):f2}");
            }
        }
    }
}