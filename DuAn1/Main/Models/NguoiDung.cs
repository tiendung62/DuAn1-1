using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public string IdnguoiDung { get; set; } = null!;
        public string? IdvaiTro { get; set; }
        public string? Ten { get; set; }
        public string? MatKhau { get; set; }
        public string? Diachi { get; set; }
        public string? Email { get; set; }
        public string? Dthoai { get; set; }
        public string? Trangthai { get; set; }

        public virtual VaiTro? IdvaiTroNavigation { get; set; }
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
