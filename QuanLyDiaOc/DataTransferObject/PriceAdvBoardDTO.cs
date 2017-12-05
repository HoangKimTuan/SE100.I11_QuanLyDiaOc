using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataTransferObject
{
    class PriceAdvBoardDTO
    {
        public string MaGiaQCTrenBang { get; set; }
        public int MaLoaiBang { get; set; }
        public float KichThuoc { get; set; }
        public Boolean HinhAnh { get; set; }
        public double DonGia { get; set; }

        public PriceAdvBoardDTO(string maGiaQCTrenBang, int maLoaiBang, float kichThuoc, Boolean hinhAnh, double donGia)
        {
            MaGiaQCTrenBang = maGiaQCTrenBang;
            MaLoaiBang = maLoaiBang;
            KichThuoc = kichThuoc;
            HinhAnh = hinhAnh;
            DonGia = donGia;
        }

        public PriceAdvBoardDTO(string maGiaQCTrenBang, double donGia)
        {
            MaGiaQCTrenBang = maGiaQCTrenBang;
            DonGia = donGia;
        }
    }
}
