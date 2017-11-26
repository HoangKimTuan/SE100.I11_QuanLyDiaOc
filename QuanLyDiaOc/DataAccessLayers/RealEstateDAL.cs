using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DataTransferObject;
using System.Data;
using System.Data.SqlClient;
using QuanLyDiaOc.DataTransferObject;

namespace QuanLyDiaOc.DataAccessLayers
{
    class RealEstateDAL : Connection
    {
        public DataTable GetListRealEstate(string maKH)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DiaOc_LayDanhSach";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makh", maKH));
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

        public bool InsertRealEstate(RealEstateDTO realEstateDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Them";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@makh", realEstateDTO.MaKH));
                sqlCommand.Parameters.Add(new SqlParameter("@maldo", realEstateDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", realEstateDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@dtkv", realEstateDTO.DienTichKhuanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@dtsd", realEstateDTO.DienTichSuDung));
                sqlCommand.Parameters.Add(new SqlParameter("@hn", realEstateDTO.HuongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@vt", realEstateDTO.ViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", realEstateDTO.MoTaChiTiet));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", realEstateDTO.GiaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", realEstateDTO.HinhAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@tt", realEstateDTO.TrangThai));
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

        public bool UpdateRealEstate(RealEstateDTO realEstateDTO)
        {
            try
            {
                OpenConnect();
                string store = "sp_DiaOc_Sua";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mado", realEstateDTO.MaDO));
                sqlCommand.Parameters.Add(new SqlParameter("@makh", realEstateDTO.MaKH));
                sqlCommand.Parameters.Add(new SqlParameter("@maldo", realEstateDTO.MaLoaiDiaOc));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", realEstateDTO.DiaChi));
                sqlCommand.Parameters.Add(new SqlParameter("@dtkv", realEstateDTO.DienTichKhuanVien));
                sqlCommand.Parameters.Add(new SqlParameter("@dtsd", realEstateDTO.DienTichSuDung));
                sqlCommand.Parameters.Add(new SqlParameter("@hn", realEstateDTO.HuongNha));
                sqlCommand.Parameters.Add(new SqlParameter("@vt", realEstateDTO.ViTri));
                sqlCommand.Parameters.Add(new SqlParameter("@mota", realEstateDTO.MoTaChiTiet));
                sqlCommand.Parameters.Add(new SqlParameter("@giaban", realEstateDTO.GiaBan));
                sqlCommand.Parameters.Add(new SqlParameter("@ha", realEstateDTO.HinhAnh));
                sqlCommand.Parameters.Add(new SqlParameter("@tt", realEstateDTO.TrangThai));
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

        public bool DeleteRealEstate(string maDO)
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
    }
}
