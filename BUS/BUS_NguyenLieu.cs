using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NguyenLieu
    {
        private DAL_NguyenLieu dalNL = new DAL_NguyenLieu();

        public void Add(NguyenLieu nl)
        {
            dalNL.Add(nl);
        }

        public bool Delete(string MaNguyenLieu)
        {
            NguyenLieu nv = GetByID(MaNguyenLieu);
            if (nv != null)
            {
                dalNL.Delete(nv);
                return true;
            }
            return false;
        }

        public List<NguyenLieu> GetAll()
        {
            return dalNL.GetAll();
        }

        public NguyenLieu GetByID(string id)
        {
            return dalNL.GetByID(id);
        }

        public string GetProductName(string id)
        {
            return GetByID(id).TenNguyenLieu;
        }

        public decimal GetDonGia(string id)
        {
            return (decimal)GetByID(id).DonGia;
        }


        public List<NguyenLieu> SearchNguyenLieuByID(string categoryID)
        {
            return GetAll().Where(x => x.MaNguyenLieu == categoryID).ToList();
        }

        public List<NguyenLieu> SearchNguyenLieuByName(string keyword)
        {
            return GetAll().Where(x => x.TenNguyenLieu.ToLower().Contains(keyword.ToLower())).ToList();
        }

        


        public bool Update(NguyenLieu nv)
        {
            if (GetByID(nv.MaNguyenLieu) != null)
            {
                dalNL.Update(nv);
                return true;
            }
            return false;
        }
    }
}
