using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderApp.Services
{
    public class LoggerService
    {
        public void LogOrder(Order order)
        {
            Console.WriteLine($"Order logged successfully: Order ID {order.OrderId}, Amount {order.Amount}");
        }
    }
}
