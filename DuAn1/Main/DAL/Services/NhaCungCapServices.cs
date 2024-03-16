using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class NhaCungCapServices
    {
        NhaCungCapRepo repo = new NhaCungCapRepo();
        public List<NhaCungCap> GetNhaCungCaps()
        {
            return repo.GetNhaCungCaps().ToList();
        }
    }
}
