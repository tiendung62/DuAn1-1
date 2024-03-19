using System;
using System.Collections.Generic;

namespace Main.BLL.Models2
{
    public partial class Degiay
    {
        public Degiay()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string IdDegiay { get; set; } = null!;
        public string Degiay1 { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
