using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class VaiTro
    {
        public VaiTro()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        public string IdvaiTro { get; set; } = null!;
        public string? Ten { get; set; }
        public string? Vaitro1 { get; set; }

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
