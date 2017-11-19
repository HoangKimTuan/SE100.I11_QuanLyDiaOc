﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiaOc.DataTransferObject;
using QuanLyDiaOc.DataAccessLayers;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class UserBLL
    {
        private UserDAL userDAL = new UserDAL();

        public DataTable GetListUser()
        {
            return userDAL.GetListUser();
        }

        public bool InsertUser(UserDTO userDTO)
        {
            return userDAL.InsertUser(userDTO);
        }

        public DataTable UpdateUser(UserDTO userDTO)
        {
            return userDAL.UpdateUser(userDTO);
        }

        public bool DeleteUser(String ma)
        {
            return userDAL.DeleteUser(ma);
        }
    }
}
