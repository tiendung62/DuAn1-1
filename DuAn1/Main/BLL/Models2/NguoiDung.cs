using System;
using System.Collections.Generic;

namespace Main.BLL.Models2
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public string IdnguoiDung { get; set; } = null!;
        public string? IdvaiTro { get; set; }
        public string? Ten { get; set; }
        public string MatKhau { get; set; } = null!;
        public string? Diachi { get; set; }
        public string Email { get; set; } = null!;
        public string? Dthoai { get; set; }
        public string? Trangthai { get; set; }

        public virtual VaiTro? IdvaiTroNavigation { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
