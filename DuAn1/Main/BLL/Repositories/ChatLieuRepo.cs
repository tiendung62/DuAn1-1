using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class ChatLieuRepo
    {
        DUAN1Context context = new DUAN1Context();
        public List<Chatlieu> getallSPrepo()
        {
            return context.Chatlieus.ToList();
        }
        public List<Chatlieu> FindSvByName(string name)
        {
            return context.Chatlieus.Where(x => x.Chatlieu1.ToLower().Contains(name)).ToList();
        }
        public bool them(Chatlieu chatlieu)
        {
            context.Chatlieus.Add(chatlieu);
            context.SaveChanges();
            return true;
        }
        public bool sua(string masp, Chatlieu chatlieu)
        {
            try
            {
                var obj = findbyname(masp);
                if (obj == null)
                {
                    return false;
                }
                obj.Chatlieu1 = chatlieu.Chatlieu1;


                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Chatlieu chatlieu)
        {
            context.Chatlieus.Remove(chatlieu);
            return context.SaveChanges() > 0;
        }
        public Chatlieu findbyname(string ID)
        {
            return context.Chatlieus.Find(ID);
        }
    }
}
