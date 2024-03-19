using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class LoaiKhachHangRepo
    {
        DUAN1Context context = new DUAN1Context();

        public List<Loaikhachhang> getallVaiTroRepo()
        {
            return context.Loaikhachhangs.ToList();
        }
    }
}
