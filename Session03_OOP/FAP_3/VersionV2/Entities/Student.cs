using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionV2.Entities
{
    public class Student
    {
        private string _id;    // default là rỗng
        private string _name;  // default là 0
        private int _yob;      // 
        private double _gpa;   //...........

        //public Student() //cst rỗng, cst defalt                   
        //{               // ko nhần gì vào, không có lệnh
        //}               //object mang giá trị default
        //Nếu class ko có cst rỗng, thì khi tạo mới object lúc runtime - implicit - ẩn mình
        //nếu đã có cst có tham số, thì runtime ko tạo cst nữa
        //CTOR TAB
        public Student()
        {
        }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string? ToString()
            => $"ID: {_id} | Name: {_name} YOB: {_yob} GPA: {_gpa}";
        //một class có vô số cst
        // có bao nhiêu cst có bấy nhiêu cách new 

        //ĐOẠN CODE DƯỚI ĐÂY LÀ GET VÀ SET TRÊN CÁC ĐẶT TÍNH CỦA OBJECT MANG Ý NGHĨA
        //1. CUNG CẤP THÔNG TIN CỦA OBJECT CHO BÊN NGOÀI GET() ->
        //2. CHỈNH SỬA THÔNG TIN OBJECT SET(?) <-
        //LÝ THUYẾT class có N ĐẶC TÍNH -> N x 2 hàm GET SET
        //lặp đi lặp lại cho mọi class -- boiler plate
        //CHÁN

        public string GetId() => _id;
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;

        //HÀM SET() LÀ VOID CẦN 1 VALUE ĐƯA VÀO ĐỂ ĐÈ VÀO BÊN TRONG OBJECT
        public void SetId(string id) => _id = id;
        public void SetName(string name) => _name = name;
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;






    }
}
