using BUS;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDoAa1111
{
    public partial class TKDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public TKDanhMuc()
        {
            InitializeComponent();
        }

        private BUS_DanhMuc busDM = new BUS_DanhMuc();

        private BUS_DoUong busdu = new BUS_DoUong();

        private void HienThiLuoi(List<DoUong> nlList)
        {

            gridControlDoUong.DataSource = nlList.Select(x => new { x.MaDanhMuc, x.MaDoUong, x.GiaL, x.GiaS, x.GiaM, x.TenDoUong }).ToList();
        }

        private void btnTimKienNguyenLieu_Click(object sender, EventArgs e)
        {
            //string maDanhMuc = txtMaDMTim.Text;

            // Sử dụng BUS để lấy danh sách đồ uống thuộc danh mục có mã là maDanhMuc
           // List<DanhMucDoUong> danhSachDoUong = busDM.SearchDanhMucByID(maDanhMuc);

            // Hiển thị danh sách đồ uống lên gridControl
            HienThiLuoi(busdu.SearchDoUongByDanhMuc(txtMaDMTim.Text));

            

        }
    }
}