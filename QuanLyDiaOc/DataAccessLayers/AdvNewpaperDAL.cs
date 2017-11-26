using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class AdvNewpaperDAL :Connection
    {
        public string GetIdTypeAdvNewpaper(string maqc)
        {
            OpenConnect();
            const string store = "sp_QC_Bao_LayMaTienGiaBaoDangKy";
            sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            sqlCommand.Parameters.Add(new SqlParameter("@maqc", maqc));
            var reader = sqlCommand.ExecuteReader();

            string s = null;
            while (reader.Read())
            {
                s = reader["MATIENQCBAO"].ToString();
            }
            CloseConnect();
            return s;
        }

        public DataTable GetInfoTypeAdv(string maqc)
        {
            OpenConnect();
            var data = new DataTable();
            const string store = "QC_BAO_LayGiaTien";
            sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            sqlCommand.Parameters.Add(new SqlParameter("@ma", maqc));
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            CloseConnect();
            return data;
        }

    }
}
