using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fap.Entities
{
    public class Student
    {
        private string _id;    //id   :________
        private string _name;  //name :________
        private int _yob;      //yob  :________
        private double _gpa;   //gpa  :________

        //CODE CONTRUCTOR GET SET 100% GIỐNG JAVA
        //TUY NHIÊN TA SẼ HỌC THÊM CẢ ĐIỀU KHÁC BIỆT
        //class như cái form, cái khuôn, BLUE-PRINT để từ đó ta CLONE INFO vào
        //để có được 1 object cụ thể

        //CONSTRUCTOR: Hàm đặt biệt đóng vai trò cái phễu hứng vật liệu đầu vào
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //các hàm còn lại của object, 100% java
        //GET() SET() ToString()
        public void PrintInfo() => Console.WriteLine($"ID: {_id} | Name: {_name} YOB: {_yob} GPA: {_gpa}");

        //@Override
        //OOP Java: class CHa Object có 1 hàm toString() làm nhiệm vụ
        //băm/hash/hasing cái vugf ram của object thành 1 dãy số hexa
        //NGỌC TRINH 
        //C#: hàm ToString() của class Cha Object lazy hơn 
        //    nó ko bằm vùng ram object thành hexa, mà nó returrn 
        //   Tên class mà object nó thuộc về
        public override string? ToString()        
             //return base.ToString();
               => $"ID: {_id} | Name: {_name} YOB: {_yob} GPA: {_gpa}";
            //super gọi Cha ToString() giúp
        

        public string GetId() => _id;
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => 2024 - _gpa; //hard-coded 2024, lấy năm hệ thống

        public void SetName(string name) => _name = name;

        //Vậy hàm Set() giống hay khác Constructor()
        //Giống về logic code: đề info bên trong bởi info bên ngoài
        //Khác cách dùng
        //Túm lại là Constructor để TẠO Object mới từ đó CLONE INFO vào
        //Set() để chỉnh sửa, tinh chỉnh, chỉnh sửa lại info của 1 object đã được tạo ra

       



    }
}

//QUY TẮC VIẾT CODE -- CODING CONVENTION
//I.  QUY TẮC ĐẶT TÊN SOLUTION
//II. QUY TẮC ĐẶT TÊN PROJECT
//III.QUY TẮC ĐẶT TÊN NAMESPACE
//IV. QUY TẮC ĐẶT TÊN CLASS, INTERFACE, DELEGATE

//1. QUY TẮC ĐẶT TÊN CLASS
//- Danh từ, Chữ hoa đầu từ: Student, Car, Person, Employee,... (Pascal Case)

//V.  QUY TẮC ĐẶT TÊN BIẾN - VARIABLE
// 1. FIELDS (BIẾN NẰM NGOÀI HÀM, MÔ TẨ ĐẶC TÍNH CỦA CLASS/OBJECT)
// ATTRIBUTE, INSTANCE VARIABLE, CLASS VARIABLE
// - Danh từ, chữ thường, từ đầu tiên viết thường, từ thứ 2 viết hoa: _id, _basicSalary, _yob, _yearOfBirth


// 2. BIẾN TRONG HÀM, BIẾN CỤC BỘ - LOCAL VARIABLE
// - Danh từ, chữ thường, từ đầu tiên viết thường, từ thứ 2 viết hoa: id, basicSalary, yob, yearOfBirth

//VI.  QUY TẮC ĐẶT TÊN HÀM - METHOD
// - Động từ hoặc cụm động từ, chữ hoa đầu từ: PrintInfo(), GetInfo(), SetInfo(), CalculateSalary(),...
