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
    }
}
