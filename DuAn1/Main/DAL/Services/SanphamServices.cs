using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class SanphamServices
    {
        SanPhamRepo _repo = new SanPhamRepo();

        public List<Sanpham> GetSanphams()
        {
            return _repo.getallSPrepo().ToList() ;
        }
        public bool AddSP(string ten, int soluong, int giaban, string trangthai)
        {
            var sanpham = new Sanpham
            {
                Tensp = ten,
                Soluong = soluong,
                Giaban = giaban,
                Trangthai = trangthai
            };
            return _repo.them(sanpham) ;
        }
        public bool UpdateSP(string id , string name,int soluong, int giaban, string trangthai )
        {
            Sanpham sanpham = new Sanpham
            {
                Masp = id,
                Tensp = name,
                Soluong = soluong,
                Giaban = giaban,
                Trangthai = trangthai
            };
            return _repo.sua(id, sanpham);
        }
        public List<Sanpham> GetSanphamsByName(string name)
        {
            return _repo.FindSPByName(name).ToList();
        }
        public bool DeleteSP(string id)
        {
            return _repo.xoa(id);  
        }
    }
}
