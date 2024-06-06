using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class BUS_DanhMuc
    {
        private DAL_DanhMuc dalDM = new DAL_DanhMuc();

        public void Add(DanhMucDoUong dm)
        {
            dalDM.Add(dm);
        }

        public List<DanhMucDoUong> GetAll()
        {
            return dalDM.GetAll();
        }

        public bool Delete(string MaDanhMuc)
        {
            DanhMucDoUong du = GetByID(MaDanhMuc);
            if (du != null)
            {
                dalDM.Delete(du);
                return true;
            }
            return false;
        }

        public DanhMucDoUong GetByID(string id)
        {
            return dalDM.GetByID(id);
        }

        public List<DanhMucDoUong> SearchDanhMucByID(string categoryID)
        {
            return GetAll().Where(x => x.MaDanhMuc == categoryID).ToList();
        }

        public List<DanhMucDoUong> SearchDanhMucByName(string keyword)
        {
            return GetAll().Where(x => x.TenDanhMuc.ToLower().Contains(keyword.ToLower())).ToList();
        }
        public List<DoUong> LayDanhSachDoUongTheoTenDanhMuc(string tenDanhMuc)
        {
            // Sử dụng lớp DAL để lấy danh sách đồ uống dựa trên tên danh mục
            return dalDM.LayDanhSachDoUongTheoTenDanhMuc(tenDanhMuc);
        }
    }
}
