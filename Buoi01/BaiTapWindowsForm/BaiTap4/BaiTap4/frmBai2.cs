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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            var LT=double.Parse(txtDiemLT.Text);
            var TH=double.Parse(txtDiemTH.Text);
            double kq = LT*TH/2;
            if (kq < 5)
                lblXepLoai.Text = "Yếu";
            else if (kq < 7)
                lblXepLoai.Text = "Trung Bình";
            else if (kq >= 7 && kq < 8)
                lblXepLoai.Text = "Khá";
            else if (kq >= 8 && kq < 9)
                lblXepLoai.Text = "Giỏi";
            else if(kq>=9)
                lblXepLoai.Text = "Xuất sắc";
        }
    }
}
