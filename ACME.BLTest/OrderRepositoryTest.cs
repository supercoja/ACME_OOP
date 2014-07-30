using System;
using System.Collections.Generic;
using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrDisplayTest()
        {
            //--Arrange
            var _orderRepository = new OrderRepository();
            var _expected = new OrderDisplay()
            {

                FirstName = "Frodo",
                Lastname = "Baggins",
                OrderDate = new DateTimeOffset(2014, 10, 29, 00, 00, 00, new TimeSpan { }),
                ShippingAddess = new Address
                {
                    AdressType = 1,
                    StreetLine1 = "Shire Road",
                    StreetLine2 = "Shire Load Road",
                    City = "Hobintown",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                orderDisplayItemList = new List<OrderDisplayItem>()
                {
                new OrderDisplayItem()
                {
                    OrderItemId = 1,
                    OrderQuantity=50,
                    ProductName = "ChickenBurst",
                    PurchasePrice = 350.00M
                },
                new OrderDisplayItem()
                {
                    OrderItemId = 2,
                    OrderQuantity = 10,
                    ProductName = "Sheep",
                    PurchasePrice = 42.50M
                }
            }
            };

            //--Act
            var _actual = _orderRepository.RetrieveOrderDisplay(10);

            //--Assert
            Assert.AreEqual(_expected.FirstName, _actual.FirstName);
            Assert.AreEqual(_expected.Lastname, _actual.Lastname);
            Assert.AreEqual(_expected.OrderDate, _actual.OrderDate);

            Assert.AreEqual(_expected.ShippingAddess.StreetLine1, _actual.ShippingAddess.StreetLine1);
            Assert.AreEqual(_expected.ShippingAddess.StreetLine2, _actual.ShippingAddess.StreetLine2);
            Assert.AreEqual(_expected.ShippingAddess.AdressType, _actual.ShippingAddess.AdressType);
            Assert.AreEqual(_expected.ShippingAddess.City, _actual.ShippingAddess.City);
            Assert.AreEqual(_expected.ShippingAddess.State, _actual.ShippingAddess.State);
            Assert.AreEqual(_expected.ShippingAddess.Country, _actual.ShippingAddess.Country);
            Assert.AreEqual(_expected.ShippingAddess.PostalCode, _actual.ShippingAddess.PostalCode);

            for (int i=0; i<1; i++)
            {
                Assert.AreEqual(_expected.orderDisplayItemList[i].OrderItemId,_actual.orderDisplayItemList[i].OrderItemId);
                Assert.AreEqual(_expected.orderDisplayItemList[i].OrderQuantity,_actual.orderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(_expected.orderDisplayItemList[i].ProductName,_actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(_expected.orderDisplayItemList[i].PurchasePrice, _actual.orderDisplayItemList[i].PurchasePrice);
            }
        }
    }
}
