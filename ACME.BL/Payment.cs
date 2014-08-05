using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Payment
    {

        public int PaymentType { get; set; }
        public void ProcessPayment(Payment _payment)
        {
            switch (this.PaymentType)
            {
                case 1:
                    // code
                    break;
                case 2:
                    // code
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
