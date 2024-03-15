using System;
using System.Collections.Generic;

namespace Main.BLL.Models
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
        public int? Sdt { get; set; }
        public string? Loaidichvu { get; set; }
        public string? Diachi { get; set; }
        public string? Dieukhoanhoptac { get; set; }

        public virtual ICollection<Ctsanpham> Ctsanphams { get; set; }
    }
}
