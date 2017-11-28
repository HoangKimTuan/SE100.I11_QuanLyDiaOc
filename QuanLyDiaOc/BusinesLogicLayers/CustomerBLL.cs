using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiaOc.DataAccessLayers;
using QuanLyDiaOc.DataTransferObject;
using System.Data;

namespace QuanLyDiaOc.BusinesLogicLayers
{
    class CustomerBLL
    {
        private CustomerDAL customerDAL = new CustomerDAL();
        public DataTable GetListCustomer()
        {
            return customerDAL.GetListCustomer();
        }

        public DataTable SearchCustomer(string tuKhoa)
        {
            return customerDAL.SearchCustomer(tuKhoa);
        }

        public DataTable SearchCustomer(string makh, string tenkh, string diachi, string sdt)
        {
            return customerDAL.SearchCustomer(makh,tenkh,diachi,sdt);
        }

        public bool InsertCustomer(CustomerDTO customer)
        {
            return customerDAL.InsertCustomer(customer);
        }
        
        public bool DeleteCustomer(string maKH)
        {
            return customerDAL.DeleteCustomer(maKH);
        }

        public bool UpdateCustomer(CustomerDTO customerDTO)
        {
            return customerDAL.UpdateCustomer(customerDTO);
        }

        public DataTable GetInfoCustomer(string customerId)
        {
            try
            {
                return customerDAL.GetInfoCustomer(customerId);
            }
            catch
            {
                return null;
            }
        }

    }
}
