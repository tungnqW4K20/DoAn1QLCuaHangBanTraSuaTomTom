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
    public partial class QLHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        public QLHoaDonNhap()
        {
            InitializeComponent();
        }
        private BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();

        private BUSNhanVien busNV = new BUSNhanVien();

        private BUS_NhaCC busNCC = new BUS_NhaCC();


        private void HienThiLuoi(List<HoaDonNhap>HoaDonNhapList)
        {

            gridControlQLHDN.DataSource =HoaDonNhapList.Select(x => new { x.MaHoaDon, x.MaNV, x.MaNhaCC, x.NgayNhap }).ToList();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {


            var hd = busHDN.GetByID(guna2TextBox6.Text);

            if (hd != null)
            {
                XtraMessageBox.Show("Đã có mã hóa đơn nhập");
                return;
            }

            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã cho hóa đơn nhập");
                return;
            }


           HoaDonNhap hdn = new HoaDonNhap
            {
               MaHoaDon = guna2TextBox6.Text,
                MaNV = guna2ComboBox2.SelectedValue.ToString(),
                MaNhaCC = guna2ComboBox1.SelectedValue.ToString(),
                NgayNhap = guna2DateTimePicker1.Value,
                
            };

            busHDN.Add(hdn);

            HienThiLuoi(busHDN.GetAll());

            XtraMessageBox.Show("Thêm thành công");

        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            


            guna2ComboBox2.DataSource = busNV.GetAll();
            guna2ComboBox2.ValueMember = "MaNV";
            guna2ComboBox2.DisplayMember = "TenNV";


            guna2ComboBox1.DataSource = busNCC.GetAll();
            guna2ComboBox1.ValueMember = "MaNhaCC";
            guna2ComboBox1.DisplayMember = "TenNhaCC";

            HienThiLuoi(busHDN.GetAll());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã hóa đơn");
                return;
            }

            HoaDonNhap hdn = new HoaDonNhap
            {
                MaHoaDon = guna2TextBox6.Text,
                MaNV = guna2ComboBox2.SelectedValue.ToString(),
                MaNhaCC = guna2ComboBox1.SelectedValue.ToString(),
                NgayNhap = guna2DateTimePicker1.Value,

            };

            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busHDN.Update(hdn);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busHDN.GetAll());
        }

        private BUS_ChiTietHoaDonNhap buscthdn = new BUS_ChiTietHoaDonNhap();

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                buscthdn.DeleteMaHD(guna2TextBox6.Text);


                if (busHDN.Delete(guna2TextBox6.Text))
                {

                    HienThiLuoi(busHDN.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if(e.Column.FieldName=="XemChiTiet")
            {
                QLChiTietHoaDonNhap frm = new QLChiTietHoaDonNhap();
                frm.MaHD= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHoaDon").ToString();
                frm.Show();

            } 
            else
            {
                string MaHoaDon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHoaDon").ToString();

                string MaNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
                string MaNhaCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNhaCC").ToString();
                string NgayNhap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayNhap").ToString();


                guna2TextBox6.Text = MaHoaDon;
                guna2ComboBox2.SelectedValue = MaNV;
                guna2ComboBox1.SelectedValue = MaNhaCC;
                guna2DateTimePicker1.Value = Convert.ToDateTime(NgayNhap);
            }    
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {


            if (e.Column.FieldName == "XemChiTiet" && e.ListSourceRowIndex>0 )
            {
                e.DisplayText = "Xem CHi Tiết HD Nhập";

            }
        }
    }
}