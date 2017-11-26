using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class BillBLL
    {
        BillDAL billDAL = new BillDAL();
        public DataTable GetBill(string madk)
        {
            try
            {
                return billDAL.GetBill(madk);
            }
            catch
            {
                return null;
            }
        }
    }
}
