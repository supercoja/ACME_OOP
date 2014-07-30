using System;
using System.Collections.Generic;
using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //--Arrange
            var _customerRepository = new CustomerRepository();
            var _expected = new Customer(1)
            {
                EmailAddress = "frodo@baggins.com",
                LastName = "Baggins",
                FirstName = "Frodo"
            };

            //--Act
            var _actual = _customerRepository.Retrieve(1);

            //--Assert
//            Assert.AreEqual(_expected, _actual);
            Assert.AreEqual(_expected.FirstName, _actual.FirstName);
            Assert.AreEqual(_expected.LastName, _actual.LastName);
            Assert.AreEqual(_expected.EmailAddress, _actual.EmailAddress);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //--Arrange
            var _customerRepository = new CustomerRepository();
            var _expected = new Customer(1)
            {
                LastName = "Baggins",
                FirstName = "Frodo",
                EmailAddress = "frodo@baggins.com",
                AddressList = new List<Address>()
              {
                  new Address
                  {
                    AdressType = 1,
                    StreetLine1 = "Shire Road",
                    StreetLine2 = "Shire Load Road",
                    City = "Hobintown",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                  },
                  new Address
                  {
                    AdressType = 2,
                    StreetLine1 = "Hi",
                    StreetLine2 = "Bono Numo",
                    City = "Rio de Janeiro",
                    State = "Rio de Janeiro",
                    Country = "Earth",
                    PostalCode = "51"
                  }
              }
            };

            //--Act
            var _actual = _customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(_expected.FirstName, _actual.FirstName);
            Assert.AreEqual(_expected.LastName, _actual.LastName);
            Assert.AreEqual(_expected.EmailAddress, _actual.EmailAddress);

            for (int i=0;i<1;i++)
            {
                Assert.AreEqual(_expected.AddressList[i].StreetLine1,_actual.AddressList[i].StreetLine1);
                Assert.AreEqual(_expected.AddressList[i].StreetLine2, _actual.AddressList[i].StreetLine2);
                Assert.AreEqual(_expected.AddressList[i].AdressType, _actual.AddressList[i].AdressType);
                Assert.AreEqual(_expected.AddressList[i].City, _actual.AddressList[i].City);
                Assert.AreEqual(_expected.AddressList[i].State, _actual.AddressList[i].State);
                Assert.AreEqual(_expected.AddressList[i].Country, _actual.AddressList[i].Country);
                Assert.AreEqual(_expected.AddressList[i].PostalCode, _actual.AddressList[i].PostalCode);
            }

        }
    }

    
}
