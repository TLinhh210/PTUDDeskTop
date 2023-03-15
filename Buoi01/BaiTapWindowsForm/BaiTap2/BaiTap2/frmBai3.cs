using System;
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
    public partial class frmBai3_ : Form
    {
        public frmBai3_()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            var Ho= string.Copy(txtHo.Text);
            var Ten =string.Copy(txtTen.Text);
            var n=int.Parse(txtN.Text);
            string s="";
            long kq;

            if(rdNoiChuoi.Checked )
            {
                PhepToan.NoiChuoi(Ho, Ten,ref s);
                lblKetQua.Text = s.ToString();
            }
            else
            {
                kq = PhepToan.GiaiThua(n);
                lblKetQua .Text = kq.ToString();
            }
        }
    }
}
