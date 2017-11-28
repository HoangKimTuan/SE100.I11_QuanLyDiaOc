using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class RenewalDAL : Connection
    {
        public DataTable GetListRenewal()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DangKy_LayDanhSachHetHan";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(data);
                CloseConnect();
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}
