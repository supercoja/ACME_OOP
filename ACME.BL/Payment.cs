using System;
using System.ComponentModel;

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

        public void ProcessPayment()
        {
            PaymentType paymentTypeOption;
            if (!Enum.TryParse(this.PaymentType.ToString(), out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment Type", (int)this.PaymentType, typeof(PaymentType));
            }

            switch (paymentTypeOption)
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
