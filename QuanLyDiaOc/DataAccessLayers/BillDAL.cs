using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class BillDAL :Connection
    {
        public DataTable GetBill(string madk)
        {
            OpenConnect();
            DataTable data = new DataTable();
            const string store = "sp_HoaDon_LayThongTin";
            sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            sqlCommand.Parameters.Add(new SqlParameter("@madk", madk));
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            CloseConnect();
            return data;
        }
    }
}
