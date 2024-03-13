using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class Kichthuoc
    {
        public Kichthuoc()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Kichthuoc1 { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
