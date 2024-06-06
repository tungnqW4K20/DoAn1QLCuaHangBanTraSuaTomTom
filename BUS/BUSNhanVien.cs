using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUSNhanVien
    {
        private DALNhanVien dalNV = new DALNhanVien();

        public void Add(NhanVien nv)
        {
            dalNV.Add(nv);
        }

        public bool Delete(string MaNV)
        {
            NhanVien nv = GetByID(MaNV);
            if (nv != null)
            {
                dalNV.Delete(nv);
                return true;
            }
            return false;
        }

        public List<NhanVien> GetAll()
        {
            return dalNV.GetAll();
        }

        public NhanVien GetByID(string id)
        {
            return dalNV.GetByID(id);
        }

        public string GetProductName(string id)
        {
            return GetByID(id).TenNV;
        }

        public string GetLuong(string id)
        {

            string luong = Convert.ToString(GetByID(id).Luong);
            return luong;
        }

        public List<NhanVien> SearchNhanvienByID(string categoryID)
        {
            return GetAll().Where(x => x.MaNV == categoryID).ToList();
        }

        public List<NhanVien> SearchNhanvienByName(string keyword)
        {
            return GetAll().Where(x => x.TenNV.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public List<NhanVien> SearchNhanvienByDiaCHi(string keyword)
        {
            return GetAll().Where(x => x.DiaChi.ToLower().Contains(keyword.ToLower())).ToList();
        }


        public bool Update(NhanVien nv)
        {
            if (GetByID(nv.MaNV) != null)
            {
                dalNV.Update(nv);
                return true;
            }
            return false;
        }
    }
}
