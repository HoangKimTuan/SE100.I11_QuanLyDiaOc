using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDiaOc.DataAccessLayers
{
    class UserDAL : Connection
    {
        public DataTable GetListUser()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NguoiDung_LoaiNguoiDung_LayDanhSach";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
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

        public DataTable CheckUser(String name)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_NguoiDung_KiemTra";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", name));
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

        public bool InsertUser(UserDTO userDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_NguoiDung_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", userDTO.TenNguoiDung));
                sqlCommand.Parameters.Add(new SqlParameter("@mk", userDTO.MatKhau));
                sqlCommand.Parameters.Add(new SqlParameter("@malnd", userDTO.MaLoaiNguoiDung));
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool UpdateUser(UserDTO userDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_NguoiDung_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", userDTO.TenNguoiDung));
                sqlCommand.Parameters.Add(new SqlParameter("@mk", userDTO.MatKhau));
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool DeleteUser(String ma)
        {
            try
            {
                OpenConnect();
                string store = "sp_NguoiDung_Xoa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", ma));
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
