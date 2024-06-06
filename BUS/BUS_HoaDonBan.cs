using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDonBan
    {
        private DAL_HoaDon dalhdb = new DAL_HoaDon();

        public void Add(HoaDonBan hdb)
        {
            dalhdb.Add(hdb);
        }

        public bool Delete(string Mahdb)
        {
            HoaDonBan hdb = GetByID(Mahdb);
            if (hdb != null)
            {
                dalhdb.Delete(hdb);
                return true;
            }
            return false;
        }

        public List<HoaDonBan> GetAll()
        {
            return dalhdb.GetAll();
        }

        public HoaDonBan GetByID(string id)
        {
            return dalhdb.GetByID(id);
        }

        //public string GetProductName(string id)
        //{
        //    return GetByID(id).;
        //}

        public List<HoaDonBan> SearchHoaDonBanByID(string categoryID)
        {
            return GetAll().Where(x => x.MaHoaDonBan == categoryID).ToList();
        }

        public List<HoaDonBan> SearchHoaDonBanByMaNV(string MaNV)
        {
            return GetAll().Where(x => x.MaNV == MaNV).ToList();
        }

        public List<HoaDonBan> SearchHoaDonBanByMaKH(string MaKH)
        {
            return GetAll().Where(x => x.MaKH == MaKH).ToList();
        }


        //public List<HoaDonBan> SearchHoaDonBanByName(string keyword)
        //{
        //    return GetAll().Where(x => x.Tenhdb.ToLower().Contains(keyword.ToLower())).ToList();
        //}

        //public List<HoaDonBan> SearchHoaDonBanByDiaCHi(string keyword)
        //{
        //    return GetAll().Where(x => x.DiaChi.ToLower().Contains(keyword.ToLower())).ToList();
        //}


        public bool Update(HoaDonBan hdb)
        {
            if (GetByID(hdb.MaHoaDonBan) != null)
            {
                dalhdb.Update(hdb);
                return true;
            }
            return false;
        }
    }
}
