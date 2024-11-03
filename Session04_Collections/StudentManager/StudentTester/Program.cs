using StudentTester.Entities;
using StudentTester.Services;
using System.Runtime.ConstrainedExecution;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService(300);
            service.Add(new Student { Id = "1", Name = "An", Yob = 2004, Gpa = 3.0 });
            service.Add(new Student { Id = "2", Name = "Binh", Yob = 2003, Gpa = 3.1 });
            service.PrintStudentList();

            StudentService attt = new StudentService(69);
            attt.Add(new Student { Id = "IA3", Name = "Cuc", Yob = 2002, Gpa = 3.2 });
            attt.Add(new Student { Id = "IA4", Name = "Cut", Yob = 2001, Gpa = 3.3 });
            Student student = new Student { Id = "IA5", Name = "Cot", Yob = 2000, Gpa = 3.4 };
            attt.Add(student); //Hàm Overload
            attt.PrintStudentList();

            //Mảng khác _count khác khởi đầu từ 0
            attt.Update("IA4", "Đức", 2000, 3.4);
            attt.PrintStudentList();

            //Delete
            attt.SearchByID("IA5");


            //Lecturer
            LecturerService lecturer = new LecturerService();

            lecturer.Add(new Lecturer { Id = "1", Name = "An", Yob = 2004, Salary = 3000 });


        }
    }
}
