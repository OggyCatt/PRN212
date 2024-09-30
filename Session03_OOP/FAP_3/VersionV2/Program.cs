using System.Collections.Generic;
using VersionV2.Entities;

namespace VersionV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student> students = new List <Student> ();
            Student an = new Student();
            //Console.WriteLine(an); // gọi thầm tên em

            //XÀI GET() SET()
            an.SetId("SE1");
            an.SetName("An");
            an.SetYob(2000);
            an.SetGpa(3.5);
           // Console.WriteLine(an); // gọi thầm tên em


            //List
            students.Add(an);
            students.Add(new Student("SE2", "Bình", 2001, 3.6));

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }


            //TA PHÁT HIỆN 1 ĐIỀU: TÊN BIẾN ĐÃ MANG 2 Ý NGHĨA GET() VÀ SET()
            //
            int yob = 2004;

            //lấy giá trị biến và in ra
            Console.WriteLine("YOB: " +yob);

            //SET: THAY ĐỔI GIÁ TRỊ BIẾN CHO TUI
            yob = 2005;


            //C# tìm cách tối ưu boiler plate theo cách tiếp cận tên biến bao hàm 2 ý nghãi get set

        }
    }
}
