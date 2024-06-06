using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDonNhap
    {


        private DALHoaDonNhap dalNV = new DALHoaDonNhap();

        public void Add(HoaDonNhap nv)
        {
            dalNV.Add(nv);
        }

        public bool Delete(string MaHoaDonNhap)
        {
            HoaDonNhap nv = GetByID(MaHoaDonNhap);
            if (nv != null)
            {
                dalNV.Delete(nv);
                return true;
            }
            return false;
        }

        public List<HoaDonNhap> GetAll()
        {
            return dalNV.GetAll();
        }

        public HoaDonNhap GetByID(string id)
        {
            return dalNV.GetByID(id);
        }

        //public string GetProductName(string id)
        //{
        //    return GetByID(id).TenNV;
        //}

        public List<HoaDonNhap> SearchHoaDonNhapByID(string categoryID)
        {
            return GetAll().Where(x => x.MaHoaDon== categoryID).ToList();
        }

        public List<HoaDonNhap> SearchHoaDonNhapByMaNhaCC(string categoryID)
        {
            return GetAll().Where(x => x.MaNhaCC == categoryID).ToList();
        }

        //public List<HoaDonNhap> SearchHoaDonNhapByName(string keyword)
        //{
        //    return GetAll().Where(x => x.TenNV.ToLower().Contains(keyword.ToLower())).ToList();
        //}

        //public List<HoaDonNhap> SearchHoaDonNhapByDiaCHi(string keyword)
        //{
        //    return GetAll().Where(x => x.DiaChi.ToLower().Contains(keyword.ToLower())).ToList();
        //}


        public bool Update(HoaDonNhap hdn)
        {
            if (GetByID(hdn.MaHoaDon) != null)
            {
                dalNV.Update(hdn);
                return true;
            }
            return false;
        }
    }
}
