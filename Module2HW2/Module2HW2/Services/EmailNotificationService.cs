using System;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class EmailNotificationService
    {
        public void NotifyUserByEmail(string email, int orderNumber)
        {
            Console.WriteLine($"Hello, {email}. Here is {orderNumber} Order delivery details:");
        }
    }
}