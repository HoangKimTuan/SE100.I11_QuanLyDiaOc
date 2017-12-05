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
    class PriceAdvNewspaperBLL
    {
        private PriceAdvNewspaperDAL PriceAdvNewspaperDAL = new PriceAdvNewspaperDAL();

        public DataTable GetListPriceAdvNewspaper()
        {
            return PriceAdvNewspaperDAL.GetListPriceAdvNewspaper();
        }

        public bool UpdatePriceAdvNewspaper(PriceAdvNewspaperDTO PriceAdvNewspaperDTO)
        {
            return PriceAdvNewspaperDAL.UpdatePriceAdvNewspaper(PriceAdvNewspaperDTO);
        }

    }
}
