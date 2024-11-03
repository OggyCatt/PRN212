using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVTester.Entities
{
    public class Candidate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public string Position { get; set; }

        //KO CẦN LÀM TOSTRING(), LÝ DO TA SHOW TOÀN BỘ INFO ỨNG VIÊN VÀO CÁI GRID/TABLE TRÊN UI - LƯỚI
        //GRID TRÊN UI NÓ SHOW DATA THEO HÀNG CỘT NHƯ EXCEL, VẬY NÓ CẦN LẤY TỪNG FIELD/PROPERTY, TRONG KHI TOSTRING() GỘP/MERGE THÀNH 1 STRING. TOSTRING() DÀNH CHO VIỆC KIỂM TRA DATA ĐỔ VÀO ĐÚNG SAI Ở GÓC ĐỘ DEBUG, CONSOLE LOG


    }
}
