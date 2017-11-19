using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataTransferObject
{
    class UserDTO
    {
        public String MaNguoiDung { get; set; }
        public String TenNguoiDung { get; set; }
        public String MatKhau { get; set; }
        public String MaLoaiNguoiDung { get; set; }

        public UserDTO()
        {
        }

        public UserDTO(string tenNguoiDung, string matKhau, string maLoaiNguoiDung)
        {
            TenNguoiDung = tenNguoiDung;
            MatKhau = matKhau;
            MaLoaiNguoiDung = maLoaiNguoiDung;
        }

        public UserDTO(string tenNguoiDung, string matKhau)
        {
            TenNguoiDung = tenNguoiDung;
            MatKhau = matKhau;
        }
    }
}
