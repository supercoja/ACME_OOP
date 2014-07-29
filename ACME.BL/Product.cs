using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Product
    {
        public Product()
        {

        }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public Decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice==null) isValid = false;

            return isValid;
        }
    }
}
