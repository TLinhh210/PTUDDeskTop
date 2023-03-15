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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        NhanVien nv =new NhanVien();

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string ten in listBox1.SelectedItems)
            {
                switch (ten)
                {
                    case "Nguyễn Văn A":
                        txtMa.Text = "NV001";
                        txtHoTen.Text = "Nguyễn Văn A";
                        dtpNgay.Value = new DateTime(1999, 01, 01);
                        txtHeSoLuong.Text = "5.0";
                        txtHeSoPhuCap.Text = "2.5";
                        nv.MaNV=txtMa.Text;
                        nv.HoTen = txtHoTen.Text;
                        nv.NgaySinh=dtpNgay.Value;
                        nv.HeSoLuong = double.Parse(txtHeSoLuong.Text);
                        nv.HeSoPhuCap = double.Parse(txtHeSoPhuCap.Text);

                        txtThongTin.Text = nv.HienThi();
                        break;
                    case "Nguyễn Thị B":
                        txtMa.Text = "NV002";
                        txtHoTen.Text = "Nguyễn Văn B";
                        dtpNgay.Value = new DateTime(1999, 12, 01);
                        txtHeSoLuong.Text = "4.0";
                        txtHeSoPhuCap.Text = "1.5";
                        nv.MaNV = txtMa.Text;
                        nv.HoTen = txtHoTen.Text;
                        nv.NgaySinh = dtpNgay.Value;
                        nv.HeSoLuong = double.Parse(txtHeSoLuong.Text);
                        nv.HeSoPhuCap = double.Parse(txtHeSoPhuCap.Text);

                        txtThongTin.Text = nv.HienThi();
                        break;
                    case "Nguyễn Văn C":
                        txtMa.Text = "NV003";
                        txtHoTen.Text = "Nguyễn Văn C";
                        dtpNgay.Value = new DateTime(1979, 06, 15);
                        txtHeSoLuong.Text = "3.5";
                        txtHeSoPhuCap.Text = "2.5";
                        nv.MaNV = txtMa.Text;
                        nv.HoTen = txtHoTen.Text;
                        nv.NgaySinh = dtpNgay.Value;
                        nv.HeSoLuong = double.Parse(txtHeSoLuong.Text);
                        nv.HeSoPhuCap = double.Parse(txtHeSoPhuCap.Text);

                        txtThongTin.Text = nv.HienThi();
                        break;
                    case "Nguyễn Thị D":
                        txtMa.Text = "NV004";
                        txtHoTen.Text = "Nguyễn Văn D";
                        dtpNgay.Value = new DateTime(2000, 08, 02);
                        txtHeSoLuong.Text = "8.0";
                        txtHeSoPhuCap.Text = "2.5";
                        nv.MaNV = txtMa.Text;
                        nv.HoTen = txtHoTen.Text;
                        nv.NgaySinh = dtpNgay.Value;
                        nv.HeSoLuong = double.Parse(txtHeSoLuong.Text);
                        nv.HeSoPhuCap = double.Parse(txtHeSoPhuCap.Text);

                        txtThongTin.Text = nv.HienThi();
                        break;

                    default
                        :
                        break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var HeSoluong = double.Parse(txtHeSoLuong.Text);
            var HeSoPhuCap=double.Parse(txtHeSoPhuCap.Text);
            double TongLuong;
            TongLuong =NhanVien.TongLuong(HeSoluong, HeSoPhuCap);
            lblTongLuong.Text=TongLuong.ToString()+ " Đồng";
        }
    }
}
