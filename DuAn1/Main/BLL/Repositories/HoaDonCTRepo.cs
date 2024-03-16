using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class HoaDonCTRepo
    {

        DA1Context context = new DA1Context();
        public List<Hoadonct> getallSPrepo()
        {
            return context.Hoadoncts.ToList();
        }
        //public List<Hoadon> FindSvByName(string name)
        //{
        //    return context.Hoadoncts.Where(x => x..ToLower().Contains(name)).ToList();
        //}
        public bool them(Hoadonct hoadonct)
        {
            context.Hoadoncts.Add(hoadonct);
            context.SaveChanges();
            return true;
        }
        public bool sua(string mahd, Hoadonct hoadonct)
        {
            try
            {
                var obj = findbyname(mahd);
                if (obj == null)
                {
                    return false;
                }
                obj.Mahd = hoadonct.Mahd;
                obj.Idctsp = hoadonct.Idctsp;
                obj.Slban = hoadonct.Slban;
                obj.Gia = hoadonct.Gia;
                obj.Ngayban = hoadonct.Ngayban;
               

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
        public Hoadonct findbyname(string ID)
        {
            return context.Hoadoncts.Find(ID);
        }
    }
}
