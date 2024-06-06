using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DatBan
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(TrangThaiBan pc)
        {
            db.TrangThaiBans.Add(pc);
            db.SaveChanges();
        }

        public void Delete(TrangThaiBan pc)
        {
            db.TrangThaiBans.Remove(pc);
            db.SaveChanges();
        }

        public List<TrangThaiBan> GetAll()
        {
            return db.TrangThaiBans.ToList();
        }

        public TrangThaiBan GetByID(int id)
        {
            return db.TrangThaiBans.Find(id);
        }

        public TrangThaiBan GetByID2(string id1, string id2)
        {
            return db.TrangThaiBans.Find(id1, id2);
        }

        public void Update(TrangThaiBan pc)
        {
            TrangThaiBan p = db.TrangThaiBans.Find(pc.SoBan);
            p.TrangThai = pc.TrangThai;
            db.SaveChanges();
        }



    }
}
