using QuanLyDiaOc.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class LoginBLL
    {
        private LoginDAL loginDAL;

        public LoginBLL()
        {
            loginDAL = new LoginDAL();
        }

        public DataTable CheckLogin(string user, string pass)
        {
            return loginDAL.CheckLogin(user, pass);
        }

        public string GetType(string user)
        {
             return loginDAL.GetType(user);
        }
    }
}
