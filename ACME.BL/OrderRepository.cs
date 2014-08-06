using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int _orderId)
        {
            OrderDisplay _orderDisplay = new OrderDisplay();
            if (_orderId==10)
            {
                _orderDisplay.FirstName = "Frodo";
                _orderDisplay.Lastname = "Baggins";
                _orderDisplay.OrderDate = new DateTimeOffset(2014, 10, 29, 00, 00, 00, new TimeSpan { });
                _orderDisplay.ShippingAddess = new Address
                {
                    AdressType = 1,
                    StreetLine1 = "Shire Road",
                    StreetLine2 = "Shire Load Road",
                    City = "Hobintown",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }
            _orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            if (_orderId==10)
            {
                var _orderDisplayItem = new OrderDisplayItem()
                {
                    OrderItemId = 1,
                    OrderQuantity=50,
                    ProductName = "ChickenBurst",
                    PurchasePrice = 350.00M
                };
                _orderDisplay.orderDisplayItemList.Add(_orderDisplayItem);
                _orderDisplayItem = new OrderDisplayItem()
                {
                    OrderItemId = 2,
                    OrderQuantity = 10,
                    ProductName = "Sheep",
                    PurchasePrice = 42.50M
                };
                _orderDisplay.orderDisplayItemList.Add(_orderDisplayItem);
            }

            return _orderDisplay;
        }

        public void Add(Order _order)
        {

        }
    }
}
