using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataTransferObject
{
    class CustomerDTO
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public CustomerDTO(string tenkh, string gioiTinh, int namSinh, string diachi, string sdt, string email)
        {
            TenKH = tenkh;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            DiaChi = diachi;
            SDT = sdt;
            Email = email;
        }

        public CustomerDTO(string makh, string tenkh, string gioiTinh, int namSinh, string diachi, string sdt, string email)
        {
            MaKH = makh;
            TenKH = tenkh;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            DiaChi = diachi;
            SDT = sdt;
            Email = email;
        }
    }
}
