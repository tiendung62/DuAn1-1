using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class MauSacRepo
    {
        DUAN1Context context = new DUAN1Context();

        public List<Mausac> getallVaiTroRepo()
        {
            return context.Mausacs.ToList();
        }
        public List<Mausac> FindSvByName(string name)
        {
            return context.Mausacs.Where(x => x.Mau.ToLower().Contains(name)).ToList();
        }
        public bool them(Mausac mausac)
        {
            context.Mausacs.Add(mausac);
            context.SaveChanges();
            return true;
        }
        public bool sua(string IDND, Mausac mausac)
        {
            try
            {
                var obj = findbyname(IDND);
                if (obj == null)
                {
                    return false;
                }
                obj.Mau = mausac.Mau;
                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Mausac xoamausac )
        {
            context.Mausacs.Remove(xoamausac);
            return context.SaveChanges() > 0;
        }
        public Mausac findbyname(string ID)
        {
            return context.Mausacs.Find(ID);
        }
    }
}
