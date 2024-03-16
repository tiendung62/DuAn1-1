using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WinFormsApp1.Repositories
{
    internal class HoaDonRepo
    {
        DA1Context context = new DA1Context();
        public List<Hoadon> getallSPrepo()
        {
            return context.Hoadons.ToList();
        }
        public List<Hoadon> FindSvByName(string name)
        {
            return context.Hoadons.Where(x => x.Tensp.ToLower().Contains(name)).ToList();
        }
        public bool them(Hoadon hoadon)
        {
            context.Hoadons.Add(hoadon);
            context.SaveChanges();
            return true;
        }
        public bool sua(string masp, Hoadon hoadon)
        {
            try
            {
                var obj = findbyname(masp);
                if (obj == null)
                {
                    return false;
                }
                obj.Mahd = hoadon.Mahd;
                obj.Idkh = hoadon.Idkh;
                obj.IdnguoiDung = hoadon.IdnguoiDung;
                obj.Ngayban = hoadon.Ngayban;
                obj.Tensp = hoadon.Tensp;
                obj.Soluong = hoadon.Soluong;
                obj.Tongtien = hoadon.Tongtien;
                obj.Trangthai = hoadon.Trangthai;
               
                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Hoadon xoahd)
        {
            context.Hoadons.Remove(xoahd);
            return context.SaveChanges() > 0;
        }
        public Hoadon findbyname(string ID)
        {
            return context.Hoadons.Find(ID);
        }
    }
}
