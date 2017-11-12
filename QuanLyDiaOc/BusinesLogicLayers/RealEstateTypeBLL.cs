using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiaOc.DataAccessLayers;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class RealEstateTypeBLL
    {
        private RealEstateTypeDAL realEstateTypeDAL = new RealEstateTypeDAL();

        public DataTable GetListRealEstateType()
        {
            return realEstateTypeDAL.GetListRealEstateType();
        }
    }
}
