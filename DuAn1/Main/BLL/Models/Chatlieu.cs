using System;
using System.Collections.Generic;

namespace Main.BLL.Models
{
    public partial class Chatlieu
    {
        public Chatlieu()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Chatlieuu { get; set; } = null!;

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
