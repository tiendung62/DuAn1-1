using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class MagiamgiaRepo
    {
        DUAN1Context context = new DUAN1Context();

        public List<Magiamgia> getallVaiTroRepo()
        {
            return context.Magiamgia.ToList();
        }
        public List<Magiamgia> FindMGGByName(string name)
        {
            return context.Magiamgia.Where(x => x.Tenma.ToLower().Contains(name)).ToList();
        }
        public bool them(Magiamgia magiamgia)
        {
            context.Magiamgia.Add(magiamgia);
            context.SaveChanges();
            return true;
        }
        public bool sua(string IDND, Magiamgia magiamgia)
        {
            try
            {
                var obj = findbyname(IDND);
                if (obj == null)
                {
                    return false;
                }
                obj.Idmagiamgia = magiamgia.Idmagiamgia;
                obj.Tenma = magiamgia.Tenma;
                obj.Ngaybatdau = magiamgia.Ngaybatdau;
                obj.Ngayketthuc = magiamgia.Ngayketthuc;
                obj.Phamtramgiam = magiamgia.Phamtramgiam;
                context.Update(obj);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Magiamgia xoama)
        {
            context.Magiamgia.Remove(xoama);
            return context.SaveChanges() > 0;
        }
        public Magiamgia findbyname(string ID)
        {
            return context.Magiamgia.Find(ID);
        }
    }
}
