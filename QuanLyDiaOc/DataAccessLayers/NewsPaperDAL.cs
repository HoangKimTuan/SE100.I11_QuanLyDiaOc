using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class NewsPaperDAL : Connection
    {
        public DataTable GetListNewspaper(string maqc)
        {
            OpenConnect();
            DataTable data = new DataTable();
            data.Columns.Add("MABAO", typeof(string));
            data.Columns.Add("TENBAO", typeof(string));
            data.Columns.Add("THUPHATHANH", typeof(string));
            data.Columns.Add("STATUS", typeof(bool));
            DataRow row = null;
            const string store = "sp_QC_Bao_LayDanhSach";
            sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                row = data.NewRow();
                row[0] = reader["MABAO"].ToString();
                row[1] = reader["TENBAO"].ToString();
                row[2] = reader["THUPHATHANH"].ToString();
                SqlCommand com = new SqlCommand("sp_QC_Bao_KiemTraMaBaoDangKy", connect) { CommandType = CommandType.StoredProcedure };
                com.Parameters.Add(new SqlParameter("@mabao", reader["MABAO"].ToString()));
                com.Parameters.Add(new SqlParameter("@maqc", maqc));
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    if (r == null)
                    {
                        row[3] = false;
                    }
                    else
                    {
                        row[3] = true;
                    }
                }
                data.Rows.Add(row);
            }
            CloseConnect();
            return data;
        }
    }
}
