using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class SanphamServices
    {

        public List<Sanpham> GetSanphams(List<Sanpham> list)
        {
            return list;
        }
        public Sanpham AddSP(string ten, int soluong, int giaban, string trangthai )
        {
            Sanpham sanpham = new Sanpham
            {
                Tensp = ten,
                Soluong = soluong,
                Giaban = giaban,
                Trangthai = trangthai
            };
            return sanpham;
        }
        public Sanpham UpdateSP(string id , string name,int soluong, int giaban, string trangthai )
        {
            Sanpham sanpham = new Sanpham
            {
                Masp = id,
                Tensp = name,
                Soluong = soluong,
                Giaban = giaban,
                Trangthai = trangthai
            };
            return sanpham;
        }
        public List<Sanpham> GetSanphamsByName(string name , List<Sanpham> list)
        {
            return list;
        }
        public string DeleteSP(string id )
        {
            return id;
        }
    }
}
