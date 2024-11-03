using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entities
{
    public class Lecturer
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private int Yob { get; set; }

        private double Salary { get; set; }

        public override string? ToString()
            => $"{Id} {Name} {Yob} {Salary} ";
        
    }
}
