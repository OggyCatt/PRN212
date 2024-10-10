using ObjectArray.Entities;

namespace ObjectArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithSV2();
            PlayWithSV3();
        }

        static void PlayWithSV3()
        {
            //GiaoAnSV[] sv = {ValueTask của từng phần tử sv[i] cách nhau 1 dấu , }
            //sv[i] = new GiaoAnSV()

            int[] a = { 1, 2, 3 };

            GiaoAnSV[] arr = { new GiaoAnSV(), new GiaoAnSV(), new GiaoAnSV() };
            GiaoAnSV[] arr2 = { new GiaoAnSV(){Id = "1"}, new GiaoAnSV(){Id = "2" }, new GiaoAnSV(){Id = "3" } };

            for (int i = 0; i < arr2.Length; i++)
                Console.WriteLine(arr2[i]);
        }

        //CRTL K D CĂN LẠI CODE

        //lưu hồ sơ 35 SV bất kì mảng object
        static void PlayWithSV2()
        {
            GiaoAnSV[] arr = new GiaoAnSV[35];
            //TA CÓ 35 BIẾN SINH VIÊN MANG TÊN arr[0], arr[1]
            //và hiện nay 35 biến Student này chưa trỏ vùng new Student() nào cả
            //Mặc định là NULL, nên tạo mảng object phải new
            //1. Tạo mảng chứa 35 con trỏ biến object
            //2. muốn xài biến object nào thì lấy nó ra rồi new ra
            arr[0] = new GiaoAnSV() { Id = "SE1", Name = "Dat1", Yob = 2004, Gpa = 9.1 };
            arr[1] = new GiaoAnSV() { Id = "SE2", Name = "Dat2", Yob = 2005, Gpa = 9.2 };
            arr[2] = new GiaoAnSV() { Id = "SE3", Name = "Dat3", Yob = 2006, Gpa = 9.3 };
            arr[3] = arr[2];
            Console.WriteLine("List");
            for (int i = 0; i < 4; i++)
                Console.WriteLine(arr[i]);
            //chơi với mảng cẩm ko được for hết mà chỉ for đến vị trí đã được đổ giá trị
            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);//Gọi thầm tên em
            //}

            //Chơi với mảng chỉ được for đến count!!!
            //mỗi lần thêm vào mảng, gán giá trị cho mảng, count++
            //3 và 2 trỏ trùng
            Console.WriteLine("3(4) 4 phần tử nhưng thực ra là 3 do đếm trùng");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(arr[i]);  //2 bạn cuối là 1 sv
            }

            //In đổi giá trị
            arr[2].Id = "6";
            Console.WriteLine(arr[3]);
        }
    }
}
