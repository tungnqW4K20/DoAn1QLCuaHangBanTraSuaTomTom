using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhaChe
    {
        private DAL_PhaChe dalpc = new DAL_PhaChe();


        public void Add(PhaChe pc)
        {
            dalpc.Add(pc);
        }

        public bool Delete(string Madu,string manguyenlieu)
        {
            var pc = SearchPhaCheByMaDoUong(Madu,manguyenlieu);


            if (pc != null)
            {
                dalpc.Delete(pc);
                return true;
            }
            return false;
        }



        public List<PhaChe> GetAll()
        {
            return dalpc.GetAll();
        }

        public PhaChe GetByID(string id)
        {
            return dalpc.GetByID(id);
        }

        public PhaChe SearchPhaCheByMaDoUong(string Madouong, string manguyenlieu)
        {
            //  var pc= GetAll().Where(x => x.MaDoUong == Madouong && x.MaNguyenLieu == manguyenlieu).ToList();

            //PhaChe _phache = new PhaChe();

            //foreach(var item in pc)
            //{
            //    _phache.MaDoUong = item.MaDoUong;
            //    _phache.MaNguyenLieu = item.MaNguyenLieu;
            //    _phache.DinhLuong = item.DinhLuong;
            //    _phache.DonViTinh = item.DonViTinh;


            //}

            return dalpc.GetByID2(Madouong,manguyenlieu);
        }


        //public string GetProductName(string id)
        //{
        //    return GetByID(id).Tenpc;
        //}

        public List<PhaChe> SearchPhaCheByID(string Madouong,string manguyenlieu)
        {
            return GetAll().Where(x => x.MaDoUong == Madouong && x.MaNguyenLieu==manguyenlieu ).ToList();
        }

        public List<PhaChe> SearchPhaCheByMaDU(string Madouong)
        {
            return GetAll().Where(x => x.MaDoUong == Madouong).ToList();
        }


        public List<PhaChe> SearchPhaCheByName(string keyword)
        {
            return GetAll().Where(x => x.MaNguyenLieu == keyword).ToList();
        }

        //public List<PhaChe> SearchPhaCheByDiaCHi(string keyword)
        //{
        //    return GetAll().Where(x => x.DiaChi.ToLower().Contains(keyword.ToLower())).ToList();
        //}


        public bool Update(PhaChe pc)
        {
            if (SearchPhaCheByID(pc.MaDoUong, pc.MaNguyenLieu).Count >0)
            {
                dalpc.Update(pc);
                return true;
            }
            return false;
        }
    }
}
