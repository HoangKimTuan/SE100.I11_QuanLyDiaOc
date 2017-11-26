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
        public string DiaChi { get; set; }
        public double DienTichKhuanVien { get; set; }
        public double DienTichSuDung { get; set; }
        public string HuongNha { get; set; }
        public string ViTri { get; set; }
        public string MoTaChiTiet { get; set; }
        public string GiaBan { get; set; }
        public int HinhAnh { get; set; }
        public string TrangThai { get; set; }

        public RealEstateDTO(string maKH, string maLoaiDiaOc, string diaChi, double dienTichKhuanVien, double dienTichSuDung, string huongNha, string viTri, string moTaChiTiet, string giaBan, int hinhAnh, string trangThai)
        {
            MaKH = maKH;
            MaLoaiDiaOc = maLoaiDiaOc;
            DiaChi = diaChi;
            DienTichKhuanVien = dienTichKhuanVien;
            DienTichSuDung = dienTichSuDung;
            HuongNha = huongNha;
            ViTri = viTri;
            MoTaChiTiet = moTaChiTiet;
            GiaBan = giaBan;
            HinhAnh = hinhAnh;
            TrangThai = trangThai;
        }

        public RealEstateDTO(string maDO, string maKH, string maLoaiDiaOc, string diaChi, double dienTichKhuanVien, double dienTichSuDung, string huongNha, string viTri, string moTaChiTiet, string giaBan, int hinhAnh, string trangThai)
        {
            MaDO = maDO;
            MaKH = maKH;
            MaLoaiDiaOc = maLoaiDiaOc;
            DiaChi = diaChi;
            DienTichKhuanVien = dienTichKhuanVien;
            DienTichSuDung = dienTichSuDung;
            HuongNha = huongNha;
            ViTri = viTri;
            MoTaChiTiet = moTaChiTiet;
            GiaBan = giaBan;
            HinhAnh = hinhAnh;
            TrangThai = trangThai;
        }
    }
}
