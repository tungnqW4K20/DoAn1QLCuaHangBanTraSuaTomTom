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
    public partial class TimKiemNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        public TimKiemNguyenLieu()
        {
            InitializeComponent();
        }
        private BUS_NguyenLieu busNL = new BUS_NguyenLieu();
        private void HienThiLuoi(List<NguyenLieu> nlList)
        {

            gridControlTKNguyenLieu.DataSource = nlList.Select(x => new { x.MaNguyenLieu, x.TenNguyenLieu }).ToList();
        }
        private void btnTimKienNguyenLieu_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNL.SearchNguyenLieuByID(txtMaNguyenLieuTim.Text));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HienThiLuoi(busNL.SearchNguyenLieuByName(txtTenNguyenLieuTim.Text));
        }
    }
}