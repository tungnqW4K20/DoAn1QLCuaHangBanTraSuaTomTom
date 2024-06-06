using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Order
    {
        private DAL_Order dalorder = new DAL_Order();

        public void Add(Order ncc)
        {
            dalorder.Add(ncc);

        }



        public bool Delete(int ID)
        {
            Order ncc = GetByID(ID);
            if (ncc != null)
            {
                dalorder.Delete(ncc);
                return true;
            }
            return false;
        }

        public List<Order> GetAll()
        {
            return dalorder.GetAll();
        }

        public Order GetByID(int id)
        {
            return dalorder.GetByID(id);
        }


        public List<Order> SearchOrderByID(int soban)
        {
            return GetAll().Where(x => x.SoBan == soban).ToList();
        }

        //public List<Order> SearchOrderByName(string keyword)
        //{
        //    return GetAll().Where(x => x.TenNhaCC.ToLower().Contains(keyword.ToLower())).ToList();
        //}

        //public List<Order> SearchOrderByDiaCHi(string keyword)
        //{
        //    return GetAll().Where(x => x.DiaChiNhaCC.ToLower().Contains(keyword.ToLower())).ToList();
        //}


        public bool Update(Order ncc)
        {
            if (GetByID(ncc.ID) != null)
            {
                dalorder.Update(ncc);
                return true;
            }
            return false;
        }

    }
}
