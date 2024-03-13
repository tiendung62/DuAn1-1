using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class Khuyenmai
    {
        public Khuyenmai()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Idkm { get; set; } = null!;
        public string? Sukienkm { get; set; }
        public string? Giamgia { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string? Trangthai { get; set; }

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
