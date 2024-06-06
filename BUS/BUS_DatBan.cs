using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DatBan
    {
        private DAL_DatBan dalTrangThaiBan = new DAL_DatBan();

        public void Add(TrangThaiBan trangtban)
        {
            dalTrangThaiBan.Add(trangtban);
        }

        public bool Delete(int SoBan)
        {
            TrangThaiBan du = GetByID(SoBan);
            if (du != null)
            {
                dalTrangThaiBan.Delete(du);
                return true;
            }
            return false;
        }

        public List<TrangThaiBan> GetAll()
        {
            return dalTrangThaiBan.GetAll();
        }

        public TrangThaiBan GetByID(int id)
        {
            return dalTrangThaiBan.GetByID(id);
        }


        //public decimal GetTienS(string id)
        //{
        //    return (decimal)GetByID(id).GiaS;
        //}
        //public decimal GetTienL(string id)
        //{
        //    return (decimal)GetByID(id).GiaL;
        //}

        //public decimal GetTienM(string id)
        //{
        //    return (decimal)GetByID(id).GiaM;
        //}


        //public List<TrangThaiBan> SearchTrangThaiBanByID(string categoryID)
        //{
        //    return GetAll().Where(x => x.MaTrangThaiBan == categoryID).ToList();
        //}



        //public List<TrangThaiBan> SearchTrangThaiBanByDanhMuc(string categoryID)
        //{
        //    return GetAll().Where(x => x.MaDanhMuc == categoryID).ToList();
        //}



        //public List<TrangThaiBan> SearchTrangThaiBanByName(string keyword)
        //{
        //    return GetAll().Where(x => x.TenTrangThaiBan.ToLower().Contains(keyword.ToLower())).ToList();
        //}

        public bool Update(TrangThaiBan du)
        {
            if (GetByID(du.SoBan) != null)
            {
                dalTrangThaiBan.Update(du);
                return true;
            }
            return false;
        }


    }
}
