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
    public partial class QuanLyDoUong : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyDoUong()
        {
            InitializeComponent();
        }

        private BUS_DoUong busDoUong = new BUS_DoUong();
        private BUS_NguyenLieu busnl = new BUS_NguyenLieu();
        private BUS_DanhMuc busdm = new BUS_DanhMuc();

        private void HienThiLuoi(List<DoUong> nlList)
        {

            gridControlDoUong.DataSource = nlList.Select(x => new { x.MaDanhMuc, x.MaDoUong, x.GiaL,x.GiaS, x.GiaM, x.TenDoUong }).ToList();
        }
        private void QuanLyDoUong_Load(object sender, EventArgs e)
        {

            //checkedComboBoxEdit1.Properties.DataSource = busnl.GetAll();
            //checkedComboBoxEdit1.Properties.ValueMember = "MaNguyenLieu";
            //checkedComboBoxEdit1.Properties.DisplayMember = "TenNguyenLieu";

            guna2ComboBox1.DataSource = busdm.GetAll();
            guna2ComboBox1.ValueMember = "MaDanhMuc";
            guna2ComboBox1.DisplayMember = "TenDanhMuc";
            HienThiLuoi(busDoUong.GetAll());
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            var nl = busDoUong.GetByID(guna2TextBox1.Text);

            if (nl != null)
            {
                XtraMessageBox.Show("Đã có mã đồ uống");
                return;
            }

            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã đồ uống");
                return;
            }

            DoUong dmm = new DoUong
            {
                MaDoUong = guna2TextBox1.Text,
                TenDoUong = guna2TextBox4.Text,
             //   MaNguyenLieu = checkedComboBoxEdit1.EditValue.ToString(),
                MaDanhMuc = guna2ComboBox1.SelectedValue.ToString(),
                GiaS = decimal.Parse(guna2TextBox5.Text),
                GiaM = decimal.Parse(guna2TextBox2.Text),
                GiaL = decimal.Parse(guna2TextBox7.Text),


            };

            busDoUong.Add(dmm);
            HienThiLuoi(busDoUong.GetAll());
            XtraMessageBox.Show("Thêm thành công");
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã đồ uống");
                return;
            }

            DoUong du = new DoUong
            {
                MaDoUong = guna2TextBox1.Text,
                TenDoUong = guna2TextBox4.Text,
             //   MaNguyenLieu = checkedComboBoxEdit1.EditValue.ToString(),
                MaDanhMuc = guna2ComboBox1.SelectedValue.ToString(),
                GiaS = decimal.Parse(guna2TextBox5.Text),
                GiaM = decimal.Parse(guna2TextBox2.Text),
                GiaL = decimal.Parse(guna2TextBox7.Text),

            };

            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busDoUong.Update(du);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busDoUong.GetAll());
        }


        private BUS_PhaChe buspc = new BUS_PhaChe();

        private BUS_ChiTietHoaDon buscthdb = new BUS_ChiTietHoaDon();
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {

            if(buspc.SearchPhaCheByMaDU(guna2TextBox1.Text).Count>0)
            {
                XtraMessageBox.Show("Đồ uống này có công thức pha chế nằm trong diện kinh doanh của quán, không thể xóa");
                return;

            }

            if (buscthdb.SearchChiTietHoaDonBanByMaDU(guna2TextBox1.Text).Count > 0)
            {
                XtraMessageBox.Show("Đồ uống này nằm trong hóa đơn, không thể xóa vì lý do thống kê, tra cứu doanh thu");
                return;

            }





            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busDoUong.Delete(guna2TextBox1.Text))
                {

                    HienThiLuoi(busDoUong.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaDoUong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaDoUong").ToString();

            string TenDoUong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenDoUong").ToString();
            string MaDanhMuc = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaDanhMuc").ToString();
           // string MaNguyenLieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNguyenLieu").ToSt
            string GiaS = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiaS").ToString());
            
            string GiaM = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiaM").ToString());
            string GiaL = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiaL").ToString());

            guna2TextBox1.Text = MaDoUong;
            guna2TextBox4.Text = TenDoUong ;
          //  checkedComboBoxEdit1.SetEditValue(MaNguyenLieu);
            guna2ComboBox1.SelectedValue = MaDanhMuc ;
            guna2TextBox5.Text = GiaS;
              guna2TextBox2.Text = GiaM;
              guna2TextBox7.Text = GiaL;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}