namespace PassByRefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xài hàm out, khai báo biến lẻ, đưa vào hàm, chờ kết quả, khai báo biến in line.
            //Cả 2 ko cần gán value
            int x1;
            PlayWithOut(out  x1);
            Console.WriteLine("Out -> x1: " + x1);

            PlayWithOut(out int x2);
            Console.WriteLine("Out -> x2: " + x2);


            //xài hàm ref
            int x3 = 6789; //luôn cần 1 giá trị có sẵn cho biến trước khi đẩy vào ref
            PlayWithRef(ref x3); //đề phòng ref ko trả về
            Console.WriteLine("Ref -> x3: " + x3);

            // PlayWithRef(ref int x4);
            // ko xài in line do cú pháp in line ko có chỗ gán giá trị cho biến đề phòng ref ko trả về

        }

        //KHI NÀO TA XÀI OUT, REF
        //KHI TA MUỐN 1 HÀM TRẢ VỀ NHIỀU HƠN 1 GIÁ TRỊ
        //KHI TA LỠ 1 LẦN XỬ LÍ NHIỀU DATA, THÌ TA LÀM LUÔN NHIỀU VIỆC
        //VÍ DỤ LỠ DUYỆT QUA DANH SÁCH 100K USER, SINH VIÊN
        //TA TÍNH LUÔN: SỐ LƯỢNG USER TRONG ĐỘ TUỔI X->Y
        //              SỐ USER CỦA MỖI TỈNH THÀNH
        //              ĐẾM SỐ LƯỢNG USER CÓ TỔNG ĐƠN HÀNG X-Y
        

        static void PlayWithRef(ref int x)
        {
            //em ko hứa x sẽ có value. Thích thì làm
            //bên trong x đổi, bên ngoài đổi theo
            x = 3979; //4953
        }


        static void PlayWithOut(out int x)
        {
            //em hứa x sẽ có 1 value trong hàm
            //bên trong x đổi, bên ngoài đổi theo
            x = 2204;


        }

        //3 KEYWORD: IN, OUT, REF
        //3 THẰNG NÀY ĐẦU LIÊN QUAN ĐẾN THAM SỐ, ĐẦU VÀO CỦA HÀM, TRUYỀN CÁI GÌ ĐÓ VÀO HÀM
        //IN: THAM SỐ ĐẦU VÀO LÀ READONLY, TỨC LÀ KO ĐƯỢC ĐỔI VALUE CỦA THAM SỐ ĐÓ Ở TRONG HÀM
        //OUT: TRUYỀN BIẾN VÀO TRONG HÀM, TRONG HÀM THAY ĐỔI, BIẾN NGOÀI ĐỔI THEO
        //REF: TRUYỀN BIẾN VÀO TRONG HÀM, TRONG HÀM THAY ĐỔI, BIẾN NGOÀI ĐỔI THEO
        //NẾU BIẾN TRUYỀN VÀO HÀM, TRONG HÀM THAY ĐỔI, BÊN NGOÀI GIỮ NGUYÊN -> GỌI LÀ TRUYỀN THAM TRỊ
        //NẾU TRUYỀN VÀO HÀM, TRONG HÀM THAY ĐỔI, BÊN NGOÀI ĐỔI THEO( OUT, REF) -> GỌI LÀ TRUYỀN THAM CHIẾU
        //- PASS BY REFERENCE
        //KHI NÀO HIỆN TƯỢNG PASS BY VALUE - THAM TRỊ XẢY RA??
        //CHỈ XẢY RA VỚI TÌNH HUỐNG DATA TYPE KIỂU
        //(J) PRIMITIVE int long float double char bool...
        //(C#) VALUE-TYPE int long float double char bool...

        //PASS BY REFERENCES CÓ 3 TÌNH HUỐNG
        //OUT (chơi với cả primitive và object)
        //REF (chơi với cả primitive và object)
        //??? OBJECT

        //C# PASS BY REFERENCE CHƠI VỚI CẢ PRIMITIVE
        //JAVA: PASS BY REFERENCE CHỈ CHƠI VỚI OBJECT
    }
}
