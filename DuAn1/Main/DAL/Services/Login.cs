using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DAL.Services
{
    internal class Login
    {
        public List<NguoiDung> getAll(List<NguoiDung> list)
        {
            return list.ToList();
        }
        public bool CheckLogin(string tk , string mk , List<NguoiDung> list)
        {
            if (getAll(list).Where(x => x.Email == tk && x.MatKhau == mk).ToList().Count() > 0)
            {
                return true;
            } else 
            {
                return false; 
            }
        }
    }
}
