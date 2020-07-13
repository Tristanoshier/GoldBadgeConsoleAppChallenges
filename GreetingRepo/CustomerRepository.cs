using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingRepo
{
    public class CustomerRepository
    {
        protected readonly List<Customer> _customerDirectory = new List<Customer>();

        //GET
        public List<Customer> GetAllCustomers()
        {
            //return this in alphabetical order
            return _customerDirectory;
        }

        //POST
        public bool AddCustomer(Customer customer)
        {
            int count = _customerDirectory.Count;
            _customerDirectory.Add(customer);
            bool success = (_customerDirectory.Count > count) ? true : false;
            return success;
        }

        //UPDATE
        public bool UpdateCustomerInfo(Customer customer)
        {

        }

        //DELETE
        public bool DeleteMenuItem(Customer customer)
        {
            bool success = _customerDirectory.Remove(customer);
            return success;
        }
       
    }
}
