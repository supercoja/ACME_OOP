using System;
using ACME.Common;
using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace ACME.CommonTest
{
    [TestClass]
    public class LogginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //-- Arrange
            var _changedItems = new List<ILoggable>();
            var _customer = new Customer(1)
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                EmailAddress = "frodo@baggins.com",
                AddressList = null
            };

            _changedItems.Add(_customer as ILoggable);
            var _product = new Product(2)
            {
                ProductName = "Rake",
                Description = "Chuba",
                CurrentPrice = 60M
            };
            _changedItems.Add(_product as ILoggable);

           //-- Act
           LogginService.WriteToFile(_changedItems);

            //-- Assert
        }
    }
}
