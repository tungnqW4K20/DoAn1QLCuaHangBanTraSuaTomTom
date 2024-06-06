using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DAL
{
    public class DAL_ChamCong
    {

        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(ChamCong cc)
        {
            db.ChamCongs.Add(cc);
            db.SaveChanges();
        }

        public void Delete(ChamCong cc)
        {
            db.ChamCongs.Remove(cc);
            db.SaveChanges();
        }


        public int STT()
        {

            int sl = db.ChamCongs.Count();

            return sl;
        }
        public List<ChamCong> GetAll()
        {
            return db.ChamCongs.ToList();
        }

        public ChamCong GetByID(int id)
        {
            return db.ChamCongs.Find(id);
        }

        public void Update(ChamCong cc)
        {
            ChamCong p = db.ChamCongs.FirstOrDefault(x => x.MaNV==cc.MaNV && x.Thang==cc.Thang); //db.ChamCongs.Find(cc.ID);

            p.MaNV = cc.MaNV;
            p.Thang = cc.Thang;
            p.ngay1 = cc.ngay1;
            p.ngay2 = cc.ngay2;
            p.ngay3 = cc.ngay3;
            p.ngay4 = cc.ngay4;
            p.ngay5 = cc.ngay5;
            p.ngay6 = cc.ngay6;
            p.ngay7 = cc.ngay7;
            p.ngay8 = cc.ngay8;
            p.ngay9 = cc.ngay9;
            p.ngay10 = cc.ngay10;
            p.ngay11 = cc.ngay11;
            p.ngay12 = cc.ngay12;
            p.ngay13 = cc.ngay13;
            p.ngay14 = cc.ngay14;
            p.ngay15 = cc.ngay15;
            p.ngay16 = cc.ngay16;
            p.ngay17 = cc.ngay17;
            p.ngay18 = cc.ngay18;
            p.ngay19 = cc.ngay19;
            p.ngay20 = cc.ngay20;
            p.ngay21 = cc.ngay21;
            p.ngay22 = cc.ngay22;
            p.ngay23 = cc.ngay23;
            p.ngay24 = cc.ngay24;
            p.ngay25 = cc.ngay25;
            p.ngay26 = cc.ngay26;
            p.ngay27 = cc.ngay27;
            p.ngay28 = cc.ngay28;
            p.ngay29 = cc.ngay29;
            p.ngay30 = cc.ngay30;
            p.ngay31 = cc.ngay31;

            db.SaveChanges();
        }
    }
}
