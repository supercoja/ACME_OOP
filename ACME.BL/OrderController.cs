using ACME.Common;
using System;
using System.Diagnostics;

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

        public OperationResult PlaceOrder(Customer _customer, Order _order, Payment _payment, bool _allowSplitOrders, bool _emailReceipt)
        {
            if (_customer == null) throw new ArgumentNullException("Customer Instance Is null");
            if (_order == null) throw new ArgumentNullException("Order Instance Is Null");
            if (_payment == null) throw new ArgumentNullException("Payment Instance Is Null");

            var _op = new OperationResult();

            Debug.Assert(_customerRepository != null, "Missing Customer Repository Instance");
            Debug.Assert(_orderRepository != null, "Missing Order Repository Instance");
            Debug.Assert(_inventoryRepository != null, "Missing Inventory Repository Instance");
            Debug.Assert(_emailLibrary != null, "Missing Email Library Instance");

            _customerRepository.Add(_customer);

            _orderRepository.Add(_order);

            _inventoryRepository.OrderItems(_order, _allowSplitOrders);

            _payment.ProcessPayment();

            if (_emailReceipt)
            {
                var _result = _customer.ValidateEmail();
                if (_result.Sucess)
                {
                    _customerRepository.Update();
                    _emailLibrary.SendMail(_customer.EmailAddress, "Receipt From Vendor");
                }               
                else
                {
                    // log messages;
                    if (_result.MessageList.Count>0)
                    {
                        _op.AddMessage(_result.MessageList[0]);
                    }
//                    _result.Sucess = false;

                }
            }
            return _op;

        }
    }
}
