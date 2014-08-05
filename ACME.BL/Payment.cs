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

        public enum PaymentTypeOption 
        {
            CreditCard = 1,
            PayPal = 2
        }
        public void ProcessPayment(Payment _payment)
        {
            switch ((PaymentTypeOption)this.PaymentType)
            {
                case PaymentTypeOption.CreditCard:
                    // code for credit card
                    break;
                case PaymentTypeOption.PayPal:
                    // code for paypal
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
