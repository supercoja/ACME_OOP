using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class CustomerRepository
    {
        public bool Save()
        {
            return true;
        }

        public Customer Retrieve(int _customerId)
        {
            var _customer = new Customer(_customerId);
            if (_customerId==1)
            {
              _customer.LastName = "Baggins";
              _customer.FirstName = "Frodo";
              _customer.EmailAddress = "frodo@baggins.com";
            }
            return _customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

    }
}
