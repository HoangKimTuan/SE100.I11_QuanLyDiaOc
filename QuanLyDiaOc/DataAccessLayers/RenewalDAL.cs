﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.DataAccessLayers
{
    class RenewalDAL : Connection
    {
        public DataTable GetListRenewal()
        {
            try
            {
                OpenConnect();
                DataTable data = new DataTable();
                string store = "sp_DangKy_LayDanhSachHetHan";
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

        public bool DateRenewalEnd(string madk)
        {
            OpenConnect();
            string store = "sp_DangKy_GiaHan";
            sqlCommand = new SqlCommand(store, connect) { CommandType = CommandType.StoredProcedure };
            sqlCommand.Parameters.Add(new SqlParameter("@SoPDK", madk));
            if (sqlCommand.ExecuteNonQuery() >= 0)
            {
                CloseConnect();
                return true;
            }
            else
            {
                CloseConnect();
                return false;
            }
        }
    }
}
