using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChamCong
    {
        private DAL_ChamCong dalCC = new DAL_ChamCong();

        public void Add(ChamCong cc)
        {
            dalCC.Add(cc);
        }

        public bool Delete(int ID)
        {
            ChamCong cc = GetByID(ID);
            if (cc != null)
            {
                dalCC.Delete(cc);
                return true;
            }
            return false;
        }

        public List<ChamCong> GetAll()
        {
            return dalCC.GetAll();
        }

        public ChamCong GetByID(int id)
        {
            return dalCC.GetByID(id);
        }


        //public string GetProductName(string id)
        //{
        //    return GetByID(id).Tencc;
        //}

        public List<ChamCong> SearchChamCongByID(int categoryID)
        {
            return GetAll().Where(x => x.ID == categoryID).ToList();
        }
        public List<ChamCong> SearchChamCongByManVThang(string MaNV,int Thang)
        {
            return GetAll().Where(x => x.MaNV == MaNV && x.Thang==Thang).ToList();
        }


        //public List<ChamCong> SearchChamCongByName(string keyword)
        //{
        //    return GetAll().Where(x => x.Tencc.ToLower().Contains(keyword.ToLower())).ToList();
        //}

        //public List<ChamCong> SearchChamCongByDiaCHi(string keyword)
        //{
        //    return GetAll().Where(x => x.DiaChi.ToLower().Contains(keyword.ToLower())).ToList();
        //}

        public int STT()
        {
            return dalCC.STT();
        }

        public bool Update(ChamCong cc,int thang)
        {

            if (SearchChamCongByManVThang(cc.MaNV,thang).Count>0)
            {
                dalCC.Update(cc);
                return true;
            }
            return false;
        }
    }
}
