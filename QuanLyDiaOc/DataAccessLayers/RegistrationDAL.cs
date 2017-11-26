using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class RegistrationDAL :Connection
    {
        public DataTable GetInfoRegistration(string makh, string mado)
        {
            OpenConnect();
            DataTable data = new DataTable();
            const string store = "sp_DangKy_LayThongTin";
            sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            sqlCommand.Parameters.Add(new SqlParameter("@makh", makh));
            sqlCommand.Parameters.Add(new SqlParameter("@mado", mado));
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            CloseConnect();
            return data;
        }
    }
}
