using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DoUong
    {

        private DAL_DoUong daldouong = new DAL_DoUong();

        public void Add(DoUong douong)
        {
            daldouong.Add(douong);
        }

        public bool Delete(string MaDoUong)
        {
            DoUong du = GetByID(MaDoUong);
            if (du != null)
            {
                daldouong.Delete(du);
                return true;
            }
            return false;
        }

        public List<DoUong> GetAll()
        {
            return daldouong.GetAll();
        }

        public DoUong GetByID(string id)
        {
            return daldouong.GetByID(id);
        }

        public List<DoUong> SearchDMbyMaDoUong(string DM)
        {
            return GetAll().Where(x => x.MaDanhMuc== DM).ToList();
        }


        public string GetProductName(string id)
        {
            return GetByID(id).TenDoUong;
        }

        public decimal GetTienS(string id)
        {
            return (decimal)GetByID(id).GiaS;
        }
        public decimal GetTienL(string id)
        {
            return (decimal)GetByID(id).GiaL;
        }

        public decimal GetTienM(string id)
        {
            return (decimal)GetByID(id).GiaM;
        }


        public List<DoUong> SearchDoUongByID(string categoryID)
        {
            return GetAll().Where(x => x.MaDoUong == categoryID).ToList();
        }



        public List<DoUong> SearchDoUongByDanhMuc(string categoryID)
        {
            return GetAll().Where(x => x.MaDanhMuc == categoryID).ToList();
        }



        public List<DoUong> SearchDoUongByName(string keyword)
        {
            return GetAll().Where(x => x.TenDoUong.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public bool Update(DoUong du)
        {
            if (GetByID(du.MaDoUong) != null)
            {
                daldouong.Update(du);
                return true;
            }
            return false;
        }

    }
}
