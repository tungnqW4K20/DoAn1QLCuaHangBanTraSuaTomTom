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
    public partial class TimKiemNhaCC : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemNhaCC()
        {
            InitializeComponent();
        }
        private BUS_NhaCC busNCC = new BUS_NhaCC();
        private void HienThiLuoi(List<NhaCungCap> nhaccList)
        {

            gridControlTKNhaCC.DataSource = nhaccList.Select(x => new { x.MaNhaCC, x.TenNhaCC, x.DiaChiNhaCC, x.SDTNhaCC }).ToList();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNCC.SearchNhaCungCapByID(guna2TextBox1.Text));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNCC.SearchNhaCungCapByName(guna2TextBox2.Text));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNCC.SearchNhaCungCapByDiaCHi(guna2TextBox3.Text));
        }
    }
}