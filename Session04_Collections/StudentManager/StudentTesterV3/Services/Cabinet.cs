using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentTesterV3.Services
{
    public class Cabinet<T> //TYPE - QUY ƯỚC TRONG NGOẶC NHỌN
    {
        //Nếu ta khai báo mảng student, lecturer thì high coupling
        //TRONG GIANG HỒ, CÓ 4 GÃ DEV XIN, ĐÃ LÀM, ĐÃ TỔNG KẾT, DADX VIẾT LẠI VÀ SHARE CHO ANH EM CÁC KĨ THUẬT THIẾT KẾ CLASS
        //MANG TÊN DESIGN PATTERN CỦA GoF(Gang of Four)
        //seach: Tôi đi code dạo để có review cuốn này
        //ĐỪNG RÁNG HIỂU HẾT CẢ CUỐN, KO CẦN ÁP DỤNG HẾT CÁC KĨ THUẬT
        private T[] _arr;
        private int _count = 0; //gán bằng - cho tường minh

        public Cabinet(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Invalid size, Size must be greater than 1"); //Ném ra lỗi, không chạy tiếp
            _arr = new T[size];
        }//NẾU CONSTRUCTOR NÉM RA EXEPTION THÌ KO TẠO RA OBJECT
        //KĨ THUẬT VIẾT CODE MÀ CHỈ CÓ DUY NHẤT 1 OBJECT TRONG RAM, KĨ THUẬT SINGLETON
        //PHI STATIC BẤT THÀNH SINGLETON

        //public Cabinet(int size)
        //{
        //    if (size <= 0)
        //        size = 69;
        //    _arr = new T[size];
        //}

        public void Add(T item)
        {
            if(_count++ == _arr.Length)
                Console.WriteLine("Full");
            _arr[_count++] = item;
        }

        public void PrintList()
        {
            if(_count++ == 0)
            {
                Console.WriteLine("Nờ ô NÔ");
                return;
            }
            Console.WriteLine($"There is/are {_count} in arr");
            for (int i = 0; i < _count; i++)           
                Console.WriteLine(_arr[i]);
            
        }

        //Update, Delete, Search



    }
}
