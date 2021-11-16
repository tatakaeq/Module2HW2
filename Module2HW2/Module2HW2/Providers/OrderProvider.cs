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
    }
}