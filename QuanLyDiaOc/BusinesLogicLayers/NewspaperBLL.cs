using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class NewspaperBLL
    {
        NewsPaperDAL newspaperDAL = new NewsPaperDAL();

        public DataTable GetListNewspaper(string maqc)
        {
            try
            {
                return newspaperDAL.GetListNewspaper(maqc);
            }
            catch
            {
                return null;
            }
        }
    }
}
