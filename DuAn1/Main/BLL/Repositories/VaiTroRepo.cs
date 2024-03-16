using Main.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WinFormsApp1.Repositories
{
    internal class VaiTroRepo
    {
        DA1Context context = new DA1Context();
        public List<VaiTro> getallVaiTroRepo()
        {
            return context.VaiTros.ToList();
        }
    }
}
