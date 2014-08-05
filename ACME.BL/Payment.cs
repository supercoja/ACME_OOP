using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {
        public int PaymentType { get; set; }

        public void ProcessPayment(Payment _payment)
        {
            if (!Enum.IsDefined(typeof(PaymentType),this.PaymentType))
            {
                throw new InvalidEnumArgumentException("Payment Type", (int)this.PaymentType, typeof(PaymentType));
            }

            switch ((ACME.BL.PaymentType)this.PaymentType)
            {
                case ACME.BL.PaymentType.CreditCard:
                    // code for credit card
                    break;
                case ACME.BL.PaymentType.PayPal:
                    // code for paypal
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
