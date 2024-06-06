using BUS;
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
using System.Xml.Linq;

namespace WindowsFormsAppDoAa1111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private BUS_DoUong busdouong = new BUS_DoUong();
        private BUS_TaiKHoan BUS_TaiKHoan = new BUS_TaiKHoan();

        private void button1_Click(object sender, EventArgs e)
        {


            //DoUong newdouong = new DoUong
            //{
            //    MaDoUong = int.Parse(textBox1.Text),
            //    TenDoUong = textBox2.Text
            //};

            //busdouong.Add(newdouong);
            TaiKhoan newtk = new TaiKhoan
            {
                TenTK = "",
                MaNV = textBox2.Text,
                LoaiTK="",
                MatKhau=""
            };

            BUS_TaiKHoan.Add(newtk);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
