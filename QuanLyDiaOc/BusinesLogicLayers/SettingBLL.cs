using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DataAccessLayers;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class SettingBLL
    {
        private SettingDAL settingDAL = new SettingDAL();

        public bool UpdataParamater(String laiSuat, String moTa, String tuoi)
        {
            return settingDAL.UpdateParamater(laiSuat, moTa, tuoi);
        }

        public String GetMinAge()
        {
            return settingDAL.GetMinAge();
        }

        public String GetMaxAge()
        {
            return settingDAL.GetMaxAge();
        }

        public String GetInterestRate()
        {
            return settingDAL.GetInterestRate();
        }

        public String GetNumberWords()
        {
            return settingDAL.GetNumberWords();
        }
    }
}
