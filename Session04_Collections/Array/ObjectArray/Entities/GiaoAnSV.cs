using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray.Entities
{
    public class GiaoAnSV
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public GiaoAnSV()
        {
            
        }

        public GiaoAnSV(string id, string name, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Gpa= gpa;
        }

        public override string? ToString()
        => "Id:" + Id;
    }
}
