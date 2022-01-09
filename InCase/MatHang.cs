using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPaperSellManager
{
    abstract class MatHang
    {
        public string MaMH {get;set;}
        public string TenHang {get;set;}
        public int DonGiaNhap{get;set;}
        public int DonGiaBan{get;set;}
        public string KichThuoc { get; set; }
        public int DinhLuong { get; set; }
        public int SoLuong { get; set; }
        //public int ThanhTien { get; set; }
        public MatHang()
        {
            MaMH = TenHang = KichThuoc = null;
            DonGiaBan = DonGiaNhap = DinhLuong = SoLuong = 0;
            //ThanhTien = 0;
        }
        public MatHang(string maMH, string tenHang, int donGiaNhap, int donGiaBan, string kichThuoc, int dinhLuong, int soLuong)
        {
            MaMH = maMH;
            TenHang = tenHang;
            DonGiaNhap = donGiaNhap;
            DonGiaBan = donGiaBan;
            KichThuoc = kichThuoc;
            DinhLuong = dinhLuong;
            SoLuong = soLuong;
        }
        public MatHang(MatHang obj)
        {
            MaMH = obj.MaMH;
            TenHang = obj.TenHang;
            DonGiaNhap = obj.DonGiaNhap;
            DonGiaBan = obj.DonGiaBan;
            KichThuoc = obj.KichThuoc;
            DinhLuong = obj.DinhLuong;
            SoLuong = obj.SoLuong;
        }
        public abstract int ThanhTien();
    }
   
}
