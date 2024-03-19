using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class DeGiayRepo
    {
        DUAN1Context context = new DUAN1Context();
        public List<Degiay> getallSPrepo()
        {
            return context.Degiays.ToList();
        }
        public List<Degiay> FindSvByName(string name)
        {
            return context.Degiays.Where(x => x.Degiay1.ToLower().Contains(name)).ToList();
        }
        public bool them(Degiay degiay)
        {
            context.Degiays.Add(degiay);
            context.SaveChanges();
            return true;
        }
        public bool sua(string masp, Degiay degiay)
        {
            try
            {
                var obj = findbyname(masp);
                if (obj == null)
                {
                    return false;
                }
                obj.Degiay1 = degiay.Degiay1;


                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Degiay degiay)
        {
            context.Degiays.Remove(degiay);
            return context.SaveChanges() > 0;
        }
        public Degiay findbyname(string ID)
        {
            return context.Degiays.Find(ID);
        }
    }
}
