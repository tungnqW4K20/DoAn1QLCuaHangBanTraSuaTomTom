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
    public partial class CongThucPhaChe : DevExpress.XtraEditors.XtraForm
    {
        public CongThucPhaChe()
        {
            InitializeComponent();
        }
        private BUS_NguyenLieu busNL  = new BUS_NguyenLieu();
        private BUS_DoUong busDU = new BUS_DoUong();
        private BUS_PhaChe busPC = new BUS_PhaChe();
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CongThucPhaChe_Load(object sender, EventArgs e)
        {

            guna2ComboBox2.DataSource = busDU.GetAll();
            guna2ComboBox2.ValueMember = "MaDoUong";
            guna2ComboBox2.DisplayMember = "TenDoUong";

            guna2ComboBox3.DataSource = busNL.GetAll();
            guna2ComboBox3.ValueMember = "MaNguyenLieu";
            guna2ComboBox3.DisplayMember = "TenNguyenLieu";
            HienThiLuoi(busPC.GetAll());



        }
        private void HienThiLuoi(List<PhaChe> pcList)
        {

            gridControlCTPC.DataSource = pcList.Select(x => new { x.MaDoUong,  x.MaNguyenLieu, x.DonViTinh, x.DinhLuong }).ToList();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            var phaChe = busPC.SearchPhaCheByID(guna2ComboBox2.SelectedValue.ToString(), guna2ComboBox3.SelectedValue.ToString());

            if (phaChe.Count  > 0)
            {
                XtraMessageBox.Show("Đã có đồ uống và nguyên liệu này ");
                return;
            }

            if (guna2ComboBox2.SelectedValue.ToString() == "")
            {
                XtraMessageBox.Show("Chưa nhập mã đồ uống và mã nguyên liệu");
                return;
            }


            PhaChe pc = new PhaChe
            {
                MaDoUong = guna2ComboBox2.SelectedValue.ToString(),
                MaNguyenLieu = guna2ComboBox3.SelectedValue.ToString(),
                DonViTinh = guna2TextBox1.Text,
                DinhLuong = int.Parse(guna2TextBox7.Text),
               

            };

            busPC.Add(pc);

            HienThiLuoi(busPC.GetAll());

            XtraMessageBox.Show("Thêm thành công");
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedValue.ToString() == "" || guna2ComboBox3.SelectedValue.ToString() == "")
            {
                XtraMessageBox.Show("Chưa nhập mã đồ uống hoặc mã nguyên liệu, vui lòng kiểm tra");
                return;
            }

            PhaChe pc = new PhaChe
            {
                MaDoUong = guna2ComboBox2.SelectedValue.ToString(),
                MaNguyenLieu = guna2ComboBox3.SelectedValue.ToString(),
                DonViTinh = guna2TextBox1.Text,
                DinhLuong = int.Parse(guna2TextBox7.Text),


            };


            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busPC.Update(pc);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busPC.GetAll());
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busPC.Delete(guna2ComboBox2.SelectedValue.ToString(), guna2ComboBox3.SelectedValue.ToString()))
                {

                    HienThiLuoi(busPC.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaDoUong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaDoUong").ToString();

            string MaNguyenLieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNguyenLieu").ToString();
            string DinhLuong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DinhLuong").ToString();
            string DonViTinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonViTinh").ToString();


            guna2ComboBox2.SelectedValue = MaDoUong;
            guna2ComboBox3.SelectedValue = MaNguyenLieu;
            guna2TextBox1.Text = DonViTinh;
            guna2TextBox7.Text = DinhLuong;
            
        }
    }
}