using System;
using System.Collections.Generic;
using System.Linq; ///StreamAPI bên JAVA(Lambda Expression)
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    internal class Student
    {
        private string _id; //đặc điểm, field, state, biến đb
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa) 
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public string GetID() => _id;

        public string GetName() 
        {
            return _name;
        }

        public int GetYob() 
        {
            return _yob;
        }

        public double GetGgpa() => _gpa; //expressionbody/bodied
        //khi hàm có 1 câu lệnh duy nhất

        // HÀM THAY ĐỔI - THẤY THẰNG BẠN CÓ GÌ, MÌNH CHỈNH SỬA SET()
        // SETTER() 

        public void SetName(string name) 
        {
            _name = name;
        }

        public void SetYob(int yob)
        {
            _yob = yob;
        }

        public void SetGpa(double gpa) => _gpa = gpa;

        //Hàm flex nhiều info hơn
        public void ShowInfo()
        {
            //show theo style
            Console.WriteLine("My profile:");
            Console.WriteLine($"ID: {_id}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Yob: {_yob}");
            Console.WriteLine(@$"GPA: {_gpa}"); //dư @ vì ko in gì đặc biệt

        }

        //hành động chuẩn hoá của mọi object
        //với lập trình object show hết gọi là ToString() toString()
        //HÀM JAVA: verb + Object theo con Lạc Đà()
        //HÀM C#: Verb + Object theo con Passcal()

        public override string ToString() => $"ID: {_id} | Name: {_name} |  YOB: {_yob} | Gpa: {_gpa}";
        

    }
}
//Class là 1 tên gọi chung, danh từ chung gọi cho sự phân nhóm,
//phân loại/ classify 1 đám object có điểm tương đônhf: về đặc điểm và hành vi
// - Đặc điểm: id, name, yob, place of birth, address, major, gpa
// - Hành vi: DoQuiz(), DoFinalEx(),...
// Các bạn A B C D thuộc nhóm student
//                              ID: ______
//                            Name: ______
//CLass ~ khuôn - Mold, Template, Blue-print
//Chỉ cần chờ đổ info vào ra 1 cái gì đso cụ thể - OBJECT
//LÀM CÁI FORM//
//LẬP TRÌNH OOP - OBJECT ORIENTED PROGRAMING
//1 OBJECT Ở TRÊN SẼ NHÌN THEO 2 KHÍA CANH
//1. ĐẶC ĐIỂM (TĨNH - STATE)
// ID, GAME, YOB, GPA,...
//2. HÀNH VI (ĐỘNG - BEHAVIOUR)
// DoPresentation()

//THIẾT KẾ OOP:
//1. NHẬN DIỆN RA CÁC OBJECT, VÍ DỤ 30 BẠN QUANH TUI
//2. CHIA NHÍM, TÌM NHÓM OBJECT THEO ĐẶC ĐIỂM CHUNG
//3. TẠO DÀN KHUNG
//4. TẠO CONSTRUCTOR
//5. OBJECT XONG, ĐIỀN BÚT VÀO, XONG
//6. ĐÚC OBJECT TRỞ LẠI TỪ CÁI KHUÔN, CÁI FORM
// -CLONE CÁI FORM TRƯỚC ĐÃ 
// -ĐỔ DỮ LIỆU VÀO