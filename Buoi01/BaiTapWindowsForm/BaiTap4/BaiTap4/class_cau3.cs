using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class class_cau3
    {
        public static void TachChuoi(string hoten, out string s1, out string s2)
        {
            int index = hoten.LastIndexOf(' '); // Tìm vị trí khoảng trắng cuối cùng
            if (index >= 0)
            {
                s1 = hoten.Substring(0, index); // Lấy chuỗi từ đầu đến vị trí khoảng trắng
                s2 = hoten.Substring(index + 1); // Lấy chuỗi từ vị trí khoảng trắng đến hết
            }
            else // Trường hợp không tìm thấy khoảng trắng
            {
                s1 = hoten;
                s2 = "";
            }
        }

        public static bool ThuTu(int n1, int n2)
        {
            if (n2 == n1 + 1)
            {
                return true;
            }
            return false;
        }
        public static void ChaoHoi(string hoten, int GioiTinh, out string s1)
        {
            string s2 = "";
            TachChuoi(hoten, out s1, out s2);
            if (GioiTinh == 1)
            {
                s1 = "Chào ông " + s2;
            }
            else if (GioiTinh == 2)
            {
                s1 = "Chào Bà " + s2;
            }
        }
        public static int GCD(int m, int n)
        {
            while (n != 0)
            {
                int temp = n;
                n = m % n;
                m = temp;
            }
            return m;
        }
    }
}
