using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDonNhap
    {
        private DAL_ChiTietHoaDonNhap dalcthdn = new DAL_ChiTietHoaDonNhap();

        public void Add(ChiTietHoaDonNhap cthdn)
        {
            dalcthdn.Add(cthdn);
        }

        public bool Delete(string MaChiTietHoaDonNhap)
        {
            ChiTietHoaDonNhap cthdn = GetByID(MaChiTietHoaDonNhap);
            if (cthdn != null)
            {
                dalcthdn.Delete(cthdn);
                return true;
            }
            return false;
        }



        public bool DeleteMaHD(string MaHD)
        {
            if (dalcthdn.CheckHD(MaHD) == true)
            {
                dalcthdn.DeletetheoMaHD(MaHD);

                return true;

            }

            return false;

        }


        public List<ChiTietHoaDonNhap> GetAll()
        {
            return dalcthdn.GetAll();
        }

        public ChiTietHoaDonNhap GetByID(string id)
        {
            return dalcthdn.GetByID(id);
        }

        //public string GetProductName(string id)
        //{
        //    return GetByID(id).Tencthdn;
        //}

        public List<ChiTietHoaDonNhap> SearchChiTietHoaDonNhapByID(string categoryID)
        {
            return GetAll().Where(x => x.MaChiTietHoaDon == categoryID).ToList();
        }

        public List<ChiTietHoaDonNhap> SearchChiTietHoaDonNhapByHD(string keyword)
        {
            return GetAll().Where(x => x.MaHoaDon.ToLower().Contains(keyword.ToLower())).ToList();
        }

        //public List<ChiTietHoaDonNhap> SearchChiTietHoaDonNhapByDiaCHi(string keyword)
        //{
        //    return GetAll().Where(x => x.DiaChi.ToLower().Contains(keyword.ToLower())).ToList();
        //}


        public bool Update(ChiTietHoaDonNhap cthdn)
        {
            if (GetByID(cthdn.MaChiTietHoaDon) != null)
            {
                dalcthdn.Update(cthdn);
                return true;
            }
            return false;
        }
    }
}
