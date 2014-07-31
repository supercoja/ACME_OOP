using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.Common;

namespace ACME.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {

        }
        public Order(int _orderId)
        {
            this.OrderId = _orderId;
        }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }

        public override bool Validate()
        {
            return true;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
