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

        [TestMethod]
        public void ValidInputs()
        {
            //-- Arrange
            var _customer = new Customer();
            decimal _actualSteps = 2000;
            decimal _goalSteps = 5000;

            var _expected = 40;

            //-- Act
            var _actual = _customer.CalculatePercentOfGoalSteps(_goalSteps, _actualSteps);

            //-- Assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        public void TestValidInputsStrings()
        {
            //--Arrange
            var _customer = new Customer();
            string _actualSteps = "2000";
            string _goalStesp = "5000";
            decimal _expected = 40M;

            //--Act
            var _actual = _customer.CalculatePercentOfGoalSteps(_goalStesp, _actualSteps);

            //--Assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoaStepsValidAndSameString()
        {
            var _customer = new Customer();
            string _actualSteps = "5000";
            string _goalStesp = "5000";
            decimal _expected = 100M;

            //--Act
            var _actual = _customer.CalculatePercentOfGoalSteps(_goalStesp, _actualSteps);

            //--Assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoaStepsValidActualIsZero()
        {
            var _customer = new Customer();
            string _actualSteps = "0";
            string _goalStesp = "5000";
            decimal _expected = 0M;

            //--Act
            var _actual = _customer.CalculatePercentOfGoalSteps(_goalStesp, _actualSteps);

            //--Assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoaStepsIsNull()
        {
            var _customer = new Customer();
            string _actualSteps = "2000";
            string _goalStesp = null;

            //--Act
            var _actual = _customer.CalculatePercentOfGoalSteps(_goalStesp, _actualSteps);

            //--Assert
//            Assert.AreEqual(_expected, _actual);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsEmpty()
        {
            var _customer = new Customer();
            string _actualSteps = "2000";
            string _goalStesp = "one";

            //--Act
            try
            {
                var _actual = _customer.CalculatePercentOfGoalSteps(_goalStesp, _actualSteps);
            }
            catch (Exception _exception)
            {
                Assert.AreEqual("Goal Must Be Numeric", _exception.Message);
                throw;
            }

            //--Assert            
        }
    }
}
