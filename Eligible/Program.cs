using System;
using System.Collections.Generic;
using System.Linq;

namespace Eligible
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> studentsDictionary = new Dictionary<string, string>();
            List<Student> students = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end") { break; }

                string[] data = input.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();
                double mark = Convert.ToDouble(data[3]);

                Student s = new Student(data[1], data[0], data[2], mark);

                try
                {
                    studentsDictionary.Add(s.Fn, s.Discipline);
                }
                catch (Exception)
                {
                    continue;
                }

                students.Add(s);
            }

            foreach (var student in students.OrderByDescending(x => x.Mark))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
