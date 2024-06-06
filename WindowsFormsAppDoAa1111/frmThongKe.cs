using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsAppDoAa1111
{
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


        public class MyDbcontext : DbContext
        {
                 public MyDbcontext() : base(ConfigurationManager.ConnectionStrings["QuanLyCuaHangBanTraSuaTomTomEntities3"].ConnectionString)
                 { }
                
                public virtual DataTable ThongKeDoanhThu(string NgayBD,string NgaykT)
                {
                     var connect = Database.Connection;
                        using (var command = connect.CreateCommand())
                        {
                            command.CommandText = "sp_Tongdoanhthucuatungdouong";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add(new SqlParameter("NgayBD", NgayBD) );
                            command.Parameters.Add(new SqlParameter("NgayKT", NgaykT));
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


        private void HienThiBieuDo()
        {
            // Xóa tất cả các series hiện có trên biểu đồ
            chart1.Series.Clear();

            // Thực hiện truy vấn và lấy dữ liệu từ CSDL
            DataTable dt = new DataTable();

            using (var context = new MyDbcontext())
            {

                var datatable = context.ThongKeDoanhThu(guna2DateTimePicker1.Text, guna2DateTimePicker2.Text);
                dt = datatable;

            }

            Series series = new Series("");
           
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                string drinkName = row["TenDoUong"].ToString();
       
                // Tạo series cho món đồ uống
                series.Points.AddXY(drinkName, row["TongThanhTien"].ToString());
                //   series.Points.AddXY("Vừa", mediumQty);
                //  series.Points.AddXY("Lớn", largeQty);
               
            }


            // Thiết lập các màu cho mỗi cột
            Color[] colors = new Color[] { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.Purple, Color.DarkGreen, Color.DarkOrchid, Color.AliceBlue, Color.Aqua }; // Mảng màu
            int colorIndex = 0;
            foreach (DataPoint point in series.Points)
            {
                if (colorIndex >= colors.Length)
                {
                    colorIndex = 0; // Quay lại màu đầu tiên nếu đã hết màu trong mảng
                }
                point.Color = colors[colorIndex]; // Đặt màu cho điểm
                colorIndex++;
            }

            chart1.Series.Add(series);



            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;

            chart1.ChartAreas[0].AxisX.Title = "Đồ Uống";
            chart1.ChartAreas[0].AxisY.Title = "Doanh Thu";
            // Vẽ biểu đồ
            chart1.Invalidate();
            chart1.Series["Series1"].IsVisibleInLegend = false;
        }



         private void simpleButton1_Click(object sender, EventArgs e)
         {
            using (var context = new MyDbcontext())
            {

                var datatable = context.ThongKeDoanhThu(guna2DateTimePicker1.Text,guna2DateTimePicker2.Text);
                gridControl1.DataSource = datatable;

                textBox1.Text = datatable.Rows[0]["TongDoanhThu"].ToString();
            }
            HienThiBieuDo();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}