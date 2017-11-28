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

        public DataTable SearchRealEstate(string mado, string diachi, string dientichtu, string dientichden, string giabantu, string giabanden)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DiaOc_TimKiem";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mado", mado));
                sqlCommand.Parameters.Add(new SqlParameter("@diachi", diachi));
                if (giabantu == "")
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@giabantu", "0"));
                }
                else
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@giabantu", giabantu));
                }
                if (giabanden == "")
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@giabanden", "0"));
                }
                else
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@giabanden", giabanden));
                }
                if (dientichtu == "")
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@dientichtu", "0"));
                }
                else
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@dientichtu", double.Parse(dientichtu)));
                }
                if (dientichden == "")
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@dientichden", "0"));
                }
                else
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@dientichden", double.Parse(dientichden)));
                }
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
        public DataTable GetInfoRealEstate(string realEstateId)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DicOC_LayThongTin";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@mado", realEstateId));
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

        public DataTable GetTypeRealEstate(string typeRealEstateId)
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DiaOc_TenLoaiDiaOc";
                sqlCommand = new SqlCommand(store, connect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@maloaido", typeRealEstateId));
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
    }
}
