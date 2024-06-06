using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhaChe
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(PhaChe pc)
        {
            db.PhaChes.Add(pc);
            db.SaveChanges();
        }

        public void Delete(PhaChe pc)
        {
            db.PhaChes.Remove(pc);
            db.SaveChanges();
        }

        public List<PhaChe> GetAll()
        {
            return db.PhaChes.ToList();
        }

        public PhaChe GetByID(string id)
        {
            return db.PhaChes.Find(id);
        }

        public PhaChe GetByID2(string id1,string id2)
        {
            return db.PhaChes.Find(id1,id2);
        }

        public void Update(PhaChe pc)
        {
            PhaChe p = db.PhaChes.Find(pc.MaDoUong,pc.MaNguyenLieu);
           p.MaNguyenLieu = pc.MaNguyenLieu;
            p.DinhLuong = pc.DinhLuong;
            p.DonViTinh = pc.DonViTinh;
           
            db.SaveChanges();
        }
    }
}
