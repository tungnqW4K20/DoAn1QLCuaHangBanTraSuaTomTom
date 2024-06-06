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
using DAL;
using DTO;
using BUS;
namespace WindowsFormsAppDoAa1111
{
    public partial class TimKiemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemNhanVien()
        {
            InitializeComponent();
        }

        private BUSNhanVien busNV = new BUSNhanVien();

        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void HienThiLuoi(List<NhanVien> nhanvienList)
        {

            gridControlTimKiemNhanVien.DataSource = nhanvienList.Select(x => new { x.MaNV, x.TenNV, x.DiaChi, x.SDT, x.Luong, x.ChucVu }).ToList();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNV.SearchNhanvienByID(guna2TextBox1.Text));


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNV.SearchNhanvienByName(guna2TextBox2.Text));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNV.SearchNhanvienByDiaCHi(guna2TextBox3.Text));

        }
    }
}