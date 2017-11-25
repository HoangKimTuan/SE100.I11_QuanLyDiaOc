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

        public DataTable SearchRealEstate(string mado, string diachi, string dientichtu, string dientichden, string giabantu, string giabanden)
        {
            try
            {
                return realEstateDAL.SearchRealEstate(mado, diachi, dientichtu, dientichden, giabantu, giabanden);
            }
            catch
            {
                return null;
            }
        }
    }
}
