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
    class RealEstateBLL
    {
        private RealEstateDAL realEstateDAL = new RealEstateDAL();

        public DataTable GetListRealEstate(string maKH)
        {
            return realEstateDAL.GetListRealEstate(maKH);
        }

        public bool InsertRealEstate(RealEstateDTO realEstateDTO)
        {
            return realEstateDAL.InsertRealEstate(realEstateDTO);
        }

        public bool UpdateRealEstate(RealEstateDTO realEstateDTO)
        {
            return realEstateDAL.UpdateRealEstate(realEstateDTO);
        }

        public bool DeleteRealEstate(string maDO)
        {
            return realEstateDAL.DeleteRealEstate(maDO);
        }
    }
}
