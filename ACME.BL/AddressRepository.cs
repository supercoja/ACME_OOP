using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class AddressRepository
    {
        public bool Save()
        {
            return true;
        }

        public Address Retrieve(int _addressId)
        {
            var _address = new Address(_addressId);
            if (_addressId == 1)
            {
                _address.StreetLine1 = "Shire Road";
                _address.StreetLine2 = "Shire Load Road";
                _address.City = "Hobintown";
                _address.State = "Shire";
                _address.Country = "Middle Earth";
                _address.PostalCode = "144";
            }
            return _address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int _costumerId)
        {
            var _addressList = new List<Address>();
            Address _address = new Address(1)
            {
                AdressType = 1,
                StreetLine1 = "Shire Road",
                StreetLine2 = "Shire Load Road",
                City = "Hobintown",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            _addressList.Add(_address);
            _address = new Address(2)
            {
                AdressType = 2,
                StreetLine1 = "Hi",
                StreetLine2 = "Bono Numo",
                City = "Rio de Janeiro",
                State = "Rio de Janeiro",
                Country = "Earth",
                PostalCode = "51"
            };
            _addressList.Add(_address);
            return _addressList;
        }
        public List<Address> Retrieve()
        {
            return new List<Address>();
        }
    }
}
