using System.Runtime.CompilerServices;

namespace NullableTester
{
    //1 namespace chứa nhiều class, các class có thể nằm lẻ thành 1 tập tin (.cs)
    //hoặc gộp chung trong 1 tập tin (.cs)
    //nên tách riêng
    //trong namespace chỉ có thể chứa class và những thứ tương đương
    //INTERFACE (1 DẠNG CLASS)
    //DELEGATES (1 DẠNG CLASS)
    public class Student
    { // CODE THỬ NGHIỆM, KO THEO ENCAPSULATION
        public string id; //boiler plate code   bad smells code
        public string name;
        public int yob;
        public double gpa;

        // ko có constructor 
        public void ShowProfile()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("NAME: {0}", name);
            Console.WriteLine($"YOB: {yob}");
            Console.WriteLine($"GPA: {gpa}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student();
            an.id = "SE183946";
            an.name = "Nguyen Van An";
            an.yob = 2001;
            an.gpa = 3.0;
            //Phá encapsulation, chơi trần  bên trong object mà ko thông qua method
            an.ShowProfile();

            //an = null;
            //an.ShowProfile();

            //NULL THỨ 2 
            // TRONG DB CÓ KHÁI NIỆM NULL: KHI 1 COL NÀO ĐÓ
            //VÍ DỤ ĐIỂM THI PE, ĐIỂM THI TE CÓ SẴN ĐỂ GHI NHẬN ĐIỂM ĐIỂM THI CỦA 1 SV KHI ĐĂNG KÍ LỚP HỌC X
            //CÓ NHỮNG TÌNH HUỐNG DATA CHƯA CÓ, CHƯA BIẾT CHÍNH XÁC, CHƯA ĐẾN THỜI ĐIỂM CÔNG BỐ
            //NULL: CHƯA CÓ GIÁ TRỊ, CHƯA CÓ DỮ LIỆU

            //double pe = null; //lập trình truyền thống
            double? pe = null; //lập trình hiện đại
            //? biến kiểu perimitive đc quyền chưa null, ko xđ giá trị
            //ta sẽ có int? double? bool? DateTime? Guid?...
            //Y CHANG THẰNG KO HỎI CHẤM, NGOÀI TRỪ GIAS TRỊ NULL
            //Vậy Student? có hợp lệ k
            //? áp dụng cho cả kiểu object, nhưng ko thật sự cần thiêt
            if(pe is null) 
                Console.WriteLine("PE is null");
            else 
                Console.WriteLine("PE is not null");
                

        }


    }
}
