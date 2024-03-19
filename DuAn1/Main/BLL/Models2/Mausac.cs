using System;
using System.Collections.Generic;

namespace Main.BLL.Models2
{
    public partial class Mausac
    {
        public Mausac()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Idmau { get; set; } = null!;
        public string Mau { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
