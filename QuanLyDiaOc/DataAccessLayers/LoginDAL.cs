using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class LoginDAL : Connection
    {
        public DataTable CheckLogin(string user, string pass)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NguoiDung_LayDanhSach";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@user", user));
                sqlCommand.Parameters.Add(new SqlParameter("@pass", pass));
                sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(data);
                return data;
            }
            catch
            {
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }

        public string GetType(string user)
        {
            string s = null;

            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NguoiDung_LoaiNguoiDung_LayLoaiNguoiDung";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@user", user));
                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["LoaiNguoiDung"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                CloseConnect();
            }

            return s;
        }
    }
}
