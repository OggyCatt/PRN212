using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version3.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //ctor rỗng
        public Student()
        {
        }

        //ctrt + "." để tạo constructor có tham số
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //GET/SET: NHÓM HÀM BOILER PLATE CODE
        //TA HỌC CƠ CHẾ HÀM LAI BIẾN, BIẾN LAI HÀM
        //TÊN BIẾN LÀ GET, BIẾN = value LÀ SET
        public string Id
        {
            get => _id;
            set => _id = value;
        }




    }
}
