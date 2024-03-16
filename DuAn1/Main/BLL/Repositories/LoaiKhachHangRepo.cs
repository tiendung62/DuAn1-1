using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class LoaiKhachHangRepo
    {
        DA1Context context = new DA1Context();
        public List<Loaikhachhang> getallVaiTroRepo()
        {
            return context.Loaikhachhangs.ToList();
        }
    }
}
