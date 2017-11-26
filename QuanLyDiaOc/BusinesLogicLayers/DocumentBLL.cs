using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class DocumentBLL
    {
        private DocumentDAL documentDAL = new DocumentDAL();

        public DataTable GetListDocument(string mado)
        {
            return documentDAL.GetListDocument(mado);
        }
    }
}
