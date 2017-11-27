using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class FlyersBLL
    {
        FlyersDAL flyersDAL = new FlyersDAL();

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

