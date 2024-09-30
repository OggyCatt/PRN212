namespace PassByReferenceOutKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6868;
            Console.WriteLine("Before calling the method, x now is: " + x); //6868
            PlayWithOutV2(out x);
            Console.WriteLine("After calling the method, x now is: "+ x);
            Console.WriteLine("V3------------");
            PlayWithOutV3(out x);
            Console.WriteLine("x: " + x);

            //CÁCH CHATGPT HAY XÀI
            PlayWithOutV3(out int xxx);//khai báo biến style in line
            //biến khai báo in line được xử dụng toàn cục
            //vừa khai báo biến vừa gọi hàm!!!CHƠI GỘP
            Console.WriteLine("xxx: "+ xxx);


        }

        static void PlayWithOut(int n)
        {
            //n gốc ban đầu bằng mấy ko care, thay nó = 6789;
            Console.WriteLine("inside the method,at first n is: " + n);

            n = 6789;//san bằng tất cả (2204 mai mai kh die, )
            Console.WriteLine("inside the method,at second n is: " + n);
        }


        //OUT SẼ BIẾN ĐỔI THAM SỐ THÀNH POINTER, CON TRỎ, THAM CHIẾU, REFERENCE TO BIẾN BÊN NGOÀI
        //NÓ TRỎ VÀO BIẾN BÊN NGOÀI
        //BÊN TRONG THAY ĐỔI BÊN NGOÀI ĐỔI THEO
        //TRUYỀN ĐỊA CHỈ BIẾN BÊN NGOÀI VÀO HÀM, HÀM LÀM GÌ, BIẾN GỐC BỊ THAY ĐỔI
        //OUT: BẮT BUỘC BÊN TRONG HÀM PHẢI CÓ CÂU LỆNH GÁN GIÁ TRỊ CHO BIẾN OUT.
        //HÀM OUT ĐỌC LÀ: TỚ HỨA SẼ CÓ 1 VALUE TRẢ RA BIẾN BÊN NGOÀI. PHẢI CÓ!!!!!
        //TRONG HÀM, BIẾN OUT PHẢI ĐƯỢC GÁN VALUE!!!! TRƯỚC KHI LÀM GÌ ĐÓ, VÌ LÀ LỜI HỨA SẼ CÓ VALUE TRẢ RA
        //BIẾN GÓC SẼ BỊ BIẾN ĐỔI KHI GỌI HÀM OUT
        static void PlayWithOutV2(out int n)
        {
            //ko được dùng n trước khi gán giá trị nào đó cho n!!!!!!!!

            n = 6789;//san bằng tất cả (2204 mai mai kh die, )

            Console.WriteLine("inside the method,at second n is: " + n);

        }

        static void PlayWithOutV3(out int n)
        {
            n = 6969;
            
        }
    }
}
