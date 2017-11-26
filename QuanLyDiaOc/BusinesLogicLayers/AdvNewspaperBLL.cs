using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class AdvNewspaperBLL
    {
        AdvNewpaperDAL advNewspaperDAL = new AdvNewpaperDAL();
        public string GetIdTypeAdvNewpaper(string maqc)
        {
            try
            {
                return advNewspaperDAL.GetIdTypeAdvNewpaper(maqc);
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetInfoTypeAdv(string maqc)
        {
            try
            {
                return advNewspaperDAL.GetInfoTypeAdv(maqc);
            }
            catch
            {
                return null;
            }
        }

    }
}
