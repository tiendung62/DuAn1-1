﻿using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1.Repositories
{
    internal class KichThuocRepo
    {
        DUAN1Context context = new DUAN1Context();

        public List<Kichthuoc> getallVaiTroRepo()
        {
            return context.Kichthuocs.ToList();
        }
        public List<Kichthuoc> FindSvByName(string name)
        {
            return context.Kichthuocs.Where(x => x.Kichthuoc1.ToLower().Contains(name)).ToList();
        }
        public bool them(Kichthuoc kichthuoc)
        {
            context.Kichthuocs.Add(kichthuoc);
            return context.SaveChanges() > 0 ;
            
        }
        public bool sua(string IDND, Kichthuoc kichthuoc)
        {
            try
            {
                var obj = findbyname(IDND);
                if (obj == null)
                {
                    return false;
                }
                obj.Kichthuoc1 = kichthuoc.Kichthuoc1;
              

                context.Update(obj);
                return context.SaveChanges() > 0;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoa(Kichthuoc kichthuoc)
        {
            context.Kichthuocs.Remove(kichthuoc);
            return context.SaveChanges() > 0;
        }
        public Kichthuoc findbyname(string ID)
        {
            return context.Kichthuocs.Find(ID);
        }
    }
}
