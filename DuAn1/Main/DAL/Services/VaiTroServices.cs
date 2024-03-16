using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class VaiTroServices
    {
        VaiTroRepo vtrepo = new VaiTroRepo();

        public List<VaiTro> GetVaiTros()
        {
            return vtrepo.getallVaiTro().ToList();
        }
    }
}
