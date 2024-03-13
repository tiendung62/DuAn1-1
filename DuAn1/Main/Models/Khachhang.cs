using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public string Idkh { get; set; } = null!;
        public string? Idloaind { get; set; }
        public string? Ten { get; set; }
        public int? Sdt { get; set; }
        public string? Diachi { get; set; }
        public string? Email { get; set; }
        public string? Diem { get; set; }

        public virtual Loaikhachhang? IdloaindNavigation { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
