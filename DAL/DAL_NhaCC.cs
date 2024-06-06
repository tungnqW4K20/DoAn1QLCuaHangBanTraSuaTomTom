using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaCC
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(NhaCungCap ncc)
        {
            db.NhaCungCaps.Add(ncc);
            db.SaveChanges();
        }

        public void Delete(NhaCungCap ncc)
        {
            db.NhaCungCaps.Remove(ncc);
            db.SaveChanges();
        }

        public List<NhaCungCap> GetAll()
        {
            return db.NhaCungCaps.ToList();
        }

        public NhaCungCap GetByID(string id)
        {
            return db.NhaCungCaps.Find(id);
        }

        public void Update(NhaCungCap ncc)
        {
            NhaCungCap p = db.NhaCungCaps.Find(ncc.MaNhaCC);
            p.TenNhaCC = ncc.TenNhaCC;
            p.DiaChiNhaCC = ncc.DiaChiNhaCC;
            
            p.SDTNhaCC = ncc.SDTNhaCC;
            
            db.SaveChanges();
        }
    }
}
