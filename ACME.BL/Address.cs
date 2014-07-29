using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int _addressId)
        {
            this.AddressId = _addressId;
        }
        public int AddressId { get; private set; }
        public int AdressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2{ get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country{ get; set; }
    }
}
