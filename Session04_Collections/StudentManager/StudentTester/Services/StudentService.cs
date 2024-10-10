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

    }
}
