using System;
using Module2HW2.Enums;
using Module2HW2.Models;

namespace Module2HW2.Providers
{
    public class OrderProvider
    {
        public int CheckId()
        {
            var rnd = new Random();
            return rnd.Next(100000, 999999);
        }

        public void OrderConfirmMessage(int checkId)
        {
            Console.WriteLine($"Congrats, your order is ready, number is {checkId}, wait for notification with delivery info");
        }

        public void OrderPrice(Device[] devicesAtCart)
        {
            var s = 0.0d;
            foreach (var device in devicesAtCart)
            {
                s += device.GetDevicePrice();
            }

            Console.WriteLine($"the total cost of the order is {s}{CurrencyEnum.UAN}");
        }
    }
}