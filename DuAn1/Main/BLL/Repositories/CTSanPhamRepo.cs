using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class CTSanPhamRepo
    {
        DUAN1Context context = new DUAN1Context();
        public List<Ctsanpham> getallSPrepo()
        {
            return context.Ctsanphams.ToList();
        }
        public List<Ctsanpham> FindSvByName(string name)
        {
            return context.Ctsanphams.Where(x => x.Tengiay.ToLower().Contains(name)).ToList();
        }
        public bool them(Ctsanpham ctsanpham)
        {
            context.Ctsanphams.Add(ctsanpham);
            context.SaveChanges();
            return true;
        }
        public bool sua(string masp, Ctsanpham ctsanpham)
        {
            try
            {
                var obj = findbyname(masp);
                if (obj == null)
                {
                    return false;
                }
                obj.Idctsp = ctsanpham.Idctsp;
                obj.Idncc = ctsanpham.Idncc;
                obj.Masp = ctsanpham.Masp;
                obj.Mau = ctsanpham.Mau;
                obj.Chatlieuu = ctsanpham.Chatlieuu;
                obj.Kichthuoc = ctsanpham.Kichthuoc;
                obj.Degiay = ctsanpham.Degiay;
                obj.Tengiay = ctsanpham.Tengiay;
                obj.Giaban = ctsanpham.Giaban;

                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Ctsanpham ctsanpham)
        {
            context.Ctsanphams.Remove(ctsanpham);
            return context.SaveChanges() > 0;
        }
        public Ctsanpham findbyname(string ID)
        {
            return context.Ctsanphams.Find(ID);
        }
    }
}
