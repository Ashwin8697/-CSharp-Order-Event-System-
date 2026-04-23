using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }

        public Order(int orderId, string customerName, double amount)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Amount = amount;
        }


    }
}


