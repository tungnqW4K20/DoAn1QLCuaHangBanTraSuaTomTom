using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace WindowsFormsAppDoAa1111
{
    public partial class ThemSuaXoaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public ThemSuaXoaNhanVien()
        {
            InitializeComponent();
        }


        private BUSNhanVien busNV = new BUSNhanVien();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void HienThiLuoi(List<NhanVien> nhanvienList)
        {

            gridControlQLNhanVien.DataSource = nhanvienList.Select(x => new { x.MaNV, x.TenNV, x.DiaChi, x.SDT, x.Luong, x.ChucVu,x.TrangThai }).ToList();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

            var nhanvien = busNV.GetByID(guna2TextBox1.Text);

            if (nhanvien != null)
            {
                XtraMessageBox.Show("Đã có mã nhân viên");
                return;
            }

            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã nhân viên");
                return;
            }


            NhanVien nv = new NhanVien
            {
                MaNV = guna2TextBox1.Text,
                TenNV = guna2TextBox4.Text,
                DiaChi = guna2TextBox6.Text,
                SDT = guna2TextBox3.Text,
                Luong = decimal.Parse(guna2TextBox5.Text),
                ChucVu = guna2TextBox2.Text

            };

            busNV.Add(nv);

            HienThiLuoi(busNV.GetAll());

            XtraMessageBox.Show("Thêm thành công");


        }

        private void ThemSuaXoaNhanVien_Load(object sender, EventArgs e)
        {
            HienThiLuoi(busNV.GetAll());
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {



            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã nhân viên");
                return;
            }

            NhanVien nv = new NhanVien
            {
                MaNV = guna2TextBox1.Text,
                TenNV = guna2TextBox4.Text,
                DiaChi = guna2TextBox6.Text,
                SDT = guna2TextBox3.Text,
                Luong = decimal.Parse(guna2TextBox5.Text),
                ChucVu = guna2TextBox2.Text

            };

            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busNV.Update(nv);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busNV.GetAll());
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string Manv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();

            string TenNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
            string DiaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            string SDT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            string Luong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Luong").ToString();
            string ChucVu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ChucVu").ToString();

            guna2TextBox1.Text = Manv;
            guna2TextBox4.Text = TenNV;
            guna2TextBox6.Text = DiaChi;
            guna2TextBox3.Text = SDT;
            guna2TextBox5.Text = Luong;
            guna2TextBox2.Text = ChucVu;

        }

        private BUS_TaiKHoan busTK = new BUS_TaiKHoan();

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {

            busTK.Delete(guna2TextBox1.Text);




            NhanVien nv = new NhanVien
            {
                MaNV = guna2TextBox1.Text,
                TenNV = guna2TextBox4.Text,
                DiaChi = guna2TextBox6.Text,
                SDT = guna2TextBox3.Text,
                Luong = decimal.Parse(guna2TextBox5.Text),
                ChucVu = guna2TextBox2.Text,
                TrangThai = "Đã Nghỉ",
            };

            if (XtraMessageBox.Show("Bạn có chắc muốn thay trạng thái nhân viên này thành nghỉ làm?", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busNV.Update(nv);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busNV.GetAll());





        } 
    }
}