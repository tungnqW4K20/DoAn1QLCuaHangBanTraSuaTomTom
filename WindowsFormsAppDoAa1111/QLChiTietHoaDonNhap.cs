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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppDoAa1111
{
    public partial class QLChiTietHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        public QLChiTietHoaDonNhap()
        {
            InitializeComponent();
        }
        public string MaHD = "";

        private BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();
        private BUS_NguyenLieu busNL = new BUS_NguyenLieu();
        private BUS_ChiTietHoaDonNhap busCTHDN = new BUS_ChiTietHoaDonNhap();




        private void HienThiLuoi(List<ChiTietHoaDonNhap> cthdnList)
        {

            gridControlChiTietHoaDonNhap.DataSource = cthdnList.Select(x => new { x.MaChiTietHoaDon, x.MaHoaDon, x.MaNguyenLieu, x.DonGia, x.SoLuong, x.ThanhTien }).ToList();
        }
        private void QLChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {

            guna2TextBox3.Text = MaHD;
            HienThiLuoi(busCTHDN.SearchChiTietHoaDonNhapByHD(guna2TextBox3.Text));
            //guna2guna2ComboBox1.DataSource= busNL.GetAll().Select(x => new { x.MaNguyenLieu,x.TenNguyenLieu }).ToList();
            //guna2guna2ComboBox1.ValueMember = "MaNguyenLieu";
            //guna2guna2ComboBox1.DisplayMember = "TenNguyenLieu";


            guna2ComboBox1.SelectedValue = "2";
            guna2ComboBox1.DataSource = busNL.GetAll();//.Select(x => new { x.MaNguyenLieu, x.TenNguyenLieu }).ToList();
            guna2ComboBox1.ValueMember = "MaNguyenLieu";
            guna2ComboBox1.DisplayMember = "TenNguyenLieu";

            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = guna2ComboBox1.SelectedValue.ToString();

            guna2TextBox2.Text = busNL.GetDonGia(selectedValue).ToString();
        }


        private void btnThemKH_Click(object sender, EventArgs e)
        {
            var cthdb = busCTHDN.GetByID(guna2TextBox6.Text);

            if (cthdb != null)
            {
                XtraMessageBox.Show("Đã có mã chi tiết này");
                return;
            }

            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã chi tiết");
                return;
            }




            ChiTietHoaDonNhap cthdn = new ChiTietHoaDonNhap
            {
                MaChiTietHoaDon = guna2TextBox6.Text,
                MaHoaDon = guna2TextBox3.Text,
                MaNguyenLieu = guna2ComboBox1.SelectedValue.ToString(),
                DonGia = decimal.Parse(guna2TextBox2.Text),
                SoLuong = int.Parse(guna2TextBox4.Text),
                
                ThanhTien = decimal.Parse(guna2TextBox2.Text)* int.Parse(guna2TextBox4.Text),

            };

            busCTHDN.Add(cthdn);

            HienThiLuoi(busCTHDN.SearchChiTietHoaDonNhapByHD(guna2TextBox3.Text));


            XtraMessageBox.Show("Thêm thành công");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busCTHDN.Delete(guna2TextBox6.Text))
                {
                    HienThiLuoi(busCTHDN.SearchChiTietHoaDonNhapByHD(guna2TextBox3.Text));
                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaChiTietHoaDon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaChiTietHoaDon").ToString();

            string MaHoaDon = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHoaDon").ToString();
            string MaNguyenLieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNguyenLieu").ToString();
            string DonGia = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonGia").ToString();
            string SoLuong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoLuong").ToString();
            

            guna2ComboBox1.SelectedValue = MaNguyenLieu;
            guna2TextBox4.Text = SoLuong;
            guna2TextBox6.Text = MaChiTietHoaDon;
            guna2TextBox3.Text = MaHoaDon;            
            guna2TextBox2.Text = DonGia;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã chi tiết cho hóa đơn nhập");
                return;
            }

            ChiTietHoaDonNhap nv = new ChiTietHoaDonNhap
            {

                MaChiTietHoaDon = guna2TextBox6.Text,
                MaHoaDon = guna2TextBox3.Text,
                MaNguyenLieu = guna2ComboBox1.SelectedValue.ToString(),
                DonGia = decimal.Parse(guna2TextBox2.Text),
                SoLuong = int.Parse(guna2TextBox4.Text),

                ThanhTien = decimal.Parse(guna2TextBox2.Text) * int.Parse(guna2TextBox4.Text),

            };

            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busCTHDN.Update(nv);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busCTHDN.SearchChiTietHoaDonNhapByHD(guna2TextBox3.Text));
        }

    

        private void guna2guna2ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //if(guna2guna2ComboBox1.SelectedValue.ToString()!="0")
            //{

            //    string nl = guna2guna2ComboBox1.sele.ToString();

            //    guna2TextBox2.Text = busNL.GetDonGia(nl).ToString();
            //}    
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        //private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    string selectedValue = guna2ComboBox1.SelectedValue.ToString();
        //    MessageBox.Show("Bạn đã chọn: " + selectedValue);
        //    //string nl = guna2ComboBox1.SelectedValue.ToString();

        //    //guna2TextBox2.Text = busNL.GetDonGia(nl).ToString();
        //}
    }
}