﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = "TB01";
            tb.TenThietBi = "Lenovo";
            tb.NuocSanXuat = "Trung Quốc";
            tb.DonGia = 20000000;
            tb.SoLuong = 10;

            lblThongBao.Text = tb.HienThi();

        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
