using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhaCC
    {
        private DAL_NhaCC dalNCC = new DAL_NhaCC();

        public void Add(NhaCungCap ncc)
        {
            dalNCC.Add(ncc);
        }

        public bool Delete(string MaNhaCC)
        {
            NhaCungCap ncc = GetByID(MaNhaCC);
            if (ncc != null)
            {
                dalNCC.Delete(ncc);
                return true;
            }
            return false;
        }

        public List<NhaCungCap> GetAll()
        {
            return dalNCC.GetAll();
        }

        public NhaCungCap GetByID(string id)
        {
            return dalNCC.GetByID(id);
        }

        public string GetProductName(string id)
        {
            return GetByID(id).TenNhaCC;
        }

        public List<NhaCungCap> SearchNhaCungCapByID(string categoryID)
        {
            return GetAll().Where(x => x.MaNhaCC == categoryID).ToList();
        }

        public List<NhaCungCap> SearchNhaCungCapByName(string keyword)
        {
            return GetAll().Where(x => x.TenNhaCC.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public List<NhaCungCap> SearchNhaCungCapByDiaCHi(string keyword)
        {
            return GetAll().Where(x => x.DiaChiNhaCC.ToLower().Contains(keyword.ToLower())).ToList();
        }


        public bool Update(NhaCungCap ncc)
        {
            if (GetByID(ncc.MaNhaCC) != null)
            {
                dalNCC.Update(ncc);
                return true;
            }
            return false;
        }
    }
}
