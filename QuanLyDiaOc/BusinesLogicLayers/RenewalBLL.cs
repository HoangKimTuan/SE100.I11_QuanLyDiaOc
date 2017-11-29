using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class RenewalBLL
    {
        RenewalDAL renewalDAL = new RenewalDAL();

        public DataTable GetListRenewal()
        {
            try {
                return renewalDAL.GetListRenewal();
            }
            catch
            {
                return null;
            }
        }

        public void DateRenewalEnd(string madk)
        {
            try
            {
                renewalDAL.DateRenewalEnd(madk);
            }
            catch
            {

            }
        }
    }
}
