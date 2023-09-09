using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongThuanQuang_Bai4_BTMAU.Models
{
    public class NhanVien
    {
        public int maNV { get; set; }
        public string tenNV { get; set; }
        public string GT { get; set; }
        public string Hinh { get; set; }
        public NhanVien()
        {
            maNV = 101;
            tenNV = "Mr Trung";
            GT = "Nam";
            Hinh = "NV01.jpg";
        }
    }
}