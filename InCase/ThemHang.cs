using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPaperSellManager
{
    class ThemHang : MatHang
    {

        public ThemHang()
            : base()
        {

        }
        public ThemHang(string maMH, string tenHang, int donGiaNhap, int donGiaBan, string kichThuoc, int dinhLuong, int soLuong): base(maMH, tenHang,donGiaNhap, donGiaBan, kichThuoc, dinhLuong, soLuong)
        {

        }

        public ThemHang(ThemHang obj)
            : base(obj)
        {

        }

     
        public override int ThanhTien()
        {
            return SoLuong * DonGiaNhap;
        }
    }
}
