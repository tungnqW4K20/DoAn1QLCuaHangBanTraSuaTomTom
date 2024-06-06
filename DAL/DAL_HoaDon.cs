using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(HoaDonBan hdb)
        {
            db.HoaDonBans.Add(hdb);
            db.SaveChanges();
        }

        public void Delete(HoaDonBan hdb)
        {
            db.HoaDonBans.Remove(hdb);
            db.SaveChanges();
        }

        public List<HoaDonBan> GetAll()
        {
            return db.HoaDonBans.ToList();
        }

        public HoaDonBan GetByID(string id)
        {
            return db.HoaDonBans.Find(id);
        }

        public void Update(HoaDonBan hdb)
        {
            HoaDonBan p = db.HoaDonBans.Find(hdb.MaHoaDonBan);
            p.MaNV = hdb.MaNV;
            p.MaKH = hdb.MaKH;
            p.NgayBan = hdb.NgayBan;
            p.TrangThai = hdb.TrangThai;
            
            db.SaveChanges();
        }


    }
}
