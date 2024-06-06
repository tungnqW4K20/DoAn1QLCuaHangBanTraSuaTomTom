using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        private DAL_ChiTietHoaDon dalcthdb = new DAL_ChiTietHoaDon();

        public void Add(ChiTietHoaDonBan cthdb)
        {
            dalcthdb.Add(cthdb);
        }

        public bool Delete(string MaChiTietHoaDonBan)
        {
            ChiTietHoaDonBan cthdb = GetByID(MaChiTietHoaDonBan);
            if (cthdb != null)
            {
                dalcthdb.Delete(cthdb);
                return true;
            }
            return false;
        }



        public bool DeleteMaHD(string MaHD)
        {
            if (dalcthdb.CheckHD(MaHD) == true)
            {
                dalcthdb.DeletetheoMaHD(MaHD);

                return true;

            }

            return false;
             

        }


        public List<ChiTietHoaDonBan> GetAll()
        {
            return dalcthdb.GetAll();
        }

        public ChiTietHoaDonBan GetByID(string id)
        {
            return dalcthdb.GetByID(id);
        }

        //public string GetProductName(string id)
        //{
        //    return GetByID(id).Tencthdb;
        //}

        public List<ChiTietHoaDonBan> SearchChiTietHoaDonBanByID(string categoryID)
        {
            return GetAll().Where(x => x.MaChiTietHoaDonBan == categoryID).ToList();
        }

        public List<ChiTietHoaDonBan> SearchChiTietHoaDonBanByHD(string keyword)
        {
            return GetAll().Where(x => x.MaHoaDonBan.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public List<ChiTietHoaDonBan> SearchChiTietHoaDonBanByMaDU(string keyword)
        {
            return GetAll().Where(x => x.MaDoUong.ToLower().Contains(keyword.ToLower())).ToList();
        }


        public bool Update(ChiTietHoaDonBan cthdb)
        {
            if (GetByID(cthdb.MaChiTietHoaDonBan) != null)
            {
                dalcthdb.Update(cthdb);
                return true;
            }
            return false;
        }
    }
}
