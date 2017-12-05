using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiaOc.DataAccessLayers;
using QuanLyDiaOc.DataTransferObject;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class PriceAdvFlyerBLL
    {
        private PriceAdvFlyerDAL PriceAdvFlyerDAL = new PriceAdvFlyerDAL();

        public DataTable GetListPriceAdvFlyer()
        {
            return PriceAdvFlyerDAL.GetListPriceAdvFlyer();
        }

        public bool UpdatePriceAdvFlyer(PriceAdvFlyerDTO PriceAdvFlyerDTO)
        {
            return PriceAdvFlyerDAL.UpdatePriceAdvFlyer(PriceAdvFlyerDTO);
        }

    }
}
