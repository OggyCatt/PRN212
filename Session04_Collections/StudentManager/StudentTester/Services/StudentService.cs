using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class StudentService
    {
        //Cái tủ sẽ chứa nhiều hồ sơ, mảng của ác student khác
        //

        private Student[] _arr = new Student[300];
        private int _count = 0;

        //Các hàm CRUD Hồ sơ sẽ xuất hiện thao tác trên _arr, _count
        //Tại sao ko dùng properties?
        //không cần cho người dùng truy cập trực tiếp vào danh sách sinh viên (ví dụ, bạn chỉ muốn cho phép thêm, sửa, và xóa sinh viên),
        //thì việc sử dụng properties có thể không cần thiết.
        //Tủ bị fix 300 hồ sơ làm sao đóng tủ theo yêu cầu
        //if (_count >= _arr.Length)
        //    {
        //       ExpandArray(); // Mở rộng mảng khi nó đầy
        //   }

        //  _arr[_count++] = student; // Thêm sinh viên mới và tăng _count

        // Mảng, có kích thước theo yêu cầu
        public StudentService(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Invalid size, Size must be greater than 1");

            _arr = new Student[size];
        }

        //New theo kiểu style đưa cà chớn nhận default
        //đều là tủ đóng theo yêu cầu
        //public StudentService(int size)
        //{
        //    if (size <= 0)
        //        size = 69;

        //    _arr = new Student[size];
        //}


        //Các hành động trên tủ, trên từng bộ hồ sơ, CRUD

        //UI sẽ lo việc có 4 ô nhập, nút create, gửi 4 info cho hàm add
        //CREATE, RETRIEVE, UPDATE, DELETE
        public void Add(Student student)
        {
            _arr[_count++] = student; // Thêm sinh viên mới và tăng _count
        }

        public void Add(string id, string name, int yob, double gpa)
        {
            Add(new Student
            {
                Id = id,
                Name = name,
                Yob = yob,
                Gpa = gpa
            });
        }

        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} stuwdents");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        //Update, 
        //Mảng xin bao nhiêu cấp bấy nhiêu, 
        //xoá mảng là dời chỗ các phần tử, xoá giả
        public void Update(string id, string name, int yob, double gpa)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                {
                    _arr[i].Name = name;
                    _arr[i].Yob = yob;
                    _arr[i].Gpa = gpa;
                }
            }
        }


        public void Update(int pos, string name, int yob, double gpa)
        {
            if (pos < 0 || pos >= _count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            _arr[pos].Name = name;
            _arr[pos].Yob = yob;
            _arr[pos].Gpa = gpa;
        }

        //xoá
        public void Delete(string id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id == id)
                {
                    for (int j = i; j < _count - 1; j++)
                    {
                        _arr[j] = _arr[j + 1];
                    }
                    _count--;
                    break;
                }
            }

        }

        public void Delete(int pos)
        {
            if (pos < 0 || pos >= _count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            for (int i = pos; i < _count - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            _count--;

        }

        public void SearchByID(string id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                {
                    Console.WriteLine(_arr[i]);
                    break;
                }
            }
            Console.WriteLine("Không thấy");

        }
    }
}
