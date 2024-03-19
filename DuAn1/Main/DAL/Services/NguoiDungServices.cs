using Main.BLL.Models2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using WinFormsApp1.Repositories;

namespace WinFormsApp1.Services
{
    internal class NguoiDungServices
    {
        NguoiDungRepo repo =  new NguoiDungRepo();
        static int counter = 0;
        public bool AddUser(string ten, string matkhau, string diachi, string email, string sdt, string trangthai)

        {
            var user = new NguoiDung
            {
                //IdnguoiDung = GenerateID(),
                Ten = ten,
                MatKhau = matkhau,
                Diachi = diachi,
                Email = email,
                Dthoai = sdt,
                Trangthai = trangthai
            };
            return true;
        }
        public bool UpdateUser(string id, string ten, string matkhau, string diachi, string email, string sdt, string trangthai)
        {
            NguoiDung nguoidung = new NguoiDung
            {
                IdnguoiDung = id,
                Ten = ten,
                MatKhau = matkhau,
                Diachi = diachi,
                Email = email,
                Dthoai = sdt,
                Trangthai = trangthai
            };
            return repo.sua(id, nguoidung);
        }
        static string GenerateID()
        {
            counter++;
            return "ND" + counter.ToString();
        }
        public bool CheckLogin(string email, string password)
        {
            if (repo.CheckLogin(email, password).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
