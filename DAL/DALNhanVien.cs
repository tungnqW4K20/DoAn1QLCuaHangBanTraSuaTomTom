using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhanVien
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        public void Delete(NhanVien nv)
        {
            db.NhanViens.Remove(nv);
            db.SaveChanges();
        }

        public List<NhanVien> GetAll()
        {
            return db.NhanViens.Where(x => x.TrangThai != "Đã Nghỉ").ToList();
        }

        public NhanVien GetByID(string id)
        {
            return db.NhanViens.Find(id);
        }

        public void Update(NhanVien nv)
        {
            NhanVien p = db.NhanViens.Find(nv.MaNV);
            p.TenNV = nv.TenNV;
            p.DiaChi = nv.DiaChi;
            p.ChucVu = nv.ChucVu;
            p.SDT = nv.SDT;
            p.Luong = nv.Luong;
            p.TrangThai = nv.TrangThai;
            db.SaveChanges();
        }
    }
}
