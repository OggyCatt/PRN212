using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //T: Type, cũng có thể là TRINH
    //LẦN ĐẦU TIÊN TRÁI THANH LONG
    //LẦN ĐẦU TIÊN DATATYPE LÀ THAM SỐ
    //LEVEL 1: CỦA THAM SỐ f(INT X)
    //LEVEL 2: CỦA THAM SỐ f(T X) CHƯA BIẾT X THUỘC DATATYPE NÀO
    //T; GIÚP HÀM CHƠI CAAN HẾT

    //MAI MỐT XÀO: Cabinet<Student>
    //             Cabinet<Lecturer>
    public class Cabinet<T>
    {
        //Mảng là mảng T, T có thể là Student, Lecturer
        private T[] _arr;
        private int _count = 0;

        public Cabinet(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Invalid size, Size must be greater than 1");

            _arr = new T[size];
        }

        public void Add(T item)
        {
            _arr[_count++] = item;
        }

        public void PrintList()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }


        public void Delete(int pos)
        {
            for (int i = pos; i < _count - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            _count--;

        }

        public void Update(int pos, T item)
        {
            _arr[pos] = item;
        }

        public void Search(string id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].ToString().Contains(id))
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }
    }
}
//Về nhà viết ra giấy: 3 bài