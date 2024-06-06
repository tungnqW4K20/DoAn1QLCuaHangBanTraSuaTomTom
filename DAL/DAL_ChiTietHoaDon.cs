using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHoaDon
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(ChiTietHoaDonBan cthdb)
        {
            db.ChiTietHoaDonBans.Add(cthdb);
            db.SaveChanges();
        }

        public void Delete(ChiTietHoaDonBan cthdb)
        {
            db.ChiTietHoaDonBans.Remove(cthdb);
            db.SaveChanges();
        }

        public void DeletetheoMaHD(string MaHD)
        {
            var deleteNV = db.ChiTietHoaDonBans.Where(e => e.MaHoaDonBan == MaHD).ToList();

            db.ChiTietHoaDonBans.RemoveRange(deleteNV);
            db.SaveChanges();
        }//dùng để xóa chi tiết hóa đơn theo

        public bool CheckHD(string MaHD)
        {
            var user = db.ChiTietHoaDonBans.FirstOrDefault(x => x.MaHoaDonBan == MaHD);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public List<ChiTietHoaDonBan> GetAll()
        {
            return db.ChiTietHoaDonBans.ToList();
        }

        public ChiTietHoaDonBan GetByID(string id)
        {
            return db.ChiTietHoaDonBans.Find(id);
        }

        public void Update(ChiTietHoaDonBan cthdb)
        {
            ChiTietHoaDonBan p = db.ChiTietHoaDonBans.Find(cthdb.MaChiTietHoaDonBan);
            p.MaHoaDonBan = cthdb.MaHoaDonBan;
            p.MaDoUong = cthdb.MaDoUong;
            p.SoLuongS = cthdb.SoLuongS;
            p.SoLuongM = cthdb.SoLuongM;
            p.SoLuongL = cthdb.SoLuongL;
            p.ThanhTien = cthdb.ThanhTien;
            db.SaveChanges();
        }
    }
}
