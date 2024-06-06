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
    public partial class QuanLyKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private BUS_KhachHang busKH = new BUS_KhachHang();

        private void HienThiLuoi(List<KhachHang> khList)
        {

            gridControlQlKH.DataSource = khList.Select(x => new { x.MaKhachHang, x.TenKH, x.DiaChiKH, x.SDTKH }).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            var khach = busKH.GetByID(guna2TextBox1.Text);

            if (khach != null)
            {
                XtraMessageBox.Show("Đã có mã khách hàng");
                return;
            }

            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã khách hàng");
                return;
            }


            KhachHang kh = new KhachHang
            {
                MaKhachHang = guna2TextBox1.Text,
                TenKH = guna2TextBox4.Text,
                DiaChiKH = guna2TextBox6.Text,
                SDTKH = guna2TextBox3.Text,
                

            };

            busKH.Add(kh);

            HienThiLuoi(busKH.GetAll());

            XtraMessageBox.Show("Thêm thành công");

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienThiLuoi(busKH.GetAll());
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaKhachHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKhachHang").ToString();

            string TenKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH").ToString();
            string DiaChiKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChiKH").ToString();
            string SDTKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDTKH").ToString();
            

            guna2TextBox1.Text = MaKhachHang;
            guna2TextBox4.Text = TenKH;
            guna2TextBox6.Text = DiaChiKH;
            guna2TextBox3.Text = SDTKH;
           
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã khách hàng");
                return;
            }

            KhachHang kh = new KhachHang
            {
                MaKhachHang = guna2TextBox1.Text,
                TenKH = guna2TextBox4.Text,
                DiaChiKH = guna2TextBox6.Text,
                SDTKH = guna2TextBox3.Text,
                

            };

            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busKH.Update(kh);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busKH.GetAll());
        }


        private BUS_HoaDonBan busHD = new BUS_HoaDonBan();
        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {

            if(busHD.SearchHoaDonBanByMaKH(guna2TextBox1.Text).Count>0)
            {
                XtraMessageBox.Show("Khách hàng đã thanh toán hóa đơn, không thể xóa vì lý do thống kê và tra cứu");
                return;

            }

            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busKH.Delete(guna2TextBox1.Text))
                {

                    HienThiLuoi(busKH.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }
    }
}