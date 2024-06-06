using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKHoan
    {
        private Dal_TaiKhoan taiK = new Dal_TaiKhoan();
        public void Add(TaiKhoan t) 
        {
            taiK.Add(t);
           
        }
        public TaiKhoan GetByID(string id)
        {
            return taiK.GetByID(id);
        }


        public bool Delete(string MaNV)
        {
           if(taiK.CheckTK(MaNV)==true)
            {
                taiK.DeleteNV(MaNV);
                return true;
            }
            return false;

        }


        public string GetLoaiTK(string id)
        {
            return GetByID(id).LoaiTK;
        }
        public bool CheckDangNhap(string username,string matkhau)
        {

            return taiK.CheckDangNhap(username, matkhau);

        }


    }
}
