using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class advNewspaperBLLDAL : Connection
    {
        public DataTable GetInfoNewspaper(string maqcbao)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_QCBao_LayThongTin";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maqcbao", maqcbao));
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

        public DataTable GetListNewspaper(string maqcbao)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_Bao_LayDanhSachBao";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maqcbao", maqcbao));
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
