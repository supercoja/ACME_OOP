using System;
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
    }
}
