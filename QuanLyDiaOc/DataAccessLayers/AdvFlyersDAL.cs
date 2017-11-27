using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class AdvFlyersDAL : Connection
    {
        public DataTable GetInfoFlyers(string maQcToBuom)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QCToBuom_LayThongTin";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maqctobuom", maQcToBuom));
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
