using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dalKH = new DAL_KhachHang();

        public void Add(KhachHang kh)
        {
            dalKH.Add(kh);
        }

        public bool Delete(string Makh)
        {
            KhachHang kh = GetByID(Makh);
            if (kh != null)
            {
                dalKH.Delete(kh);
                return true;
            }
            return false;
        }

        public List<KhachHang> GetAll()
        {
            return dalKH.GetAll();
        }

        public KhachHang GetByID(string id)
        {
            return dalKH.GetByID(id);
        }

        public string GetProductName(string id)
        {
            return GetByID(id).TenKH;
        }

        public List<KhachHang> SearchKhachHangByID(string categoryID)
        {
            return GetAll().Where(x => x.MaKhachHang == categoryID).ToList();
        }

        public List<KhachHang> SearchKhachHangByName(string keyword)
        {
            return GetAll().Where(x => x.TenKH.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public List<KhachHang> SearchKhachHangByDiaCHi(string keyword)
        {
            return GetAll().Where(x => x.DiaChiKH.ToLower().Contains(keyword.ToLower())).ToList();
        }


        public bool Update(KhachHang kh)
        {
            if (GetByID(kh.MaKhachHang) != null)
            {
                dalKH.Update(kh);
                return true;
            }
            return false;
        }
    }
}
