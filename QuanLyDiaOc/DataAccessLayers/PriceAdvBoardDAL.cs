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
    class PriceAdvBoardDAL : Connection
    {
        public DataTable GetListPriceAdvBoard()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_GiaQCTrenBang_LayDanhSach";
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
        public bool InsertPriceAdvBoard(PriceAdvBoardDTO PriceAdvBoardDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makh", PriceAdvBoardDTO.MaKH));
                sqlCommand.Parameters.Add(new SqlParameter("@maldo", PriceAdvBoardDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", PriceAdvBoardDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@dtkv", PriceAdvBoardDTO.DienTichKhuanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@dtsd", PriceAdvBoardDTO.DienTichSuDung));
                sqlCommand.Parameters.Add(new SqlParameter("@hn", PriceAdvBoardDTO.HuongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@vt", PriceAdvBoardDTO.ViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", PriceAdvBoardDTO.MoTaChiTiet));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", PriceAdvBoardDTO.GiaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", PriceAdvBoardDTO.HinhAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@tt", PriceAdvBoardDTO.TrangThai));
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
        public bool UpdatePriceAdvBoard(PriceAdvBoardDTO PriceAdvBoardDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiaQCTrenBang_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", PriceAdvBoardDTO.MaGiaQCTrenBang));
                sqlCommand.Parameters.Add(new SqlParameter("@gia", PriceAdvBoardDTO.DonGia));
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
        public bool DeletePriceAdvBoard(string maDO)
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
