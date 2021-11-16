using System;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class PhoneNotificationService
    {
        public void NotifyUserByPhone(string phoneNumber, int orderNumber)
        {
            Console.WriteLine($"Hello, {phoneNumber}. Here is {orderNumber} Order delivery details:");
        }
    }
}