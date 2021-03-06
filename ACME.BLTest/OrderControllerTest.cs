﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.Common;
namespace ACME.BLTest
{
    [TestClass()]
    public class OrderControllerTest
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            // -- Arrange

            var _orderController = new OrderController();
            var _customer = new Customer { EmailAddress = "taalmeid@yahoo.com.br" };
            var _order = new Order();
            var _payment = new Payment { PaymentType = 1 };

            // -- Act
            OperationResult _op = _orderController.PlaceOrder(_customer, _order, _payment, _allowSplitOrders: true, _emailReceipt: true);

            // -- Assert
            Assert.AreEqual(true, _op.Sucess);
            Assert.AreEqual(0, _op.MessageList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTestNullCustomer()
        {
            //-- Arrange
            var _orderController = new OrderController();
            Customer _customer = null;
            var _order = new Order();
            var _payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult _op = _orderController.PlaceOrder(_customer, _order, _payment, _allowSplitOrders: true, _emailReceipt:true);

            //-- Assert
        }

        [TestMethod]
        public void PlaceOrderTestInvalidEmail()
        {
            //-- Arrange
            var _orderController = new OrderController();
            var _customer = new Customer() { EmailAddress = "" };
            var _order = new Order();
            var _payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult _op = _orderController.PlaceOrder(_customer, _order, _payment, _allowSplitOrders: true, _emailReceipt: true);

            //-- Assert
            Assert.AreEqual(true, _op.Sucess);
            Assert.AreEqual(1, _op.MessageList.Count);
            Assert.AreEqual("Email Address Is Null", _op.MessageList[0]);
        }
    }
}
