namespace Nullable
{
    //TRONG KHUÔN VIÊN NAMESPACE BẠN CÓ THỂ TẠO NHIỀU
    //CLASS
    //INTERFACE
    //DELEGATE (BẢN CHẤT LÀ 1 CLASS, CLASS ĐẶC BIỆT, ĐẶC BIỆT HƠN INTERFACE)

    //CÁC CLASS/INTERFACE, CÓ THỂ TẠO LẺ, TẠO FILE RIÊNG, NHƯNG PHẢI KHAI BÁO
    //CÙNG NAMESPACE Ở ĐẦU TRANG --> OKIE KUOON, CÙNG 1 KHÁI NIỆM   
    //NAMESPACE LÀ 1 ĐẠI GIA ĐÌNH
    internal class Student
    {
        //QUY TẮC ĐẶT TÊN FEILD: danh từ + con Lạc Đà + từ đầu tiên chữ thường kèm Shift gạch - _underscore
        //
        private string _id;   //biến khai báo trong class
        private string _name; //thì được gọi là: feild, attribute
        private int _yob;     //instance variable(nếu ko có chữ static đi kèm)
        private double _gpa;  //class level vảiable(nếu có chữ static đi kèm)
                              //hàm (gọi là method) là đoạn code được đặt tên, xử lí các biến
                              //HÀM + FEILD ĐC GỌI CHUNG LÀ MEMBERS Ò A CLASS
                              //THÀNH PHẦN, THÀNH VIÊN CỦA CLASS
                              //BIẾN KHAI BÁO Ở THAM SỐ HÀM(CÓ THỂ XÀI THÊM IN OUT REF) 
                              //VÀ KHAI BÁO TRONG HÀM => GỌI CHUBNG LÀ LOCAL VARIABLE - BIẾN CỤC BỘ

        //constructor + method xử lí các biến/feild ở trên
        public Student(string id, string name, int yob, double gpa)
        {             //biến local theo cú pháp con Lạc Đà
            _id = id;
            _name = name;
            _yob = yob;
            this._gpa = gpa; //dư thừa, 
        }

        //show profile
        public void ShowProfile()
        {
            Console.WriteLine($"{_id} | {_name} | {_yob} | {_gpa}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateAStudentObject();
            PlayWithNullV1();
        }

        static void PlayWithNullV2()
        {
            Student s2 = null;
            //s2.ShowProfile; // run time error
            if(s2 == null)
                Console.WriteLine("s2 is null");
            else
                s2.ShowProfile();


        }
        static void PlayWithNullV1()
        {
            Student s1;     //XIN RAM, CHƯA CÓ VALUE
            //s1.ShowProfile(); //BIẾN MỚI KHAI BÁO, THÌ CHỈ LÀ XIN RAM, CHỨ CHƯA CÓ VALUE
            //JAVA VÀ C#: KHAI BÁO BIẾN, PHẢI GÁN VALUE MỚI ĐƯỢC DÙNG
            //C: KHAI BÁO BIẾN, KHÔNG CẦN GÁN VALUE, VẪN ĐƯỢC DÙNG

            //Student s2 = null; //XIN RAM, GÁN GIÁ TRỊ NULL, VÙNG RAM CÓ ĐƯỢC DỌN DẸP RỒI
            //LÚC NÀY BIẾN LƯU TOẠ ĐỘ CỦA TẦNG TRỆT -- TRỎ TẦNG 0 CỦA CAO ỐC RAM, TOÀN SỐ 0
            //s2.ShowProfile(); //LỖI RUNTIME: S2 = NULL NGHĨA LÀ BIẾN S2 TRỎ ĐÁY RAM, BYTE NULL
            //Ở ĐÂY KO CÓ CODE CỦA HÀM SHOWPROFILE(), SẼ BỊ BÁO LỖI THAM CHIẾU LỘN CHỖ KO CÓ CODE
            //khái niệm null đưa ra để giải quyết nhiều chuyện, chuyện phổ biến nhất là: 
            //DÙNG CHO HÀM SEARCH 1 OBJECT/SV NÀO ĐÓ
            //NẾU KO TÌM THẤY, THÌ TRẢ VỀ NULL, ĐỂ NÓI RẰNG KO CÓ OBJECT THOẢ
            //TRỎ NULL LÀ TỎ VÙNG KO THẤY, KO CÓ, RẰNG IN THÔNG TIN BÁO LỖI

        }

        static void CreateAStudentObject()
        {
            // tạo tử tế, vi con tình huống bất thường, học sau
            Student      s3          =      new Student("SE1", "AN", 2004, 8.6);
            //data type  biến object      value/object/vùng ram to
            //int        yob         =      2004;
            //cho x là con số nguyên mang giá trị 2004;
            //    x        int                    2004; 


            s3.ShowProfile();
        }




    }
}
