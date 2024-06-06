using BUS;
using DevExpress.XtraEditors;
using DTO;
using Guna.UI2.WinForms;
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
    public partial class QuanLyDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyDanhMuc()
        {
            InitializeComponent();
        }
        private BUS_DanhMuc busDM = new BUS_DanhMuc();
        private BUS_DoUong busDoUong = new BUS_DoUong();

        private void HienThiLuoi(List<DanhMucDoUong> nlList)
        {

            gridControlDMDoUong.DataSource = nlList.Select(x => new { x.MaDanhMuc, x.TenDanhMuc }).ToList();
        }

        private void btnTimKienNguyenLieu_Click(object sender, EventArgs e)
        {
            var nl = busDM.GetByID(txtMaDanhMuc.Text);

            if (nl != null)
            {
                XtraMessageBox.Show("Đã có mã danh mục");
                return;
            }

            if (txtMaDanhMuc.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã danh mục");
                return;
            }

            DanhMucDoUong dmm = new DanhMucDoUong
            {
                MaDanhMuc = txtMaDanhMuc.Text,
                TenDanhMuc = txtTenDanhMuc.Text,

            };

            busDM.Add(dmm);
            HienThiLuoi(busDM.GetAll());
            XtraMessageBox.Show("Thêm thành công");

        }

        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiLuoi(busDM.GetAll());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          var dmdu= busDoUong.SearchDMbyMaDoUong(txtMaDanhMuc.Text);
            if (dmdu.Count>0)
            {
                XtraMessageBox.Show("Danh mục đã có đồ uống không được xóa");
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busDM.Delete(txtMaDanhMuc.Text))
                {

                    HienThiLuoi(busDM.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }
            }


        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaDM = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaDanhMuc").ToString();

            string TenDanhMuc = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenDanhMuc").ToString();
            txtMaDanhMuc.Text = MaDM;
            txtTenDanhMuc.Text = TenDanhMuc;

        }
    }
}