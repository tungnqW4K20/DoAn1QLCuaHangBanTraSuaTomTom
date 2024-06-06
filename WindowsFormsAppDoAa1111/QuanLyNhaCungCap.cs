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
    public partial class QuanLyNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        private BUS_NhaCC busNCC = new BUS_NhaCC();
        private void HienThiLuoi(List<NhaCungCap> nhaCCList)
        {

            gridControlQLNhaCC.DataSource = nhaCCList.Select(x => new { x.MaNhaCC, x.TenNhaCC, x.DiaChiNhaCC, x.SDTNhaCC }).ToList();
        }

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiLuoi(busNCC.GetAll());


        }

        private void btnThemNhaCC_Click(object sender, EventArgs e)
        {
            var nhacc = busNCC.GetByID(guna2TextBox1.Text);

            if (nhacc != null)
            {
                XtraMessageBox.Show("Đã có mã nhà cung cấp");
                return;
            }

            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã nhà cung cấp");
                return;
            }


            NhaCungCap ncc = new NhaCungCap
            {
                MaNhaCC = guna2TextBox1.Text,
                TenNhaCC = guna2TextBox4.Text,
                DiaChiNhaCC = guna2TextBox6.Text,
                SDTNhaCC = guna2TextBox3.Text,
               

            };

            busNCC.Add(ncc);

            HienThiLuoi(busNCC.GetAll());

            XtraMessageBox.Show("Thêm thành công");

        }

        private void btnSuaNhaCC_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã nhà cung cấp");
                return;
            }

            NhaCungCap nv = new NhaCungCap
            {
                MaNhaCC = guna2TextBox1.Text,
                TenNhaCC = guna2TextBox4.Text,
                DiaChiNhaCC = guna2TextBox6.Text,
                SDTNhaCC = guna2TextBox3.Text,

            };

            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busNCC.Update(nv);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busNCC.GetAll());

        }

        private BUS_HoaDonNhap bushdn = new BUS_HoaDonNhap();
        private void btnXoaNhaCC_Click(object sender, EventArgs e)
        {
            
            if(bushdn.SearchHoaDonNhapByMaNhaCC(guna2TextBox1.Text).Count >0)
            {
                XtraMessageBox.Show("Nhà cung cấp này đã có trong hóa đơn nhập, không thể xóa để đảm bảo lịch sử giao dịch, nếu thực sự muốn xóa vì ngừng hợp tác với nhà cung cấp này, vui lòng xóa hóa đơn nhập trước ");
                return;

            }    
            
            
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busNCC.Delete(guna2TextBox1.Text))
                {

                    HienThiLuoi(busNCC.GetAll());
                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaNhaCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNhaCC").ToString();

            string TenNhaCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNhaCC").ToString();
            string DiaChiNhaCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChiNhaCC").ToString();
            string SDTNhaCC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDTNhaCC").ToString();
            
            guna2TextBox1.Text = MaNhaCC;
            guna2TextBox4.Text = TenNhaCC;
            guna2TextBox6.Text = DiaChiNhaCC;
            guna2TextBox3.Text = SDTNhaCC;
           

        }
    }
}