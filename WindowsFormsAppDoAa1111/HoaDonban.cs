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
    public partial class HoaDonban : DevExpress.XtraEditors.XtraForm
    {
        public HoaDonban()
        {
            InitializeComponent();
        }

        private BUS_HoaDonBan busHDB  = new BUS_HoaDonBan();
        private BUS_KhachHang busKH = new BUS_KhachHang();
        private BUSNhanVien busNV = new BUSNhanVien();
        private void HienThiLuoi(List<HoaDonBan> hdbList)
        {

            gridControlQLHDB.DataSource = hdbList.Select(x => new { x.MaHoaDonBan, x.MaNV, x.MaKH, x.NgayBan, x.TrangThai }).ToList();
        }





        private void btnThemKH_Click(object sender, EventArgs e)//Thêm
        {
            var hdb = busHDB.GetByID(guna2TextBox6.Text);

            if (hdb != null)
            {
                XtraMessageBox.Show("Đã có mã hóa đơn");
                return;
            }

            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã hóa đơn");
                return;
            }


            HoaDonBan hd = new HoaDonBan()
            {
                MaHoaDonBan = guna2TextBox6.Text,
                MaNV = guna2ComboBox2.SelectedValue.ToString(),
                MaKH = guna2ComboBox1.SelectedValue.ToString(),
                NgayBan = guna2DateTimePicker1.Value,
                TrangThai = guna2TextBox2.Text,

            };

            busHDB.Add(hd);

            HienThiLuoi(busHDB.GetAll());

            XtraMessageBox.Show("Thêm thành công");
        }

        private void HoaDonban_Load(object sender, EventArgs e)
        {
            HienThiLuoi(busHDB.GetAll());

            guna2ComboBox1.DataSource = busKH.GetAll();
            guna2ComboBox1.ValueMember = "MaKhachHang";
            guna2ComboBox1.DisplayMember = "TenKH";

            guna2ComboBox2.DataSource = busNV.GetAll();
            guna2ComboBox2.ValueMember = "MaNV";
            guna2ComboBox2.DisplayMember = "TenNV";

        }

        private void btnSuaKH_Click(object sender, EventArgs e)//Sửa
        {
            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã hóa đơn");
                return;
            }
            HoaDonBan hd = new HoaDonBan()
            {
                MaHoaDonBan = guna2TextBox6.Text,
                MaNV = guna2ComboBox2.SelectedValue.ToString(),
                MaKH = guna2ComboBox1.SelectedValue.ToString(),
                NgayBan = guna2DateTimePicker1.Value,
                TrangThai = guna2TextBox2.Text,

            };


            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busHDB.Update(hd);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busHDB.GetAll());
        }

        private BUS_ChiTietHoaDon BUSCTHD = new BUS_ChiTietHoaDon();
        private void btnXoaKhachHang_Click(object sender, EventArgs e) //Xóa
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                BUSCTHD.DeleteMaHD(guna2TextBox6.Text);


                if (busHDB.Delete(guna2TextBox6.Text))
                {

                    HienThiLuoi(busHDB.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }

            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if(e.Column.FieldName!="XemCTHD")
            {
                string MaHoaDonBan = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHoaDonBan").ToString();

                string MaKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
                string MaNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
                // string MaNguyenLieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNguyenLieu").ToSt

                string TrangThai = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TrangThai").ToString());
                string NgayBan = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayBan").ToString());



                guna2TextBox6.Text = MaHoaDonBan;
                guna2ComboBox2.SelectedValue = MaNV;
                //  checkedComboBoxEdit1.SetEditValue(MaNguyenLieu);
                guna2ComboBox1.SelectedValue = MaKH;
                //   guna2DateTimePicker1.Value = NgayBan;
                guna2TextBox2.Text = TrangThai;

            }  
            else

            {
                FrmChiTietHoaDonBan frm = new FrmChiTietHoaDonBan();
                frm.MaHD = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHoaDonBan").ToString();
                frm.Show();
                    
               
            }    

      


           
        }
    }
}