using ACME.Common;

namespace ACME.BL
{
    public class OrderController
    {
        private CustomerRepository _customerRepository { get; set; }
        private OrderRepository _orderRepository { get; set; }
        private InventoryRepository _inventoryRepository { get; set; }

        private EmailLibrary _emailLibrary { get; set; }

        public OrderController()
        {
             _customerRepository = new CustomerRepository();
             _orderRepository = new OrderRepository();
             _inventoryRepository = new InventoryRepository();
             _emailLibrary = new EmailLibrary();
        }

        public void PlaceOrder(Customer _customer, Order _order, Payment _payment, bool _allowSplitOrders, bool _emailReceipt)
        {
            _customerRepository.Add(_customer);

            _orderRepository.Add(_order);

            _inventoryRepository.OrderItems(_order, _allowSplitOrders);

            _payment.ProcessPayment(_payment);

            if (_emailReceipt)
            {

                var _result = _customer.ValidateEmail();
                if (_result.Sucess)
                {
                    _customerRepository.Update();
                    _emailLibrary.SendMail(_customer.EmailAddress, "Receipt From Vendor");
                }
               
            }

        }
    }
}
