using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            if(rdChao.Checked)
            {
                var hoten=txtHoTen.Text;
                string s1 = "";
                int GioiTinh;
                if (rdNam.Checked)
                {
                    GioiTinh = 1;
                }
                else
                {
                    GioiTinh = 2;
                }
                class_cau3.ChaoHoi(hoten, GioiTinh, out s1);
                lblKetQua.Text = s1;
            }
            if(rdUCLN.Checked)
            {
                var m=int.Parse(txtM.Text);
                var n=int.Parse(txtN.Text);
                int kq = 0;
                kq=class_cau3.GCD(m, n);
                lblKetQua.Text=kq.ToString();
            }
        }
    }
}
