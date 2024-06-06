using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DoUong
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();

        public void Add(DoUong product)
        {
            db.DoUongs.Add(product);
            db.SaveChanges();

        }

        public void Delete(DoUong product)
        {
            db.DoUongs.Remove(product);
            db.SaveChanges();
        }

        public List<DoUong> GetAll()
        {
            return db.DoUongs.ToList();
        }


        public DoUong GetByID(string id)
        {
            return db.DoUongs.Find(id);
        }


        public void Update(DoUong product)
        {
            DoUong p = db.DoUongs.Find(product.MaDoUong);
            p.TenDoUong = product.TenDoUong;
            p.MaDanhMuc = product.MaDanhMuc;
            p.GiaS = product.GiaS;
            p.GiaM = product.GiaM;
            p.GiaL = product.GiaL;
            db.SaveChanges();
        }

    }
}
