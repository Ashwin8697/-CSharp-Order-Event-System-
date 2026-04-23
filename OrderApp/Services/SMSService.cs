using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderApp.Services
{
    public class SMSService
    {
        public void SendSMS(Order order)
        {
            Console.WriteLine($"SMS sent to {order.CustomerName} for Order ID {order.OrderId}");
        }
    }
}
