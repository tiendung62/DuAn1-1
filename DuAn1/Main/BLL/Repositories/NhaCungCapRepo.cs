using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class NhaCungCapRepo
    {
        DUAN1Context context = new DUAN1Context();

        public List<NhaCungCap> getallSPrepo()
        {
            return context.NhaCungCaps.ToList();
        }
        public List<NhaCungCap> FindSvByName(string name)
        {
            return context.NhaCungCaps.Where(x => x.Tenncc.ToLower().Contains(name)).ToList();
        }
        public bool them(NhaCungCap nhaCungCap)
        {
            context.NhaCungCaps.Add(nhaCungCap);
            context.SaveChanges();
            return true;
        }
        public bool sua(string IDNCC, NhaCungCap nhaCungCap)
        {
            try
            {
                var obj = findbyname(IDNCC);
                if (obj == null)
                {
                    return false;
                }
                obj.Idncc = nhaCungCap.Idncc;
                obj.Tenncc = nhaCungCap.Tenncc;
                obj.Email = nhaCungCap.Email;
                obj.Sdt = nhaCungCap.Sdt;
                obj.Loaidichvu = nhaCungCap.Loaidichvu;
                obj.Diachi = nhaCungCap.Diachi;
                obj.Dieukhoanhoptac = nhaCungCap.Dieukhoanhoptac;
                context.Update(obj);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(NhaCungCap xoanhacungcap)
        {
            context.NhaCungCaps.Remove(xoanhacungcap);
            return context.SaveChanges() > 0;
        }
        public NhaCungCap findbyname(string ID)
        {
            return context.NhaCungCaps.Find(ID);
        }
    }
}
