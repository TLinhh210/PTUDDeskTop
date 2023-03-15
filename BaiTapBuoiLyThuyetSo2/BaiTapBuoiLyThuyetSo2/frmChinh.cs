using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoiLyThuyetSo2
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmi35_Click(object sender, EventArgs e)
        {
            var form = new frm35();
            form.ShowDialog();
        }

        private void tsmi42_Click(object sender, EventArgs e)
        {
            var form = new frm42();
            form.ShowDialog();
        }

        private void tsmi48_Click(object sender, EventArgs e)
        {
            var form = new frm48();
            form.ShowDialog();
        }

        private void tsmi52_Click(object sender, EventArgs e)
        {
            var form = new frm52();
            form.ShowDialog();
        }

        private void tsmi56_Click(object sender, EventArgs e)
        {
            var form = new frm56();
            form.ShowDialog();
        }

        private void tsmi57_Click(object sender, EventArgs e)
        {
            var form = new frm57();
            form.ShowDialog();
        }

        private void tsmi60_Click(object sender, EventArgs e)
        {
            var form = new frm60();
            form.ShowDialog();
        }
    }
}
