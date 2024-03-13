using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class Mausac
    {
        public Mausac()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Mau { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
