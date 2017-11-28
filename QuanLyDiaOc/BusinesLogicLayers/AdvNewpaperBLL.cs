using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class AdvNewpaperBLL
    {
        advNewspaperBLLDAL advNewspaperBLL = new advNewspaperBLLDAL();

        public DataTable GetInfoNewspaper(string maqcbao)
        {
            try
            {
                return advNewspaperBLL.GetInfoNewspaper(maqcbao);
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetListNewspaper(string maqcbao)
        {
            try
            {
                return advNewspaperBLL.GetListNewspaper(maqcbao);
            }
            catch
            {
                return null;
            }
        }
    }
}
