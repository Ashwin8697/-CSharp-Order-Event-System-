using OrderApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor processor = new OrderProcessor();

            // Create subscribers
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            LoggerService loggerService = new LoggerService();

            // Subscribe methods to event
            processor.OnOrderPlaced += emailService.SendEmail;
            processor.OnOrderPlaced += smsService.SendSMS;
            processor.OnOrderPlaced += loggerService.LogOrder;

            // Create order
            Order order1 = new Order(101, "Ashwin", 2500.50);

            // Place order
            processor.PlaceOrder(order1);

            Console.WriteLine();

            // Unsubscribe one service dynamically
            processor.OnOrderPlaced -= smsService.SendSMS;

            Console.WriteLine("After unsubscribing SMS service:\n");

            Order order2 = new Order(102, "Rahul", 1800.00);
            processor.PlaceOrder(order2);

            Console.ReadLine();
        }
    }
}
