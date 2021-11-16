using System;
using System.Linq;
using Module2HW2.Enums;
using Module2HW2.Models;
using Module2HW2.Services;

namespace Module2HW2.Providers
{
    public class CartProvider
    {
        private const int CartSpace = 10;
        private static readonly CartProvider _instance = new CartProvider();
        private readonly Device[] _devicesAtCart = new Device[CartSpace];

        static CartProvider()
        {
        }

        private CartProvider()
        {
        }

        public static CartProvider Instance
        {
            get
            {
                return _instance;
            }
        }

        public Device[] AddToCart(Device[] devices)
        {
            for (var i = 0; i < 10; i++)
            {
                _devicesAtCart[i] = devices[i];
            }

            return _devicesAtCart;
        }

        public void ClearCart()
        {
            Array.Clear(_devicesAtCart, 0, _devicesAtCart.Length);
        }
    }
}