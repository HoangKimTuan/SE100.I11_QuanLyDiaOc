using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiaOc.DataAccessLayers;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class UserTypeBLL
    {
        private UserTypeDAL userTypeDAL = new UserTypeDAL();
        public DataTable GetListUserType()
        {
            return userTypeDAL.GetListUserType();
        }
    }
}
