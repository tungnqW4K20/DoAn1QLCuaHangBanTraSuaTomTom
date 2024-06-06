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
    public partial class QlChamCong : DevExpress.XtraEditors.XtraForm
    {
        public QlChamCong()
        {
            InitializeComponent();
        }

        private QuanLyCuaHangBanTraSuaTomTomEntities3 db = new QuanLyCuaHangBanTraSuaTomTomEntities3();


       public class ChamCongNV
        {
            public int ID { get; set; }
            public string MaNV { get; set; }
            public Nullable<int> Thang { get; set; }
            public Nullable<bool> ngay1 { get; set; }
            public Nullable<bool> ngay2 { get; set; }
            public Nullable<bool> ngay3 { get; set; }
            public Nullable<bool> ngay4 { get; set; }
            public Nullable<bool> ngay5 { get; set; }
            public Nullable<bool> ngay6 { get; set; }
            public Nullable<bool> ngay7 { get; set; }
            public Nullable<bool> ngay8 { get; set; }
            public Nullable<bool> ngay9 { get; set; }
            public Nullable<bool> ngay10 { get; set; }
            public Nullable<bool> ngay11 { get; set; }
            public Nullable<bool> ngay12 { get; set; }
            public Nullable<bool> ngay13 { get; set; }
            public Nullable<bool> ngay14 { get; set; }
            public Nullable<bool> ngay15 { get; set; }
            public Nullable<bool> ngay16 { get; set; }
            public Nullable<bool> ngay17 { get; set; }
            public Nullable<bool> ngay18 { get; set; }
            public Nullable<bool> ngay19 { get; set; }
            public Nullable<bool> ngay20 { get; set; }
            public Nullable<bool> ngay21 { get; set; }
            public Nullable<bool> ngay22 { get; set; }
            public Nullable<bool> ngay23 { get; set; }
            public Nullable<bool> ngay24 { get; set; }
            public Nullable<bool> ngay25 { get; set; }
            public Nullable<bool> ngay26 { get; set; }
            public Nullable<bool> ngay27 { get; set; }
            public Nullable<bool> ngay28 { get; set; }
            public Nullable<bool> ngay29 { get; set; }
            public Nullable<bool> ngay30 { get; set; }
            public Nullable<bool> ngay31 { get; set; }

        }

        private BUS_ChamCong buschamcong = new BUS_ChamCong();


        public void LoadData()
        {


            int thang0 = Convert.ToInt32(nUpS.Value.ToString());

            var query = from t1 in db.NhanViens.Where(x => x.TrangThai!= "Đã Nghỉ")
                        join t3 in db.ChamCongs.Where(x => x.Thang == nUpS.Value)
                        on t1.MaNV equals t3.MaNV into kq
                        from t2 in kq.DefaultIfEmpty()
                        select new ChamCongNV
                        {
                            ID = t2 != null ? t2.ID : 0,
                            MaNV = t1.MaNV,
                            Thang = t2 != null ? t2.Thang : thang0,
                            ngay1 = t2 != null ? t2.ngay1 : false,
                            ngay2 = t2 != null ? t2.ngay2 : false,
                            ngay3 = t2 != null ? t2.ngay3 : false,
                            ngay4 = t2 != null ? t2.ngay4 : false,
                            ngay5 = t2 != null ? t2.ngay5 : false,
                            ngay6 = t2 != null ? t2.ngay6 : false,
                            ngay7 = t2 != null ? t2.ngay7 : false,
                            ngay8 = t2 != null ? t2.ngay8 : false,
                            ngay9 = t2 != null ? t2.ngay9 : false,
                            ngay10 = t2 != null ? t2.ngay10 : false,
                            ngay11 = t2 != null ? t2.ngay11 : false,
                            ngay12 = t2 != null ? t2.ngay12 : false,
                            ngay13 = t2 != null ? t2.ngay13 : false,
                            ngay14 = t2 != null ? t2.ngay14 : false,
                            ngay15 = t2 != null ? t2.ngay15 : false,
                            ngay16 = t2 != null ? t2.ngay16 : false,
                            ngay17 = t2 != null ? t2.ngay17 : false,
                            ngay18 = t2 != null ? t2.ngay18 : false,
                            ngay19 = t2 != null ? t2.ngay19 : false,
                            ngay20 = t2 != null ? t2.ngay20 : false,
                            ngay21 = t2 != null ? t2.ngay21 : false,
                            ngay22 = t2 != null ? t2.ngay22 : false,
                            ngay23 = t2 != null ? t2.ngay23 : false,
                            ngay24 = t2 != null ? t2.ngay24 : false,
                            ngay25 = t2 != null ? t2.ngay25 : false,
                            ngay26 = t2 != null ? t2.ngay26 : false,
                            ngay27 = t2 != null ? t2.ngay27 : false,
                            ngay28 = t2 != null ? t2.ngay28 : false,
                            ngay29 = t2 != null ? t2.ngay29 : false,
                            ngay30 = t2 != null ? t2.ngay30 : false,
                            ngay31 = t2 != null ? t2.ngay31 : false,

                        };

            List<ChamCongNV> chamcongList = query.ToList();


            dataGridView1.DataSource = query.ToList();

            int i = buschamcong.STT();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "0")
                {
                    row.Cells[0].Value = ++i;
                }

            }


        }

        private void QlChamCong_Load(object sender, EventArgs e)
        {

            LoadData();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Refresh();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ChamCong cc = new ChamCong
                {
                    ID = int.Parse(row.Cells[0].Value.ToString()),
                    MaNV = row.Cells[1].Value.ToString(),
                    Thang = int.Parse(row.Cells[2].Value.ToString()),
                    ngay1 = bool.Parse(row.Cells[3].Value.ToString()),
                    ngay2 = bool.Parse(row.Cells[4].Value.ToString()),
                    ngay3 = bool.Parse(row.Cells[5].Value.ToString()),
                    ngay4 = bool.Parse(row.Cells[6].Value.ToString()),
                    ngay5 = bool.Parse(row.Cells[7].Value.ToString()),
                    ngay6 = bool.Parse(row.Cells[8].Value.ToString()),
                    ngay7 = bool.Parse(row.Cells[9].Value.ToString()),
                    ngay8 = bool.Parse(row.Cells[10].Value.ToString()),
                    ngay9 = bool.Parse(row.Cells[11].Value.ToString()),
                    ngay10 = bool.Parse(row.Cells[12].Value.ToString()),
                    ngay11 = bool.Parse(row.Cells[13].Value.ToString()),
                    ngay12 = bool.Parse(row.Cells[14].Value.ToString()),
                    ngay13 = bool.Parse(row.Cells[15].Value.ToString()),
                    ngay14 = bool.Parse(row.Cells[16].Value.ToString()),
                    ngay15 = bool.Parse(row.Cells[17].Value.ToString()),
                    ngay16 = bool.Parse(row.Cells[18].Value.ToString()),
                    ngay17 = bool.Parse(row.Cells[19].Value.ToString()),
                    ngay18 = bool.Parse(row.Cells[20].Value.ToString()),
                    ngay19 = bool.Parse(row.Cells[21].Value.ToString()),
                    ngay20 = bool.Parse(row.Cells[22].Value.ToString()),
                    ngay21 = bool.Parse(row.Cells[23].Value.ToString()),
                    ngay22 = bool.Parse(row.Cells[24].Value.ToString()),
                    ngay23 = bool.Parse(row.Cells[25].Value.ToString()),
                    ngay24 = bool.Parse(row.Cells[26].Value.ToString()),
                    ngay25 = bool.Parse(row.Cells[27].Value.ToString()),
                    ngay26 = bool.Parse(row.Cells[28].Value.ToString()),
                    ngay27 = bool.Parse(row.Cells[29].Value.ToString()),
                    ngay28 = bool.Parse(row.Cells[30].Value.ToString()),
                    ngay29 = bool.Parse(row.Cells[31].Value.ToString()),
                    ngay30 = bool.Parse(row.Cells[32].Value.ToString()),
                    ngay31 = bool.Parse(row.Cells[33].Value.ToString()),


                };

                if (buschamcong.SearchChamCongByManVThang(row.Cells[1].Value.ToString(), int.Parse(row.Cells[2].Value.ToString()) ).Count>0)
                {
                    buschamcong.Update(cc, int.Parse(row.Cells[2].Value.ToString()));

                }    
                else
                {
                    buschamcong.Add(cc);

                }    

            }

            XtraMessageBox.Show("Cập nhật thành công");
        }

        private void nUpS_ValueChanged(object sender, EventArgs e)
        {

            LoadData();

        }
        private BUSNhanVien busnv = new BUSNhanVien();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            decimal luongnv = Convert.ToDecimal(busnv.GetLuong(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()));
            decimal HS = 0.98M;

            string s = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            for (int i=3; i<=33;i++)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString() == "False")
                {

                    luongnv = luongnv * HS;
                }

            }

            int luongint = Convert.ToInt32(luongnv);

            guna2TextBox1.Text = luongint.ToString();
       


        }
    }
}