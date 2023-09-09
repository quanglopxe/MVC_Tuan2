using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongThuanQuang_Bai3_BTMAU.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        
        public Employee()
        {
            ID = 101;
            Name = "Mr Trung";
            Address = "140 Lê Trọng Tấn";
            Salary = 2000;
        }
    }
}