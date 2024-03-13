using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Masp { get; set; } = null!;
        public string? Tensp { get; set; }
        public int? Gianhap { get; set; }
        public int? Soluongnhap { get; set; }
        public string? IdnguoiDung { get; set; }
        public DateTime? Ngaynhap { get; set; }
        public string? Diachinhap { get; set; }
        public int? Soluongton { get; set; }
        public decimal? Giaban { get; set; }
        public string? Trangthai { get; set; }

        public virtual NguoiDung? IdnguoiDungNavigation { get; set; }
        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
