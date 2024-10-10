using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version5.Entities
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }


        //ĐÂY LÀ KĨ THUẬT GIẢM BỚT NHÀM CHÁN CỦA BỘ HÀM GET/SET
        //gõ prop tab tab
        //AUTO - IMPLEMENTED PROPERTY
        //Class map trục tiếp với table

        public int MyProperty { get; set; }
    }
}
