﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectList.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString()
            => $"Id: {Id}, Name: {Name}, Yob: {Yob}, Gpa: {Gpa}";
    }
}
