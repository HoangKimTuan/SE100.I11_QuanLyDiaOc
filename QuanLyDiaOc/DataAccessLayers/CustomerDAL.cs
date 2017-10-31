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
    }
}
