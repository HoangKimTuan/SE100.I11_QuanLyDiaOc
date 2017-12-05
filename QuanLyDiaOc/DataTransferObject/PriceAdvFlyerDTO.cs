using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataTransferObject
{
    class PriceAdvFlyerDTO
    {
        public string MaGiaQCToBuom { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        public PriceAdvFlyerDTO(string maGiaQCToBuom, int soLuong, double donGia)
        {
            MaGiaQCToBuom = maGiaQCToBuom;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public PriceAdvFlyerDTO(string maGiaQCToBuom,  double donGia)
        {
            MaGiaQCToBuom = maGiaQCToBuom;
            DonGia = donGia;
        }
    }
}
