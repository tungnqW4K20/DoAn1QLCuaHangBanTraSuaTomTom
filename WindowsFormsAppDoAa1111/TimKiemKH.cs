using BUS;
using DevExpress.XtraEditors;
using DTO;
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
    public partial class TimKiemKH : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemKH()
        {
            InitializeComponent();
        }
        private BUS_KhachHang busKH = new BUS_KhachHang();


        private void HienThiLuoi(List<KhachHang> KHList)
        {

            gridControlTKKH.DataSource = KHList.Select(x => new { x.MaKhachHang, x.TenKH, x.DiaChiKH, x.SDTKH}).ToList();
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busKH.SearchKhachHangByID(guna2TextBox1.Text));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busKH.SearchKhachHangByName(guna2TextBox6.Text));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busKH.SearchKhachHangByDiaCHi(guna2TextBox4.Text));
        }
    }
}