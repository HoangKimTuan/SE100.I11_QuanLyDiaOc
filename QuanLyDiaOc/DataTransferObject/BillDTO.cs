using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataTransferObject
{
    class BillDTO
    {
        private string MaHD { get; set; }
        private string MaDK { get; set; }
        private bool TinhTrangDK { get; set; }
        private DateTime NgayThanhToan { get; set; }
        private double TongCong { get; set; }
        private bool GiaHan { get; set; }
    }
}
