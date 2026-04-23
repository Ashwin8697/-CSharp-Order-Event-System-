using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;

namespace OrderApp.Services
{
    public class EmailService
    {
        public void SendEmail(Order order)
        {
            Console.WriteLine($"Email sent to {order.CustomerName} for Order ID {order.OrderId}");
        }
    }
}
