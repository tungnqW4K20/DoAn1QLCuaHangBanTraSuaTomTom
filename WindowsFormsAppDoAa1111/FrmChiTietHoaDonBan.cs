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
    public partial class FrmChiTietHoaDonBan : DevExpress.XtraEditors.XtraForm
    {

        public string MaHD = "";

        private BUS_DoUong busdouong = new BUS_DoUong();

        private BUS_ChiTietHoaDon busCTHD = new BUS_ChiTietHoaDon();




        public FrmChiTietHoaDonBan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();
        private void ChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            guna2TextBox3.Text = MaHD;

            //var query = from t1 in db.ChiTietHoaDonBans
            //            join t2 in db.DoUongs on t1.MaDoUong equals t2.MaDoUong
            //            select new
            //            {
            //                t1.MaHoaDonBan,
            //                t1.SoLuongL,
            //                t1.SoLuongS,
            //                t1.SoLuongM,
            //                t2.GiaL,
            //                t2.GiaS,
            //                t2.GiaM,
            //                ThanhTien= t1.SoLuongL*t2.GiaL+ t1.SoLuongL * t2.GiaS+ t1.SoLuongM * t2.GiaM
            //            };


            guna2ComboBox1.DataSource = busdouong.GetAll();
            guna2ComboBox1.ValueMember = "MaDoUong";
            guna2ComboBox1.DisplayMember = "TenDoUong";
            HienThiLuoi(busCTHD.SearchChiTietHoaDonBanByHD(MaHD));

        }


        private void HienThiLuoi(List<ChiTietHoaDonBan> cthdbList)
        {

            gridControlChiTietHoaDonBan.DataSource = cthdbList.Select(x => new { x.MaChiTietHoaDonBan,x.MaHoaDonBan, x.MaDoUong, x.SoLuongS, x.SoLuongM, x.SoLuongL, x.ThanhTien }).ToList();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            var cthdb = busCTHD.GetByID(guna2TextBox6.Text);

            if (cthdb != null)
            {
                XtraMessageBox.Show("Đã có mã chi tiết này");
                return;
            }

            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã chi tiết");
                return;
            }

            int GiaTienS = Convert.ToInt32(busdouong.GetTienS(guna2ComboBox1.SelectedValue.ToString()) * int.Parse(guna2TextBox4.Text));
            int GiaTieM = Convert.ToInt32(busdouong.GetTienM(guna2ComboBox1.SelectedValue.ToString())) * int.Parse(guna2TextBox2.Text);
            int GiaTienL = Convert.ToInt32(busdouong.GetTienL(guna2ComboBox1.SelectedValue.ToString())) * int.Parse(guna2TextBox5.Text);

            ChiTietHoaDonBan cthd = new ChiTietHoaDonBan
            {
                MaChiTietHoaDonBan = guna2TextBox6.Text,
                MaHoaDonBan = guna2TextBox3.Text,
                MaDoUong =guna2ComboBox1.SelectedValue.ToString(),
                SoLuongS = int.Parse(guna2TextBox4.Text),
                SoLuongM = int.Parse(guna2TextBox2.Text),
                SoLuongL = int.Parse(guna2TextBox5.Text),
                ThanhTien= GiaTienS+ GiaTieM+ GiaTienL

            };

            busCTHD.Add(cthd);

            HienThiLuoi(busCTHD.SearchChiTietHoaDonBanByHD(MaHD));


            XtraMessageBox.Show("Thêm thành công");

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (guna2TextBox6.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mã chi tiết");
                return;
            }

            int GiaTienS = Convert.ToInt32(busdouong.GetTienS(guna2ComboBox1.SelectedValue.ToString()) * int.Parse(guna2TextBox4.Text));
            int GiaTieM = Convert.ToInt32(busdouong.GetTienM(guna2ComboBox1.SelectedValue.ToString())) * int.Parse(guna2TextBox2.Text);
            int GiaTienL = Convert.ToInt32(busdouong.GetTienL(guna2ComboBox1.SelectedValue.ToString())) * int.Parse(guna2TextBox5.Text);

            ChiTietHoaDonBan cthd = new ChiTietHoaDonBan
            {
                MaChiTietHoaDonBan = guna2TextBox6.Text,
                MaHoaDonBan = guna2TextBox3.Text,
                MaDoUong = guna2ComboBox1.SelectedValue.ToString(),
                SoLuongS = int.Parse(guna2TextBox4.Text),
                SoLuongM = int.Parse(guna2TextBox2.Text),
                SoLuongL = int.Parse(guna2TextBox5.Text),
                ThanhTien = GiaTienS + GiaTieM + GiaTienL

            };

            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                busCTHD.Update(cthd);
                XtraMessageBox.Show("Cập nhật thành công");
            }

            HienThiLuoi(busCTHD.SearchChiTietHoaDonBanByHD(MaHD));


        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa không", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (busCTHD.Delete(guna2TextBox6.Text))
                {

                    HienThiLuoi(busCTHD.SearchChiTietHoaDonBanByHD(MaHD));

                    XtraMessageBox.Show("Xóa thành công");

                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string MaChiTietHoaDonBan = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaChiTietHoaDonBan").ToString();

            string MaDoUong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaDoUong").ToString();
            string SoLuongS = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoLuongS").ToString();
            string SoLuongM = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoLuongM").ToString();
            string SoLuongL = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoLuongL").ToString();
            string ThanhTien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ThanhTien").ToString();
            string MaHoaDonBan = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHoaDonBan").ToString();

            guna2TextBox6.Text = MaChiTietHoaDonBan;
            guna2ComboBox1.SelectedValue = MaDoUong;
            guna2TextBox4.Text = SoLuongS;
            guna2TextBox3.Text = MaHoaDonBan;
            guna2TextBox5.Text = SoLuongL;
            guna2TextBox2.Text = SoLuongM;


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


         private  BUS_Order busod = new BUS_Order();

        private BUS_DatBan busdatban = new BUS_DatBan();


        private void guna2Button1_Click(object sender, EventArgs e)
        {


            foreach( var item in busod.SearchOrderByID(int.Parse(guna2TextBox1.Text)))
            {
                int GiaTienS = Convert.ToInt32(busdouong.GetTienS(item.MaDoUong) * item.SoLuongS);
                int GiaTieM = Convert.ToInt32(busdouong.GetTienM(item.MaDoUong) * item.SoLuongM);
                int GiaTienL = Convert.ToInt32(busdouong.GetTienL(item.MaDoUong) * item.SoLuongL);


                ChiTietHoaDonBan cthd = new ChiTietHoaDonBan
                {
                    MaChiTietHoaDonBan =guna2TextBox3.Text+"_"+ Convert.ToString(item.ID),
                    MaHoaDonBan = guna2TextBox3.Text,
                    MaDoUong = item.MaDoUong,
                    SoLuongS = item.SoLuongS,
                    SoLuongM =item.SoLuongM,
                    SoLuongL = item.SoLuongL,
                    ThanhTien = GiaTienS + GiaTieM + GiaTienL

                };

                busCTHD.Add(cthd);


                busod.Delete(item.ID);

            }


            TrangThaiBan ttb = new TrangThaiBan
            {
                SoBan = int.Parse(guna2TextBox1.Text),
                TrangThai = false

            };

            busdatban.Update(ttb);
            HienThiLuoi(busCTHD.SearchChiTietHoaDonBanByHD(MaHD));
            XtraMessageBox.Show("Thêm thành công");

        }
    }
}