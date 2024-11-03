using StudentTester.Entities;
using StudentTesterV3.Services;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8 }; //4
            int[] bray = {1,2,3,4,5,6,7,8 }; //8

            //một thằng 5 giá trị, 5 vùng ram liên tiếp
            //một thằng 8 giá trị, 8 vùng ram liên tiếp

            arr = bray; //arr trỏ vào bray, arr mất đi, bray vẫn còn
            Console.WriteLine(arr.Length);

            //vùng ram 2,4,6,8 bị mồ côi, ko con trỏ sẽ bị dọn dẹp
        }
        static void PlayWithCabinet()
        {
            //ArrayList<Student> arr = new ArrayList<Student>();

            //Cabinet<Student> tuSena = new Cabinet<Student>(5);
            Cabinet<Student> lbq = new Cabinet<Student>(5);
            //Hộp để chứa nhiều đồ, có 1 cái hộp tên là tuSena

            lbq.Add(new Student() { Id = "SE1", Name = "Le Bao", Gpa = 10, Yob = 2004 });
            lbq.Add(new Student() { Id = "SE2", Name = "Le Bao Quoc", Gpa = 10, Yob = 2004 });

            lbq.PrintList();
        }
    }
}
