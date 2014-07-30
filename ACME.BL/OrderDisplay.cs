using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class OrderDisplay
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderDisplayItem> orderDisplayItemList { get; set; }

        public int OrderId { get; set; }

        public Address ShippingAddess { get; set; }
    }
}
