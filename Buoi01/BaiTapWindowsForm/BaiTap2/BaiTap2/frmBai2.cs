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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void txtSoTN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXemKq_Click(object sender, EventArgs e)
        {
            var n1= int.Parse(txtSoTN.Text);
            var n2 = int .Parse(txtSoTH.Text);
            var kq = 0;
            if(rdCong.Checked)
            {
                kq = n1 + n2;
                lblKetQua.Text=kq.ToString();
            }
            else if(rdTru.Checked)
            {
                kq= n1 - n2;
                lblKetQua.Text=kq.ToString();
            }
            else if(rdNhan.Checked)
            {
                kq = n1 * n2;
                lblKetQua.Text = kq.ToString();
            }
            else
            {
                kq = n1 / n2;
                lblKetQua.Text=kq.ToString();
            }

        }
    }
}
