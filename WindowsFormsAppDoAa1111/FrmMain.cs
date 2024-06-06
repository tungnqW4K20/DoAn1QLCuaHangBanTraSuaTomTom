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

namespace WindowsFormsAppDoAa1111
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        public string LoaiTK = "";

        private Form Kiemtraform(Type ftype)
        {
            foreach(Form f  in this.MdiChildren)
            {
                if(f.GetType() == ftype)
                {
                    return f;
                }    

            }
            return null;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if(LoaiTK=="nhanvien")
            {
                ribbonPage4.Visible = false;

                ribbonPage9.Visible = false;

                ribbonPage8.Visible = false;

                ribbonPage11.Visible = false;
                ribbonPage12.Visible = false;

            }

            if (LoaiTK != "admin")
            {

                ribbonPage9.Visible = false;
                ribbonPage12.Visible = false;
            }




        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form f = Kiemtraform(typeof(ThemSuaXoaNhanVien));
            if (f == null)
            {
                ThemSuaXoaNhanVien frm = new ThemSuaXoaNhanVien();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(TimKiemNhanVien));
            if(f==null)
            {
                TimKiemNhanVien frm = new TimKiemNhanVien();
                frm.MdiParent = this;
                frm.Show();
            }  else
            {
                f.Activate();
            }     
        }

        private void BTNThemNguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QuanLyNguyenLieu));
            if (f == null)
            {
                QuanLyNguyenLieu frm = new QuanLyNguyenLieu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(TimKiemNguyenLieu));
            if (f == null)
            {
                TimKiemNguyenLieu frm = new TimKiemNguyenLieu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void btnDangKyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form f = Kiemtraform(typeof(DangKyTaiKhoan));
            if (f == null)
            {
                DangKyTaiKhoan frm = new DangKyTaiKhoan();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
    
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QuanLyNhaCungCap));
            if (f == null)
            {
                QuanLyNhaCungCap frm = new QuanLyNhaCungCap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(TimKiemNhaCC));
            if (f == null)
            {
                TimKiemNhaCC frm = new TimKiemNhaCC();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QuanLyDanhMuc));
            if (f == null)
            {
                QuanLyDanhMuc frm = new QuanLyDanhMuc();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(TKDanhMuc));
            if (f == null)
            {
                TKDanhMuc frm = new TKDanhMuc();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QuanLyDoUong));
            if (f == null)
            {
                QuanLyDoUong frm = new QuanLyDoUong();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QuanLyKhachHang));
            if (f == null)
            {
                QuanLyKhachHang frm = new QuanLyKhachHang();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(HoaDonban));
            if (f == null)
            {
                HoaDonban frm = new HoaDonban();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(CongThucPhaChe));
            if (f == null)
            {
                CongThucPhaChe frm = new CongThucPhaChe();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QLHoaDonNhap));
            if (f == null)
            {
                QLHoaDonNhap frm = new QLHoaDonNhap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QlBan));
            if (f == null)
            {
                QlBan frm = new QlBan();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QlChamCong));
            if (f == null)
            {
                QlChamCong frm = new QlChamCong();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(TimKiemKH));
            if (f == null)
            {
                TimKiemKH frm = new TimKiemKH();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(TimKiemKH));
            if (f == null)
            {
                TimKiemKH frm = new TimKiemKH();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(frmThongKe));
            if (f == null)
            {
                frmThongKe frm = new frmThongKe();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QLTKNhap));
            if (f == null)
            {
                QLTKNhap frm = new  QLTKNhap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QuanLyPX));
            if (f == null)
            {
                QuanLyPX frm = new QuanLyPX();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = Kiemtraform(typeof(QuanLyPhieuNhap));
            if (f == null)
            {
                QuanLyPhieuNhap frm = new QuanLyPhieuNhap();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Activate();
            }
        }
    }
}