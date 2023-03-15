using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }


        private void btnXemKq_Click(object sender, EventArgs e)
        {
            var n = int.Parse(txtN.Text);
            var kq = 0;
            if (rdTong.Checked)
            {
                
                for(int i = 1; i <= n; i++)
                {
                    kq += i;
                    lblKetQua.Text = kq.ToString();
                }
            }
            else
            {
                kq = 1;
                for(int i = 1; i <= n;i++)
                {
                    kq *= i;
                    lblKetQua.Text = "";
                    lblKetQua.Text += kq.ToString();
                }
            }
        }
    }
}
