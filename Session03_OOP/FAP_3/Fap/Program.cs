using Fap.Entities;
using System;
namespace Fap
{
    internal class Program
    {
        //svm
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1", "An", 2000, 3.5);          
            Console.WriteLine("AN: " + s1); //GỌI THẦM TÊN EM
            //BÊN C THÌ IN RA ĐỊA CHỈ CỦA OBJECT
            //BÊN JAVA, C# ĐI GỌI HÀM ToString() 
        }


        //static void Main(string[] args)
        //{
        //    //tạo mới object, đem khuôn ra đúc
        //    //đổ vật liệu vào khuôn
        //    //CaSi hieuThuHai = new CaSi(.....);
        //    Student s1 = new Student("SE1", "An", 2000, 3.5);
        //    s1.PrintInfo();

        //    //style 2
        //    Student s2 = new ("SE2", "Bình", 2001, 3.6);
        //    s2.PrintInfo();

        //    //style 3
        //    var s3 = new Student("SE3", "Châu", 2002, 3.7);
        //    s3.PrintInfo();

        //    //style 4
        //    var s6 = new Student(name: "Hà", id: "SE6", gpa: 4.0, yob: 2004); //named-argument: kĩ thuật truyền data vào hàm ko theo thứ tự
        //    s6.PrintInfo();

        //    //style 5
        //    var s4 = new Student("SE4", "Dũng", 2003, 3.8);
        //    s4.PrintInfo();
        //    var s5 = s4;
        //    s5.PrintInfo();
        //    Console.WriteLine("after change");

        //    // change value of name
        //    s4.SetName("Đạt");
        //    s5.PrintInfo();

        //    s1 = s2; //garbage collector gom vùng ram mà biến an trỏ 


        //    s5 = s1;
        //    s5.PrintInfo(); 

        //    //tui mún biết tên của bạn an
        //    Console.WriteLine(s1.GetName());
        //    Console.WriteLine("AN's name: {0}", s1.GetName());

        //    //HÀM SET() là hàm giúp ta tinh chỉnh, chỉnh sửa độ lại customer 1 object đã được tạo ra
        //    //ví dụ: tui mún đổi tên của bạn An thành Anh 
        //    //TA CẦN (PARAMETER, ĐẦU VÀO)
        //    // ĐÈ TÊN MỚI

        //    //void F(in Student s)
        //    //{
        //    //    s = new Student("SE7", "Hải", 2005, 3.9);
        //    //}
        //    CheckInParam(s1);
        //    s1.PrintInfo();


        //}

        static void CheckInParam(in Student s)
        {
            s.SetName("Dat");
            //s = new Student("SE7", "Hải", 2005, 3.9);

        }
    }
}
