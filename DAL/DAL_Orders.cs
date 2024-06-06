using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Order
    {
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        public void Add(Order ncc)
        {
            db.Orders.Add(ncc);
            db.SaveChanges();
        }

       
        public void Delete(Order ncc)
        {
            db.Orders.Remove(ncc);
            db.SaveChanges();
        }


        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public Order GetByID(int id)
        {
            return db.Orders.Find(id);
        }

        public void Update(Order ncc)
        {
            Order p = db.Orders.Find(ncc.ID);
            p.SoBan = ncc.SoBan;
            p.MaDoUong = ncc.MaDoUong;

            p.SoLuongS = ncc.SoLuongS;
            p.SoLuongM = ncc.SoLuongM;
            p.SoLuongL = ncc.SoLuongL;
            db.SaveChanges();
        }

    }
}
