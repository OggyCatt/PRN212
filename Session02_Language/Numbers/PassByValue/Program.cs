namespace PassByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //PrintNumbers(0);
            int numbers = 999;
            PrintNumbers(numbers);
            //TRUYỀN THÁI Y KIỂU THAM TRỊ, TỨC LÀ THAM SỐ CỦA ÀM CHỈ XIN VALUE
            //VALUE Ở BÊN NGOÀI, TRONG HÀM SỬA, BÊN NGOÀI GIỮ NGUYÊN


        }
        //THAM SỐ ĐẦU VÀO CỦA HÀM CÓ THÊM TỪ KHOÁ IN
        //THÌ THAM SỐ ĐÓ TRỞ THÀNH READ ONLY, CẤM SỬA VALUE TRONG CODE!!

        //TODO AT HOME: nếu tham số đầu vào của hàm là biến Object 
        //ví dụ Student n, nhưng ta thêm(in Student n)
        //thì readonly nên được hiểu như thế nào??


        //CHALENGE #1: VIẾT hàm nhận vào 1 con số dương rồi in ra các số đó

        static void PrintNumbers(in int number)
        {
            if (number < 1)
            {
                Console.WriteLine("Num must be >= 1");
                //number = 3000;
            }          
                for (int i = 1; i <= number; i++)               
                    Console.Write("The list:" + i);
                Console.WriteLine();
                
            

        }
    }
}
