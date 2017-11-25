using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class RegistrationBLL
    {
        private RegistrationDAL registrationDAL = new RegistrationDAL();
        public DataTable GetInfoRegistration(string makh, string mado)
        {
            try
            {
                return registrationDAL.GetInfoRegistration(makh, mado);
            }
            catch
            {
                return null;
            }
        }
    }
}
