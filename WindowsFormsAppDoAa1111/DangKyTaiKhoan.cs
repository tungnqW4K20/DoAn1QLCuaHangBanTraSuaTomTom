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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsAppDoAa1111
{
    public partial class DangKyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private BUS_TaiKHoan bustk = new BUS_TaiKHoan();




        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var tk = bustk.GetByID(txtTKDangKy.Text);

            if (tk != null)
            {
                XtraMessageBox.Show(" đã có tài khoản");
                return;
            }

            if (guna2TextBox1.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã nhân viên");
                return;
            }

            string loai = "";
            if(radNhanVien.Checked==true)
            {
                loai = "nhanvien";

            }

            if (radQuanLy.Checked == true)
            {
                loai = "quanly";

            }


            TaiKhoan ttk = new TaiKhoan
            {
                MaNV = guna2TextBox1.Text,
                TenTK = txtTKDangKy.Text,
                MatKhau = txtMKDangKy.Text,
                LoaiTK = loai,
                

            };

            var tk1 = bustk.GetByID(ttk.TenTK);

            if (tk != null)
            {
                XtraMessageBox.Show(" đã có tài khoản");
                return;
            }

            bustk.Add(ttk);
          

            XtraMessageBox.Show("Đăng ký thành công");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            txtTKDangKy.Text = "";
            txtMKDangKy.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Login frm = new Login();          
            //frm.Show();
            //FrmMain frm2 = new FrmMain();
            //frm2.Hide();
            Application.Exit();
        }
    }
}