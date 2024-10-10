using Version5.Entities;

namespace Version5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new() {Id = "SE1", Name = "An", Yob = 2004, Gpa = 10 };
            Console.WriteLine("An: " + an.Id + "|" +an.Name);
        }
    }
}
