using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class BillDAL : Connection
    {
        public bool RenewalBill(string madk, double tienGiaHan)
        {
            OpenConnect();
            string store = "sp_HoaDon_GiaHan";
            sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            sqlCommand.Parameters.Add(new SqlParameter("@SoPDK", madk));
            sqlCommand.Parameters.Add(new SqlParameter("@TONGCONG", tienGiaHan));
            sqlCommand.Parameters.Add(new SqlParameter("@TINHTRANGTHANHTOAN", 1));
            sqlCommand.Parameters.Add(new SqlParameter("@NGAYGIAHAN", 1));
            if (sqlCommand.ExecuteNonQuery() >= 0)
            {
                CloseConnect();
                return true;
            }
            else
            {
                CloseConnect();
                return false;
            }
        }
    }
}
