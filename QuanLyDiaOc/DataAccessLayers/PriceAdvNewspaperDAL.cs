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
    class PriceAdvNewspaperDAL : Connection
    {
        public DataTable GetListPriceAdvNewspaper()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_GiaQCTrenBao_LayDanhSach";
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
        public bool InsertPriceAdvNewspaper(PriceAdvNewspaperDTO PriceAdvNewspaperDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makh", PriceAdvNewspaperDTO.MaKH));
                sqlCommand.Parameters.Add(new SqlParameter("@maldo", PriceAdvNewspaperDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", PriceAdvNewspaperDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@dtkv", PriceAdvNewspaperDTO.DienTichKhuanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@dtsd", PriceAdvNewspaperDTO.DienTichSuDung));
                sqlCommand.Parameters.Add(new SqlParameter("@hn", PriceAdvNewspaperDTO.HuongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@vt", PriceAdvNewspaperDTO.ViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", PriceAdvNewspaperDTO.MoTaChiTiet));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", PriceAdvNewspaperDTO.GiaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", PriceAdvNewspaperDTO.HinhAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@tt", PriceAdvNewspaperDTO.TrangThai));
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
        public bool UpdatePriceAdvNewspaper(PriceAdvNewspaperDTO PriceAdvNewspaperDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_GiaQCTrenBao_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@ma", PriceAdvNewspaperDTO.MaGiaQCTrenBao));
                sqlCommand.Parameters.Add(new SqlParameter("@gia", PriceAdvNewspaperDTO.DonGia));
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
        public bool DeletePriceAdvNewspaper(string maDO)
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
