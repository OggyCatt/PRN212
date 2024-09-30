using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1", "AN", 2004, 8.6);
            Console.WriteLine("s1 shows profile...");
            s1.ShowInfo();

            Student s2 = new Student("SE2", "Bình", 2004, 8.7);
            Console.WriteLine("s2 shows priflie");
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s2); //gọi thầm tên em ToString()

            //và nếu ko có ToString(), Java sẽ băm data (hash/hasing) vùng new thành dãy hexa
            //C# nó sẽ làm biếng nó báo vùng này là vùng Student
            
            Student s3 = new ("SE3", "Cường", 2004, 8.8);
            //KO CẦN new Student - cú phpas mới do đã có Student ở vế trái rồi

            Console.WriteLine("s3 shows profile");
            s3.ShowInfo();

            var s4 = new Student("SE3", "Dũng", 2004, 8.9);
            //TYPE INFERENT - SUY LUẬN KIỂU - CÓ MANH MỐI CHÓ MÌNH SUY RA VÙNG NEW
            Console.WriteLine("s4 shows profile");
            s4.ShowInfo();

            //var s5 = new Student("EM" , 2004, 9.0, "SE5")
            var s5 = new Student(name: "EM", yob: 2004, gpa: 9.0, id: "SE5");
            //name argument: dùng tên tham số để đảo thứ tự đầu vào

            Console.WriteLine("s5 shows profile");
            s5.ShowInfo();

            Student s6 = s5; //s6 là tham chiếu đến s5
            //2 chàng trỏ 1 nàng
            

        }

        static void ReName(Student x)
        {
            x.SetName("Đạt");
        }

    }
}
