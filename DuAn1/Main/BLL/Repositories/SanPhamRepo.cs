using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WinFormsApp1.Repositories
{
    internal class SanPhamRepo
    {
        DA1Context context = new DA1Context();
        public List<Sanpham> getallSPrepo()
        {
            return context.Sanphams.ToList();
        }
        public List<Sanpham> FindSvByName(string name)
        {
            return context.Sanphams.Where(x => x.Tensp.ToLower().Contains(name)).ToList();
        }
        public bool them(Sanpham sanpham)
        {
            context.Sanphams.Add(sanpham);
            return context.SaveChanges() > 0;
        }
        public bool sua(string masp, Sanpham sanpham)
        {
            try
            {
                var obj = findbyname(masp);
                if (obj == null)
                {
                    return false;
                }
                obj.Masp = sanpham.Masp;
                obj.Tensp = sanpham.Tensp;
                obj.Soluong = sanpham.Soluong;
                obj.Giaban = sanpham.Giaban;
                obj.Trangthai = sanpham.Trangthai;
                context.Update(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Sanpham xoasp)
        {
            context.Sanphams.Remove(xoasp);
            return context.SaveChanges() > 0;
        }
        public Sanpham findbyname(string ID)
        {
            return context.Sanphams.Find(ID);
        }
    }
}
