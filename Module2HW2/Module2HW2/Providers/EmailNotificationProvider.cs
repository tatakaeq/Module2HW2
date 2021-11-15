using System;

namespace Module2HW2.Providers
{
    public class EmailNotificationProvider
    {
        public void NotifyUserByEmail(string email)
        {
            Console.WriteLine($"Delivery info has been sent to your Email {email} address! Have a great day!");
        }
    }
}