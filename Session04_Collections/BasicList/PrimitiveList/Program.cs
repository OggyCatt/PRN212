using System.Collections;
using System.Collections.Generic;

namespace PrimitiveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithPrimitiveListV2();
        }

        static void PlayWithPrimitiveList()
        {
            ArrayList arr = new ArrayList(10);//Đây là mảng lộn xộn chứa từ lưa kiểu dữ liệu
            //ko nên chơi arraylist, thằng nay ko generic, đc add tự do đủ loại data type vào bên trong            
            //khác java, java có arraylist, nhưng nó hỗ trợ generic, nó ko cho add lộn xộn
            //ArrayList<Integer> arr = new ArrayList<Integer>(); //ko chơi với int mà chỉ chơi với object
        }

        //C#: LIST LÀ CLASS CỤ THỂ (NEW ĐC), VÀ LÀ GENERIC -- ARRAYLIST BÊN JAVA
        //  ARRAYLIST LÀ NON - GENERIC, LÀ CLASS - ARRAYLIST BÊN JAVA NHƯNG KO HỖ TRỢ GENERIC, ADD LỘN XỘN MÓN ĐỒ

        static void PlayWithPrimitiveListV2()
        {
            //JAVA THÌ COLLECTIONS CHỨA BÊN TRONG PHẢI LÀ 1 OBJECT
            List<int> list = new List<int>(); //đây là list generic, chỉ chứa 1 kiểu dữ liệu
            list.Add(3);
            list.Add(5);
            Console.WriteLine(list.Count);
            //list.Add(7.5);
            //low coupling - <int> <long>
            //nhưng consistency - nhất quán trong data

            //List thay thế cho ArrayList -- nha sĩ recommended
        }

        //JAVA HỖ TRỢ 1 LOẠT CÁC CLASSS ĐÓNG VAI TRÒ NHƯ CABINET 
        //TỨC LÀ JAVA HỖ TRỢ TA 1 LOẠT CÁC CLASS DÙNG ĐỂ LƯU TRỮ IỀU OBJECT, THAY THẾ CHO MẢNG
        //GỌI CHUNG LÀ COLLECTIONS
        //NÓ CŨNG CHỨA BÊN TRONG 1 ĐỐNG CON TRỎ, GIÁ TRỊ NHƯ MẢNG NHƯNG
        //NÓ CO GIÃN KÍCH THƯỚC, BAN ĐẦU KÍCH THƯỚC 0, TA 
        //JAVA: ABSTRACT COLLECTIONS, INTERFACE:       LIST,                  SET,                 MAP
        //JAVA: ABSTRACT LIST, INTERFACE:     ARRAYLIST, LINKEDLIST      HASHSET, TREESET      HASHMAP, TREEMAP
        //class nào mà new dc gọi là concrete class - class cụ thể

        //List<?> l = new AraayList(); //đúng
        //List<?> l = new List(); //sai
        // ANONYMOUS CLASS

        //


    }
}
