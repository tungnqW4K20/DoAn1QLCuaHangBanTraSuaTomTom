using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dal_TaiKhoan
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add (TaiKhoan user)
        {       
            db.TaiKhoans.Add (user);
            db.SaveChanges();
        }


        public TaiKhoan GetByID(string id)
        {
            return db.TaiKhoans.Find(id);
        }

        public void Delete(TaiKhoan nv)
        {
            db.TaiKhoans.Remove(nv);
            db.SaveChanges();
        }

        public void DeleteNV(string MaNV)
        {
            var deleteNV = db.TaiKhoans.Where(e => e.MaNV==MaNV).ToList();

            db.TaiKhoans.RemoveRange(deleteNV);
            db.SaveChanges();
        }


        public bool CheckTK(string Manv)
        {
            var user = db.TaiKhoans.FirstOrDefault(x => x.MaNV == Manv);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public bool CheckDangNhap(string username,string matkhau)
        {
            var user = db.TaiKhoans.FirstOrDefault( x => x.TenTK== username  && x.MatKhau==matkhau );
            if(user==null)
            {
                return false;
            }
            return true;
        }
    }
}
