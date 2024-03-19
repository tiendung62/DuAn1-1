using System;
using System.Collections.Generic;

namespace Main.BLL.Models2
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            Ctsanphams = new HashSet<Ctsanpham>();
        }

        public string Idncc { get; set; } = null!;
        public string? Tenncc { get; set; }
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public string? Loaidichvu { get; set; }
        public string? Diachi { get; set; }
        public string? Dieukhoanhoptac { get; set; }

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
