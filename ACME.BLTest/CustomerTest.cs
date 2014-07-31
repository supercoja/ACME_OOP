using System;
using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.Common;

namespace ACME.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            //--Arrange
            Customer _customer = new Customer();
            _customer.FirstName = "Frodo";
            _customer.LastName = "Baggins";

            string _expected = "Baggins, Frodo";

            //--Act
            string _actual = _customer.FullName;

            //--Assert
            Assert.AreEqual(_actual, _expected);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer _customer = new Customer();
            _customer.LastName = "Baggins";

            string _expected = "Baggins";

            //--Act
            string _actual = _customer.FullName;

            //--Assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer _customer = new Customer();
            _customer.LastName = "Bilbo";

            string _expected = "Bilbo";

            //--Act
            string _actual = _customer.FullName;

            //--Assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]

        public void ObjectStaticCount()
        {
            //--Arrange
            var _c1 = new Customer();
            _c1.FirstName = "Frodo";

            Customer.InstanceCount += 1;
            var _c2 = new Customer();
            _c2.FirstName = "Bilbo";
            Customer.InstanceCount += 1;
            var _c3 = new Customer();
            _c3.FirstName = "Sam";
            Customer.InstanceCount += 1;

            var _expected = 3;
            //--Act

            var _actual = Customer.InstanceCount;

            //--Assert

            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var _c1 = new Customer();
            _c1.LastName = "Frodo";
            _c1.EmailAddress = "frodo@baggins.com";

            var _expected = true;
            //--Act

            var _actual = _c1.Validate();

            //--Assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            var _c1 = new Customer();
            _c1.EmailAddress = "frodo@baggins.com";

            var _expected = false;
            //--Act

            var _actual = _c1.Validate();

            //--Assert
            Assert.AreEqual(_expected, _actual);

        }

    }
}
