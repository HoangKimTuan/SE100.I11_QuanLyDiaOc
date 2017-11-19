using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class SettingDAL : Connection
    {
        public DataTable GetListParamater()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                String store = "sp_ThamSo_LayDanhSach";
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

        public String GetMinAge()
        {
            try
            {
                OpenConnect();
                String data = "";
                String store = "sp_ThamSo_LayTuoiToiThieu";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data = reader.GetString(0);
                    }
                }
                CloseConnect();
                return data;
            }
            catch
            {
                return null;
            }
        }

        public String GetMaxAge()
        {
            try
            {
                OpenConnect();
                String data = "";
                String store = "sp_ThamSo_LayTuoiToiDa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data = reader.GetString(0);
                    }
                }
                CloseConnect();
                return data;
            }
            catch
            {
                return null;
            }
        }

        public String GetInterestRate()
        {
            try
            {
                OpenConnect();
                String data = "";
                String store = "sp_ThamSo_LayLaiSuatGiaHan";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data = reader.GetString(0);
                    }
                }
                CloseConnect();
                return data;
            }
            catch
            {
                return null;
            }
        }

        public String GetNumberWords()
        {
            try
            {
                OpenConnect();
                String data = "";
                String store = "sp_ThamSo_LaySoTuQuangCao";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data = reader.GetString(0);
                    }
                }
                CloseConnect();
                return data;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateParamater(String laiSuat, String moTa, String tuoi)
        {
            try
            {
                OpenConnect();
                String store = "sp_ThamSo_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@laiSuat", laiSuat));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", moTa));
                sqlCommand.Parameters.Add(new SqlParameter("@tuoi", tuoi));
                sqlCommand.ExecuteNonQuery();
                CloseConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
