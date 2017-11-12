using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataTransferObject
{
    class RealEstateDTO
    {
        public string MaDO { get; set; }
        public string MaKH { get; set; }
        public string MaLoaiDiaOc { get; set; }
        public int SoNha { get; set; }
        public string Duong { get; set; }
        public string Phuong { get; set; }
        public string Quan { get; set; }
        public double DienTichDat { get; set; }
        public double DienTichXayDung { get; set; }
        public string Huong { get; set; }
        public string ViTri { get; set; }
        public string MoTaChiTiet { get; set; }
        public string MoTaTomTat { get; set; }
        public int HinhAnh { get; set; }
        public string TrangThai { get; set; }

        public RealEstateDTO(string maKH, string maLoaiDiaOc, int soNha, string duong, string phuong, string quan, double dienTichDat, double dienTichXayDung, string huong, string viTri, string moTaChiTiet, string moTaTomTat, int hinhAnh, string trangThai)
        {
            MaKH = maKH;
            MaLoaiDiaOc = maLoaiDiaOc;
            SoNha = soNha;
            Duong = duong;
            Phuong = phuong;
            Quan = quan;
            DienTichDat = dienTichDat;
            DienTichXayDung = dienTichXayDung;
            Huong = huong;
            ViTri = viTri;
            MoTaChiTiet = moTaChiTiet;
            MoTaTomTat = moTaTomTat;
            HinhAnh = hinhAnh;
            TrangThai = trangThai;
        }

        public RealEstateDTO(string maDO, string maKH, string maLoaiDiaOc, int soNha, string duong, string phuong, string quan, double dienTichDat, double dienTichXayDung, string huong, string viTri, string moTaChiTiet, string moTaTomTat, int hinhAnh, string trangThai)
        {
            MaDO = maDO;
            MaKH = maKH;
            MaLoaiDiaOc = maLoaiDiaOc;
            SoNha = soNha;
            Duong = duong;
            Phuong = phuong;
            Quan = quan;
            DienTichDat = dienTichDat;
            DienTichXayDung = dienTichXayDung;
            Huong = huong;
            ViTri = viTri;
            MoTaChiTiet = moTaChiTiet;
            MoTaTomTat = moTaTomTat;
            HinhAnh = hinhAnh;
            TrangThai = trangThai;
        }
    }
}
