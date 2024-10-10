namespace BasicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithPrimitiveArrayV1();
            //PlayWithPrimitiveArrayV2();
            //PlayWithPrimitiveArrayV3();
            //PlayWithPrimitiveArrayV4();
            PlayWithPrimitiveArrayV6();
        }

        static void PlayWithPrimitiveArrayV6()
        {
            double[] r = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16};
            //object initializer
            foreach (var i in r)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i + 1);
                else
                    Console.WriteLine(i);
            }
        }

        static void PlayWithPrimitiveArrayV5()
        {
            double[] r = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //object initializer
        }

        static void PlayWithPrimitiveArrayV4()
        {
            double[] r = new double[10] { 0,1,2,3,4,5,6,7,8,9};
            for(int i = 0; i < r.Length; i++) {
                Console.WriteLine(r[i]);
        }

        static void PlayWithPrimitiveArrayV3()
        {
            double[] r = new double[10];
            r[0] = 0;
            r[1] = 5;
            r[2] = 10;
            r[3] = 10;
            r[4] = 10;
            r[5] = 15;
            r[6] = 120;
            r[7] = 180;
            r[8] = 200;
            r[9] = 300;


            for (int i = 0; i < r.Length; i++)
                Console.WriteLine(r[i]);

        }



        static void PlayWithPrimitiveArrayV2()
        {//DÙNG MẢNG
            double[] r = new double[10];
            //bạn đã có trong tay 10 biến double
            //MẢNG LÀ KĨ THUẬT KHAI BÁO NHIỀU BIẾN CÙNG LÚC, CÙNG KIỂU, Ở SÁT NHAU TRONG RAM, CÙNG 1 TÊN
            //MẢNG LÀ KHAI BÁO NHIỀU BIẾN CÙNG LÚC!!!!

            // Ở TRÊN CÓ 10 BIẾN CÙNG TÊN LÀ DOUBLE R
            // ĐỂ PHÂN BIỆT BIẾN NÀY VỚI BIẾN KIA, TA DÙNG CHỈ SỐ [INDEX TỪ 0...]
            // R[0] LÀ BIẾN THỨ NHẤT, R[1] LÀ BIẾN THỨ HAI, HIẾU THỨ[2]
            //

            //Tên mảng là biến má mì dưới trường 10 10 em double

            for(int i = 0; i < r.Length; i++)
            {
                r[i] = i+1;
                Console.WriteLine(r[i]);
            }

            Console.WriteLine(r.Length);
    }

        static void PlayWithPrimitiveArrayV1()
        {
            //Hãy lưu trữ giúp tôi lượng mưa của 10 ngày đầu tháng 9
            double r1 = 5, r2 = 10, r3 = 9, r4 = 8, r5 = 7, r6 = 6, r7 = 5, r8 = 4, r9 = 3, r10 = 2;
            double rain1, rain2, rain3, rain4, rain5, rain6, rain7, rain8, rain9, rain10;

            rain1 = 0;
            rain2 = 5;
            rain3 = 10;
            rain4 = 9;
            rain5 = 8;
            rain6 = 7;
            rain7 = 6;
            rain8 = 4;
            rain9 = 3;
            //rain10 = 2;

            

            Console.WriteLine($"Day 1: {rain1}");
            //Console.WriteLine($"Day 10: {rain10}");
            //BIẾN KO GÁN GIÁ TRỊ - CẤM THAO TÁC

            //IN LƯỢNG MƯA 

            //LƯU GIÚP EM LƯỢNG MƯA NĂM NAY (365 NGẦY)
            //LƯU GIÚP EM LƯỢNG MƯA TRONG 10 NĂM -- DATA MINING

        }
    }
}
}
//Ôn lại về kiểu dữ liệu - data type 
//Ta có 2 loại dữ liệu: đơn giản và phức tạp
//1. Dữ liệu đơn giản: PRIMITIVE DATA TYPE(JAVA)
//                     VALUE TYPE
//KHAI BÁO BIẾN ĐỂ LƯU TRỮ PRIMITIVE TỐN 1 VÙNG RAM
//int yob = 2004; 4 byte
//2. Dữ liệu phức tạp: REFERENCE TYPE

//Tốn 2 vùng ram: vùng ram cho biến con trỏ, và vùng ram bự chứa info của object
//Student s = new Student();
// int x = 2004;