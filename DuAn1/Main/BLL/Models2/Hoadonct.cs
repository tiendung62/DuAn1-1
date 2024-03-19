using System;
using System.Collections.Generic;

namespace Main.BLL.Models2
{
    public partial class Hoadonct
    {
        public string Mahd { get; set; } = null!;
        public string Idctsp { get; set; } = null!;
        public int? Slban { get; set; }
        public decimal? Gia { get; set; }
        public DateTime? Ngayban { get; set; }

        public virtual Ctsanpham IdctspNavigation { get; set; } = null!;
        public virtual Hoadon MahdNavigation { get; set; } = null!;
    }
}
