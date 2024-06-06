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
    public partial class QuanLyNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyNguyenLieu()
        {
            InitializeComponent();
        }
        private BUS_NguyenLieu busNL = new BUS_NguyenLieu();

        private BUS_PhaChe buspc = new BUS_PhaChe();


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void HienThiLuoi(List<NguyenLieu> nlList)
        {

            gridControlQlNguyenLieu.DataSource = nlList.Select(x => new { x.MaNguyenLieu, x.TenNguyenLieu , x.DonViTinh, x.DonGia}).ToList();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            //if (txtMaNguyenLieu.Text == "")
            //{
            //    XtraMessageBox.Show("Chưa nhập mã nguyên liệu");
            //    return;
            //}

            //NguyenLieu nl = new NguyenLieu
            //{
            //    MaNguyenLieu =txtMaNguyenLieu.Text,
            //    TenNguyenLieu = txtTenNguyenLieu.Text,
                

            //};

            //if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    busNL.Update(nl);
            //    XtraMessageBox.Show("Cập nhật thành công");
            //}

            //HienThiLuoi(busNL.GetAll());



        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            var nl = busNL.GetByID(txtMaNguyenLieu.Text);

            if (nl != null)
            {
                XtraMessageBox.Show("Đã có mã nguyên liệu");
                return;
            }

            if(txtMaNguyenLieu.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã nguyên liệu");
                return;
            }


            NguyenLieu nll = new NguyenLieu
            {
                MaNguyenLieu = txtMaNguyenLieu.Text,
                TenNguyenLieu = txtTenNguyenLieu.Text,
                DonViTinh= guna2TextBoxDVT.Text,
                DonGia = decimal.Parse(guna2TextBoxDG.Text)
             
            };

            busNL.Add(nll);
            HienThiLuoi(busNL.GetAll());
            XtraMessageBox.Show("Thêm thành công");
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {

            if(buspc.SearchPhaCheByName(txtMaNguyenLieu.Text).Count>0)
            {
                XtraMessageBox.Show("Nguyên liệu đang được dùng để kinh doanh, không thể xóa");
                return;
            }    


            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busNL.Delete(txtMaNguyenLieu.Text))
                {

                    HienThiLuoi(busNL.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaNguyenLieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNguyenLieu").ToString();

            string TenNguyenLieu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNguyenLieu").ToString();
            string DonViTinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonViTinh").ToString();

            string DonGia = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonGia").ToString();



            txtMaNguyenLieu.Text = MaNguyenLieu;
            txtTenNguyenLieu.Text = TenNguyenLieu;
            guna2TextBoxDG.Text  = DonGia;
            guna2TextBoxDVT.Text = DonViTinh;
            
        }

        private void QuanLyNguyenLieu_Load(object sender, EventArgs e)
        {
            HienThiLuoi(busNL.GetAll());
        }
    }
    
}