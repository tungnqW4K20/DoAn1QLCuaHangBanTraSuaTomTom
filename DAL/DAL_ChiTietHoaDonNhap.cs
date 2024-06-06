using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHoaDonNhap
    {

        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(ChiTietHoaDonNhap cthdn)
        {
            db.ChiTietHoaDonNhaps.Add(cthdn);
            db.SaveChanges();
        }

        public void Delete(ChiTietHoaDonNhap cthdn)
        {
            db.ChiTietHoaDonNhaps.Remove(cthdn);
            db.SaveChanges();
        }
        public bool CheckHD(string MaHD)
        {
            var user = db.ChiTietHoaDonNhaps.FirstOrDefault(x => x.MaHoaDon == MaHD);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public void DeletetheoMaHD(string MaHD)
        {
            var deleteNV = db.ChiTietHoaDonNhaps.Where(e => e.MaHoaDon == MaHD).ToList();

            db.ChiTietHoaDonNhaps.RemoveRange(deleteNV);
            db.SaveChanges();
        }//xóa theo mã hóa đơn là chi tiết cũng bay màu

        public List<ChiTietHoaDonNhap> GetAll()
        {
            return db.ChiTietHoaDonNhaps.ToList();
        }

        public ChiTietHoaDonNhap GetByID(string id)
        {
            return db.ChiTietHoaDonNhaps.Find(id);
        }

        public void Update(ChiTietHoaDonNhap cthdn)
        {
            ChiTietHoaDonNhap p = db.ChiTietHoaDonNhaps.Find(cthdn.MaChiTietHoaDon);
            p.MaHoaDon = cthdn.MaHoaDon;
            p.MaNguyenLieu = cthdn.MaNguyenLieu;
            p.SoLuong = cthdn.SoLuong;
            p.DonGia = cthdn.DonGia;
            p.ThanhTien = cthdn.ThanhTien;
            db.SaveChanges();
        }
    }
}
