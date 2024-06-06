using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;
namespace WindowsFormsAppDoAa1111
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private BUS_TaiKHoan busTK = new BUS_TaiKHoan();
       

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan frm = new DangKyTaiKhoan();
            frm.Show();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string username = guna2TextBoxTaiKhoan.Text;
            string matkhau = guna2TextBoxMatKhau.Text;
            if(busTK.CheckDangNhap(username,matkhau)==true)
            {
      
                FrmMain frm = new FrmMain();
                frm.LoaiTK = busTK.GetLoaiTK(username);
                frm.Show();
                this.Hide();
            }
            else
            {
                guna2MessageDialog1.Show("Tài khoản hoặc mật khẩu không đúng!");
            }






        }
    }
}
