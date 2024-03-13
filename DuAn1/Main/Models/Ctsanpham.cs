using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class Ctsanpham
    {
        public Ctsanpham()
        {
            Hoadoncts = new HashSet<Hoadonct>();
        }

        public string Idctsp { get; set; } = null!;
        public string? Idkm { get; set; }
        public string? Idncc { get; set; }
        public string? Masp { get; set; }
        public string? Mau { get; set; }
        public string? Chatlieuu { get; set; }
        public string? Kichthuoc { get; set; }
        public string? Degiay { get; set; }
        public string? Tengiay { get; set; }
        public int? Gianhap { get; set; }
        public int? Soluongton { get; set; }
        public decimal? Giaban { get; set; }
        public string? Doitra { get; set; }

        public virtual Chatlieu? ChatlieuuNavigation { get; set; }
        public virtual Degiay? DegiayNavigation { get; set; }
        public virtual Khuyenmai? IdkmNavigation { get; set; }
        public virtual NhaCungCap? IdnccNavigation { get; set; }
        public virtual Kichthuoc? KichthuocNavigation { get; set; }
        public virtual Sanpham? MaspNavigation { get; set; }
        public virtual Mausac? MauNavigation { get; set; }
        public virtual ICollection<Hoadonct> Hoadoncts { get; set; }
    }
}
