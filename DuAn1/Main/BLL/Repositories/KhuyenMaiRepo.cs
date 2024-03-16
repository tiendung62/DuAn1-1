using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class KhuyenMaiRepo
    {
        DA1Context context = new DA1Context();
        public List<Khuyenmai> getallVaiTroRepo()
        {
            return context.Khuyenmais.ToList();
        }
        public List<Khuyenmai> FindSvByName(string name)
        {
            return context.Khuyenmais.Where(x => x.Sukienkm.ToLower().Contains(name)).ToList();
        }
        public bool them(Khuyenmai khuyenmai)
        {
            context.Khuyenmais.Add(khuyenmai);
            context.SaveChanges();
            return true;
        }
        public bool sua(string IDND, Khuyenmai khuyenmai)
        {
            try
            {
                var obj = findbyname(IDND);
                if (obj == null)
                {
                    return false;
                }
                obj.Idkm = khuyenmai.Idkm;
                obj.Sukienkm = khuyenmai.Sukienkm;
                obj.Giamgia = khuyenmai.Giamgia;
                obj.Ngaytao = khuyenmai.Ngaytao;
                obj.Trangthai = khuyenmai.Trangthai;
                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Khuyenmai xoakhuyenmai)
        {
            context.Khuyenmais.Remove(xoakhuyenmai);
            return context.SaveChanges() > 0;
        }
        public Khuyenmai findbyname(string ID)
        {
            return context.Khuyenmais.Find(ID);
        }
    }
}
