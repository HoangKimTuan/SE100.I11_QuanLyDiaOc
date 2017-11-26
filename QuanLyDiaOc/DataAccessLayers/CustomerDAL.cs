using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DataTransferObject;

namespace QuanLyDiaOc.DataAccessLayers
{
    class CustomerDAL : Connection
    {
        public DataTable GetListCustomer()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_KhachHang_LayDanhSach";
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

        public DataTable SearchCustomer(string tuKhoa)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_KhachHang_TimKiem";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@tukhoa", tuKhoa));
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

        public DataTable SearchCustomer(string makh, string tenkh, string diachi, string sdt)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_KhachHang_TimKiem_2";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makh", makh));
                sqlCommand.Parameters.Add(new SqlParameter("@tenkh", tenkh));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", diachi));
                sqlCommand.Parameters.Add(new SqlParameter("@sdt", sdt));
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

        public bool InsertCustomer(CustomerDTO customerDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_KhachHang_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ten", customerDTO.TenKH));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", customerDTO.GioiTinh));
                sqlCommand.Parameters.Add(new SqlParameter("@namsinh", customerDTO.NamSinh));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", customerDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@sdt", customerDTO.SDT));
                sqlCommand.Parameters.Add(new SqlParameter("@email", customerDTO.Email));
                sqlCommand.ExecuteNonQuery();
                CloseConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(string maKH)
        {
            try
            {
                OpenConnect();
                string store = "sp_KhachHang_Xoa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", maKH));
                sqlCommand.ExecuteNonQuery();
                CloseConnect();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(CustomerDTO customerDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_KhachHang_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", customerDTO.MaKH));
                sqlCommand.Parameters.Add(new SqlParameter("@ten", customerDTO.TenKH));
                sqlCommand.Parameters.Add(new SqlParameter("@gioitinh", customerDTO.GioiTinh));
                sqlCommand.Parameters.Add(new SqlParameter("@namsinh", customerDTO.NamSinh));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", customerDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@sdt", customerDTO.SDT));
                sqlCommand.Parameters.Add(new SqlParameter("@email", customerDTO.Email));
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
