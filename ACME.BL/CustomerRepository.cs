using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int _customerId)
        {
            Customer _customer = new Customer(_customerId);
            _customer.AddressList = addressRepository.RetrieveByCustomerId(_customerId).ToList();

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

        public void Add(Customer _customer)
        {

        }

        public bool Save()
        {
            return true;
        }


        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
