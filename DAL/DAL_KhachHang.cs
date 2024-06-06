using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }

        public void Delete(KhachHang kh)
        {
            db.KhachHangs.Remove(kh);
            db.SaveChanges();
        }

        public List<KhachHang> GetAll()
        {
            return db.KhachHangs.ToList();
        }

        public KhachHang GetByID(string id)
        {
            return db.KhachHangs.Find(id);
        }



        public void Update(KhachHang kh)
        {
            KhachHang p = db.KhachHangs.Find(kh.MaKhachHang);
            p.TenKH = kh.TenKH;
            p.DiaChiKH = kh.DiaChiKH;
            p.SDTKH = kh.SDTKH;
            db.SaveChanges();
        }
    }
}
