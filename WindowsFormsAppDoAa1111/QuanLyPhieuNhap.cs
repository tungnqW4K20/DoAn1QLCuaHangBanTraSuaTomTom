using BUS;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDoAa1111
{
    public partial class QuanLyPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyPhieuNhap()
        {
            InitializeComponent();
        }

        private BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();



        public class MyDbcontext : DbContext
        {
            public MyDbcontext() : base(ConfigurationManager.ConnectionStrings["QuanLyCuaHangBanTraSuaTomTomEntities3"].ConnectionString)
            { }

            public virtual DataTable InPhieuXuat(string MaHD)
            {
                var connect = Database.Connection;
                using (var command = connect.CreateCommand())
                {
                    command.CommandText = "InPhieuNhap";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("MaHDNhap", MaHD));

                    var dtatable = new DataTable();
                    connect.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        dtatable.Load(reader);
                    }

                    return dtatable;
                }

            }
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var context = new MyDbcontext())
            {
                var datatable = context.InPhieuXuat(guna2ComboBox1.SelectedValue.ToString());
                dt = datatable;
            }


            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            //Đường dẫn báo cáo
            reportViewer1.LocalReport.ReportPath = "PhieuNhap.rdlc";//Application.StartupPath + @"\Phieuxuat.rdlc" ;//rpt_thongtinnhanvien.rdlc";
                                                                    //ReportParameter[] para = new ReportParameter[]
                                                                    //{

            //  //new ReportParameter("HoTen",dt1.Rows[0]["HoTen"].ToString()),

            //                 new ReportParameter("NguoiIn",User._UserName)

            //};
            //   reportViewer1.LocalReport.SetParameters(para);

            ////Nếu có dữ liệu
            //if (data.Rows.Count > 0)
            //{
            //Tạo nguồn dữ liệu cho báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";//"dsrReport_reportData";
            rds.Value = dt;
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            reportViewer1.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            reportViewer1.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            reportViewer1.RefreshReport();

        }

        private void QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.DataSource = busHDN.GetAll();
            guna2ComboBox1.ValueMember = "MaHoaDon";
            guna2ComboBox1.DisplayMember = "MaHoaDon";
            this.reportViewer1.RefreshReport();
        }
    }
}