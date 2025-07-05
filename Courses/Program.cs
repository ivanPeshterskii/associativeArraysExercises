using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        string input = string.Empty;

        while ((input = Console.ReadLine())!= "end")
        {
            string[] array = input
                .Split(" : ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string courseName = array[0];
            string studentName = array[1];

            if (!courses.ContainsKey(courseName))
            {
                courses[courseName] = new List<string>();
            }
            courses[courseName].Add(studentName);
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");

            foreach (var student in course.Value)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}