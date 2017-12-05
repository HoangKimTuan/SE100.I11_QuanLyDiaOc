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
    class PriceAdvBoardBLL
    {
        private PriceAdvBoardDAL PriceAdvBoardDAL = new PriceAdvBoardDAL();

        public DataTable GetListPriceAdvBoard()
        {
            return PriceAdvBoardDAL.GetListPriceAdvBoard();
        }

        public bool UpdatePriceAdvBoard(PriceAdvBoardDTO PriceAdvBoardDTO)
        {
            return PriceAdvBoardDAL.UpdatePriceAdvBoard(PriceAdvBoardDTO);
        }

    }
}
