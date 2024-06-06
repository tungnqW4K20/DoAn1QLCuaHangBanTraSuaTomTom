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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDoAa1111
{
    public partial class QlBan : DevExpress.XtraEditors.XtraForm
    {
        public QlBan()
        {
            InitializeComponent();
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {

        }

        private void btnBan1_Click(object sender, EventArgs e)
        {

        }

        private void btnBan10_Click(object sender, EventArgs e)
        {

        }

        private void btnBan2_Click(object sender, EventArgs e)
        {

        }

        private void btnBan9_Click(object sender, EventArgs e)
        {

        }

        private void btnBan3_Click(object sender, EventArgs e)
        {

        }

        private void btnBan7_Click(object sender, EventArgs e)
        {

        }

        private void btnBan4_Click(object sender, EventArgs e)
        {

        }

        private void btnBan6_Click(object sender, EventArgs e)
        {

        }

        private void btnBan5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBan1_Click_1(object sender, EventArgs e)
        {
            lableBan.Text = "1";
            HienThiLuoi(busor.SearchOrderByID(1));
            ThanhTienTong();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lableBan.Text = "2";

            HienThiLuoi(busor.SearchOrderByID(2));
            ThanhTienTong();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lableBan.Text = "3";
            HienThiLuoi(busor.SearchOrderByID(3));
            ThanhTienTong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lableBan.Text = "4";
            HienThiLuoi(busor.SearchOrderByID(4));
            ThanhTienTong();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lableBan.Text = "5";
            HienThiLuoi(busor.SearchOrderByID(5));
            ThanhTienTong();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lableBan.Text = "6";
            HienThiLuoi(busor.SearchOrderByID(6));
            ThanhTienTong();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lableBan.Text = "7";
            HienThiLuoi(busor.SearchOrderByID(7));
            ThanhTienTong();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lableBan.Text = "8";
            HienThiLuoi(busor.SearchOrderByID(8));
            ThanhTienTong();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lableBan.Text = "9";
            HienThiLuoi(busor.SearchOrderByID(9));
            ThanhTienTong();
        }


        private BUS_DoUong busdu = new BUS_DoUong();

        private BUS_DatBan busdatban = new BUS_DatBan();


        private BUS_Order busor = new BUS_Order();


        private void QlBan_Load(object sender, EventArgs e)
        {

            cbChonMon.DataSource = busdu.GetAll();
            cbChonMon.DisplayMember = "TenDoUong";
            cbChonMon.ValueMember = "MaDoUong";




        }


        private void HienThiLuoi(List<Order> nlList)
        {

            dataGridView1.DataSource = nlList.Select(x => new { x.ID, x.SoBan, x.MaDoUong, x.SoLuongS, x.SoLuongM, x.SoLuongL }).ToList();
        }

        private void ThanhTienTong()
        {


            int slNho, slVua, slLon;
            decimal ThanhTien = 0;
            decimal giatienS, giatienM, GiatienL;
            string MaDoUong;

            //if(dataGridView1.Rows.Count==1)
            //{

            //    txtThanhTien.Text = "0";
            //    return;
            //}    
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                {
                    continue; // Bỏ qua dòng cuối cùng (nếu có)
                }

   

                // Lấy tên đồ uống từ cột 0

                MaDoUong = (row.Cells[2].Value.ToString());

                giatienS = busdu.GetTienS(MaDoUong);
                giatienM = busdu.GetTienM(MaDoUong);
                GiatienL = busdu.GetTienL(MaDoUong);
                //// Lấy số lượng từ các cột 1, 2, và 3
                slNho = Convert.ToInt32(row.Cells[3].Value);
                slVua = Convert.ToInt32(row.Cells[4].Value);
                slLon = Convert.ToInt32(row.Cells[5].Value);

                ThanhTien += giatienS * slNho + giatienM * slVua + giatienM * slLon;

            }


            txtThanhTien.Text = ThanhTien.ToString();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        
            TrangThaiBan ttb = new TrangThaiBan
            {
                SoBan = int.Parse(lableBan.Text),
                TrangThai =true

            };

            busdatban.Update(ttb);

            int ID = busor.GetAll().Count;

            Order od = new Order
            {
                ID = ID + 1,
                SoBan = int.Parse(lableBan.Text),
                MaDoUong = cbChonMon.SelectedValue.ToString(),
                SoLuongS= int.Parse(nUpS.Value.ToString()),
                SoLuongM = int.Parse(nUpM.Value.ToString()),
                SoLuongL = int.Parse(nUpL.Value.ToString()),

            };

            busor.Add(od);

            HienThiLuoi(busor.SearchOrderByID(int.Parse(lableBan.Text)));
            ThanhTienTong();
              XtraMessageBox.Show("Thêm thành công");





        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int ID1, soban = 0 ;
            // Lặp qua từng dòng trong dtvChiTiet
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                // Lấy tên đồ uống từ cột 0
                ID1 = int.Parse(row.Cells[0].Value.ToString());
                soban = int.Parse(row.Cells[1].Value.ToString());

                //MaDoUong = (row.Cells[2].Value.ToString());

                //// Lấy số lượng từ các cột 1, 2, và 3
                //slNho = Convert.ToInt32(row.Cells[3].Value);
                //slVua = Convert.ToInt32(row.Cells[4].Value);
                //slLon = Convert.ToInt32(row.Cells[5].Value);

                //Order od = new Order
                //{
                //    ID = IDChon,
                //    SoBan = soban,
                //    MaDoUong =MaDoUong,
                //    SoLuongS = slNho,
                //    SoLuongM = slVua,
                //    SoLuongL =slLon,

                //};

                busor.Delete(ID1);
        
            }

            TrangThaiBan ttb = new TrangThaiBan
            {
                SoBan = soban,
                TrangThai = false

            };

            busdatban.Update(ttb);
            txtThanhTien.Text = "";
            HienThiLuoi(busor.SearchOrderByID(int.Parse(lableBan.Text)));

        }

        int IDChon;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

             IDChon = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                cbChonMon.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                nUpS.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                nUpM.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
              nUpL.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());


        }

        private void button9_Click(object sender, EventArgs e)
        {

            busor.Delete(IDChon);
            HienThiLuoi(busor.SearchOrderByID(int.Parse(lableBan.Text)));
            ThanhTienTong();
            
            XtraMessageBox.Show("Xóa thành công");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}