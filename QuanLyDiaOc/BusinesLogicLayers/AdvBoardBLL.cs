using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class AdvBoardBLL
    {
        AdvBoardDAL advBoardDAL = new AdvBoardDAL();
        public DataTable GetInfoBoard(string maqcbang)
        {
            try
            {
                return advBoardDAL.GetInfoBoard(maqcbang);
            }
            catch
            {
                return null;
            }
        }
    }
}
