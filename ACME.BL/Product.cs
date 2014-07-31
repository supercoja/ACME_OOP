using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.Common;

namespace ACME.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
            :this(0)
        {

        }

        public Product(int _productId)
        {
            this.ProductId = _productId;
        }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public Decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice==null) isValid = false;

            return isValid;
        }

        public bool Save(Product _productToSave)
        {
            var _success = true;
            if (_productToSave.HasChanges && _productToSave.IsValid)
            {
                if (_productToSave.IsNew)
                {

                }
                else
                {

                }
            }
            return _success;
        }

        public string Log()
        {
            var _logString = this.ProductId + ": " +
                             this.ProductName + " " +
                             "Detail: " + this.Description + " " +
                             "Status " + this.EntityState.ToString();
            return _logString;
        }

    }
}
