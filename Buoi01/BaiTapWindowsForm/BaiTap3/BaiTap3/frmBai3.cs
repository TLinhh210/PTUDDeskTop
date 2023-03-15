using System;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if(rdTachChuoi.Checked)
            {
                var hoten=txtHoTen.Text;
                string ho = "";
                string ten = "";
                PhepToan.TachChuoi(hoten,out ho,out ten);
                lblHo.Text = ho;
                lblKetQua.Text = ten;
            }
            else
            {
                lblHo.Text = "";
                var n1 = int.Parse(txtN1.Text);
                var n2 =int.Parse(txtN2.Text);
                if (PhepToan.ThuTu(n1, n2) == true)
                    lblKetQua.Text = "Là 2 số nguyên liên tiếp";
                else
                    lblKetQua.Text = "Là 2 số nguyên không liên tiếp";
            }
        }
    }
}
