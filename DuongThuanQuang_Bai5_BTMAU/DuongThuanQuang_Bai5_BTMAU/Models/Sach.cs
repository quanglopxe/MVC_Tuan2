using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuongThuanQuang_Bai5_BTMAU.Models
{
    public class Sach
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public int Gia { get; set; }
        public string anhBia { get; set; }
        public Sach()
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.Gia = Gia;
            this.anhBia = anhBia;
        }
    }
}