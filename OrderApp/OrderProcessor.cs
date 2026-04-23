using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public delegate void OrderPlacedHandler(Order order);
    internal class OrderProcessor
    {
        public event OrderPlacedHandler OnOrderPlaced;

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"Order Placed: {order.OrderId}");
            Console.WriteLine($"Customer Name: {order.CustomerName}");
            Console.WriteLine($"Amount: {order.Amount}");

            // Null-safe event invocation
            OnOrderPlaced?.Invoke(order);
        }

    }
}


