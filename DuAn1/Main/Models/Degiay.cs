using System;
using System.Collections.Generic;

namespace Main.Models
{
    public partial class Degiay
    {
        public Degiay()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Degiay1 { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
