using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class LecturerService
    {
        private Lecturer[] _arr;

        public LecturerService(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Invalid size, Size must be greater than 1");

            _arr = new Lecturer[size];
            int _count = 0;
        }

        public void Add(Lecturer lecturer)
        {
            Console.WriteLine("Add lecturer");
        }

       

        public void PrintLecturerList()
        {
            int _count = 0;
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        //Update theo string  
       
    }
}
