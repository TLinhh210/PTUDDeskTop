using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoiLyThuyetSo2
{
    public partial class frm35 : Form
    {
        public frm35()
        {
            InitializeComponent();
        }

        private void frm35_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk45B@gmail.com";
            this.lbDiaChi.Links.Add(0, strURL.Length, strURL);
            strURL = "http://www.cnttk45B.net";
            this.lbTrangWeb.Links.Add(0, strURL.Length, strURL);
        }

        private void lbDiaChi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
            {
                Process.Start(strURL + "?subject=hello");
            }
        }

        private void lbTrangWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://www."))
            {
                Process.Start(strURL);
                //Process.Start("IExplore", strURL)
            }

        }
    }
}
