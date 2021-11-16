using System;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class OrderInfoNotificationService
    {
        public void GetComfirmedOrderInfo(int orderNumber, double orderPrice)
        {
            Console.WriteLine($"Your order, number {orderNumber} was confirmed, total cost of the order is {orderPrice}. We will contact you wia SMS and Email, to tell you delivery details");
        }

        public void GetOrderProcessingInfo(Device[] devices, int orderNumber)
        {
            Console.WriteLine($"Your order {orderNumber} has being processed:");
            foreach (var device in devices)
            {
                Console.WriteLine($"{device.Id}: {device.Category}: {device.Name}, {device.Price}{device.Currency}");
            }
        }
    }
}