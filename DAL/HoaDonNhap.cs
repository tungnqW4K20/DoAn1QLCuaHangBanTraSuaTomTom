using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHoaDonNhap
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(HoaDonNhap hdn)
        {
            db.HoaDonNhaps.Add(hdn);
            db.SaveChanges();
        }

        public void Delete(HoaDonNhap hdn)
        {
            db.HoaDonNhaps.Remove(hdn);
            db.SaveChanges();
        }

        public List<HoaDonNhap> GetAll()
        {
            return db.HoaDonNhaps.ToList();
        }

        public HoaDonNhap GetByID(string id)
        {
            return db.HoaDonNhaps.Find(id);
        }

        public void Update(HoaDonNhap hdn)
        {
            HoaDonNhap p = db.HoaDonNhaps.Find(hdn.MaHoaDon);
            p.MaNhaCC = hdn.MaNhaCC;
            p.MaNV = hdn.MaNV;
            p.NgayNhap = hdn.NgayNhap;
            db.SaveChanges();
        }
    }
}
