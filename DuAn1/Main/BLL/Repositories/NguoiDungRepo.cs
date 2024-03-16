using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class NguoiDungRepo
    {
        DA1Context context = new DA1Context();
        public List<NguoiDung> getallSPrepo()
        {
            return context.NguoiDungs.ToList();
        }
        public List<NguoiDung> CheckLogin (string email , string password)
        {
            return context.NguoiDungs.Where(x => x.Email == email && x.MatKhau == password).ToList();
        }
        public List<NguoiDung> FindSvByName(string name)
        {
            return context.NguoiDungs.Where(x => x.Ten.ToLower().Contains(name)).ToList();
        }
        public bool them(NguoiDung nguoiDung)
        {
            context.NguoiDungs.Add(nguoiDung);
            context.SaveChanges();
            return true;
        }
        public bool sua(string IDND, NguoiDung nguoiDung)
        {
            try
            {
                var obj = findbyname(IDND);
                if (obj == null)
                {
                    return false;
                }
                obj.IdnguoiDung = nguoiDung.IdnguoiDung;
                obj.IdvaiTro = nguoiDung.IdvaiTro;
                obj.Ten = nguoiDung.Ten;
                obj.MatKhau = nguoiDung.MatKhau;
                obj.Diachi = nguoiDung.Diachi;
                obj.Email = nguoiDung.Email;
                obj.Dthoai = nguoiDung.Dthoai;
                obj.Trangthai = nguoiDung.Trangthai;
                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(NguoiDung xoaND)
        {
            context.NguoiDungs.Remove(xoaND);
            return context.SaveChanges() > 0;
        }
        public NguoiDung findbyname(string ID)
        {
            return context.NguoiDungs.Find(ID);
        }
    }
}
