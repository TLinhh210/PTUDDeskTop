using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi{ get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi() { }
        public ThietBi(string maThietBi,string tenThietBi,string nuocSanXuat,int donGia,int soLuong)
        {
            this.MaThietBi = maThietBi;
            this.TenThietBi = tenThietBi;
            this.NuocSanXuat = nuocSanXuat;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }
        public static int ThanhTien(int donGia,int soLuong)
        {
            int Tong = 0;
            Tong = donGia*soLuong;
            return Tong;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
