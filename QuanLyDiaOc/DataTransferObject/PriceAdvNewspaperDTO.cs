using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataTransferObject
{
    class PriceAdvNewspaperDTO
    {
        public string MaGiaQCTrenBao { get; set; }
        public string ViTri { get; set; }
        public Boolean MauSac { get; set; }
        public Boolean HinhAnh { get; set; }
        public double DonGia { get; set; }

        public PriceAdvNewspaperDTO(string maGiaQCTrenBao, string viTri, Boolean mauSac, Boolean hinhAnh, double donGia)
        {
            MaGiaQCTrenBao = maGiaQCTrenBao;
            ViTri = viTri;
            MauSac = mauSac;
            HinhAnh = hinhAnh;
            DonGia = donGia;
        }

        public PriceAdvNewspaperDTO(string maGiaQCTrenBao, double donGia)
        {
            MaGiaQCTrenBao = maGiaQCTrenBao;
            DonGia = donGia;
        }
    }
}
