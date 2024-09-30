namespace NumbersTester;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    //CHALLENGE: VIẾT HÀM TÍNH TỔNG CÁC SỐ TỪ 1...100
    static void SumIntegerList()
    {
        //int sum = 0;
        var sum = 0;//var:
        //var = 3.14;//error
        //var là khai báo biến nhưng ko chỉ ra datatype của biến đó.
        //Data type của biến sẽ đc suy luận ngay khi biến đucojw gán value,
        //tuỳloại value được gán cho biến sẽ suy ra biến thuộc data type nào
        //bắt buộc phải gán giá trị biến ngay khi khai báo,
        //khác cách khai báo biến theo style thông thường
        int yob;
        yob = 2004;
        int age = 20;
        var x = 'Hello';

        //for(; ;); hợp lệ

        for (int i = 1; i <= 100; i++)
            sum += i;
        //5050 đc gọi là EXPECTED VALUE - GIÁ TRỊ KÌ VỌNG
        //UNIT TESTING MÔN SWT301
       



        //in cácc số từ 1..100, sau đó in tổng
        console.WriteLine("The list of number from 1...100");
        for (int i = 1; i <= 100; i++)
            Console.write(i + "");

        Console.WriteLine("The sum of the list:" + sum);
        Console.WriteLine("The sum of the list: {0}" + sum);
        //thực tế in ra mấy, thì gọi là ACTUAL VALUE
        //nếu EXPECTED VALUE == ACTUAL VALUE -> CODE NGON
        //nếu EXPECTED VALUE != ACTUAL VALUE -> CODE !NGON

        int sumOdd = 0;
        int sumEven = 0;

        for (int i = 1;i <= 10;i++)
        {
            if(i%2==0)
                sumEven+=i;
            else
                sumOdd+=i;

        }


       
    }



}
