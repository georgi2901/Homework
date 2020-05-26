using System;
using System.Collections.Generic;
using System.Text;

namespace Eligible
{
    class Student
    {
        public string Discipline { get; set; }
        public string Name { get; set; }
        public string Fn { get; set; }
        public double Mark { get; set; }

        public Student(string name, string discipline, string fn, double mark)
        {
            Discipline = discipline;
            Name = name;
            Fn = fn;
            Mark = mark;
        }

        public override string ToString()
        {
            return Name + " " + Discipline + " " + Mark;
        }
    }
}
