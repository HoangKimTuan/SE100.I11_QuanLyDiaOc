using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class AdvBoardDAL : Connection
    {
        public DataTable GetInfoBoard(string maQcBang)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QCBang_LayThongTin";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maqcbang", maQcBang));
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
