using ACME.BL;
using System;
using System.Windows.Forms;

namespace ACME.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        public void PlaceOrder()
        {
            var _customer = new Customer();
            var _order = new Order();
            var _payment = new Payment();
            // populating Entities

            // user interface simulating

            var _orderController = new OrderController();

            try
            {
                _orderController.PlaceOrder(_customer, _order, _payment, _allowSplitOrders: false, _emailReceipt: true);
            }
            catch (ArgumentException _exp)
            {
                // log
                // display a message to the user
                MessageBox.Show("Your Order Cannot Be Placed. Try Again Later ");
            }
        }
    }
}
