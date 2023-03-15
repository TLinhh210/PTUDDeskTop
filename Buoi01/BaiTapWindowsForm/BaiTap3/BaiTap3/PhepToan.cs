using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class PhepToan
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

        public static bool ThuTu(int n1,int n2)
        {
            if (n2 == n1 + 1)
            {
                return true;
            }
            return false;
        }

    }
}
