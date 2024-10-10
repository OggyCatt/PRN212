using Version3.Entities;

namespace Version3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student();
            Console.WriteLine("AN: " +an);
            var binh = new Student();

            Student ngoc = new Student("SE1", "Ngoc", 2000, 3.5);
            Student ha = new();
        }
    }
}
