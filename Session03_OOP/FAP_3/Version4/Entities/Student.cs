using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version4.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student()
        {
        }

        //gõ từ khoá PROPFULL TAB TAB
        private string Id
        {
            get => _id;
            set => _id = value;
        }

        //KĨ THUẬT LÀM PROPERTY HÀM LAI BIẾN, BIẾN LAI HÀM
        //CÓ ĐỦ HÀM/BIẾN TRAI BAO KÈM BACKING FIELD THÌ PROPERTY NÀY ĐC GỌI LÀ FULL PROPERTY
        //CÁCH NÀY HAY HƠN JAVA 
        //lombok (cài thêm dependency) để tạo getter/setter

        //tuy nhiên cách get ở trên vẫn còn boiler plate code

        //CHIÊU CUỐI



    }
}
