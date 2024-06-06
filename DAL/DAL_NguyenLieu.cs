using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NguyenLieu
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(NguyenLieu nl)
        {
            db.NguyenLieux.Add(nl);
            db.SaveChanges();
        }

        public void Delete(NguyenLieu nl)
        {
            db.NguyenLieux.Remove(nl);
            db.SaveChanges();
        }

        public List<NguyenLieu> GetAll()
        {
            return db.NguyenLieux.ToList();
        }

        public NguyenLieu GetByID(string id)
        {
            return db.NguyenLieux.Find(id);
        }

        public void Update(NguyenLieu nl)
        {
            NguyenLieu p = db.NguyenLieux.Find(nl.MaNguyenLieu);
            p.TenNguyenLieu = nl.TenNguyenLieu;
            p.DonViTinh = nl.DonViTinh;
            p.DonGia = nl.DonGia;
            db.SaveChanges();
        }
    }
}
