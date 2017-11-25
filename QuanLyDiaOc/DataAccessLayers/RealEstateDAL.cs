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
        public DataTable getListRealEstate(string maKH)
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
                CloseConnect();
                return data;
            }
            catch
            {
                return null;
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

    }
}
