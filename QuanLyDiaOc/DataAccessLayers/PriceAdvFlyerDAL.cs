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
    class PriceAdvFlyerDAL : Connection
    {
        public DataTable GetListPriceAdvFlyer()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_GiaQCToBuom_LayDanhSach";
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

        /*
        public bool InsertPriceAdvFlyer(PriceAdvFlyerDTO PriceAdvFlyerDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makh", PriceAdvFlyerDTO.MaKH));
                sqlCommand.Parameters.Add(new SqlParameter("@maldo", PriceAdvFlyerDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", PriceAdvFlyerDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@dtkv", PriceAdvFlyerDTO.DienTichKhuanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@dtsd", PriceAdvFlyerDTO.DienTichSuDung));
                sqlCommand.Parameters.Add(new SqlParameter("@hn", PriceAdvFlyerDTO.HuongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@vt", PriceAdvFlyerDTO.ViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", PriceAdvFlyerDTO.MoTaChiTiet));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", PriceAdvFlyerDTO.GiaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", PriceAdvFlyerDTO.HinhAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@tt", PriceAdvFlyerDTO.TrangThai));
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
        */
        public bool UpdatePriceAdvFlyer(PriceAdvFlyerDTO PriceAdvFlyerDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiaQCToBuom_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", PriceAdvFlyerDTO.MaGiaQCToBuom));
                sqlCommand.Parameters.Add(new SqlParameter("@gia", PriceAdvFlyerDTO.DonGia));
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
        /*
        public bool DeletePriceAdvFlyer(string maDO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Xoa";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mado", maDO));
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
        */
    }
}
