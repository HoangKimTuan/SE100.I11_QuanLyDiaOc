using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiaOc.DataAccessLayers;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class RealEstateBLL
    {
        private RealEstateDAL realEstateDAL = new RealEstateDAL();

        public DataTable GetListRealEstate(string maKH)
        {
            return realEstateDAL.getListRealEstate(maKH);
        }
    }
}
