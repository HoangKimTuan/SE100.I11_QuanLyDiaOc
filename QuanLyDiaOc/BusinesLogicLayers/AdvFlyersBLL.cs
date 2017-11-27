using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class AdvFlyersBLL
    {
        AdvFlyersDAL flyersDAL = new AdvFlyersDAL();

        public DataTable GetInfoFlyers(string maqctobuom)
        {
            try {
                return flyersDAL.GetInfoFlyers(maqctobuom);
            }
            catch
            {
                return null;
            }
        }
    }
}

