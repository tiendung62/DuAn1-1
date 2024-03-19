using System;
using System.Collections.Generic;

namespace Main.BLL.Models2
{
    public partial class Kichthuoc
    {
        public Kichthuoc()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string IdKichthuoc { get; set; } = null!;
        public string Kichthuoc1 { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
