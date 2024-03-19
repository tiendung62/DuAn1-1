using System;
using System.Collections.Generic;

namespace Main.BLL.Models2
{
    public partial class Loaikhachhang
    {
        public Loaikhachhang()
        {
            Khachhangs = new HashSet<Khachhang>();
        }

        public string Idloaind { get; set; } = null!;
        public string? Ten { get; set; }
        public string? Diem { get; set; }
        public string? Mota { get; set; }

        public virtual ICollection<Khachhang> Khachhangs { get; set; }
    }
}
