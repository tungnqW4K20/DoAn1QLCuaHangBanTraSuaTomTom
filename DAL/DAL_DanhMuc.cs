using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DanhMuc
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(DanhMucDoUong nv)
        {
            db.DanhMucDoUongs.Add(nv);
            db.SaveChanges();
        }

        public void Delete(DanhMucDoUong nv)
        {
            db.DanhMucDoUongs.Remove(nv);
            db.SaveChanges();
        }

        public List<DanhMucDoUong> GetAll()
        {
            return db.DanhMucDoUongs.ToList();
        }

        public DanhMucDoUong GetByID(string id)
        {
            return db.DanhMucDoUongs.Find(id);
        }        
        public List<DoUong> LayDanhSachDoUongTheoTenDanhMuc(string tenDanhMuc)
        {
            // Sử dụng LINQ to Entities để lấy danh sách đồ uống dựa trên tên danh mục
            var danhSachDoUong = (from du in db.DoUongs
                                  where du.DanhMucDoUong.TenDanhMuc == tenDanhMuc
                                  select du).ToList();

            return danhSachDoUong;
        }

    }
}
