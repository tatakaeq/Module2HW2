using System;
using System.Text;
using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class CartService
    {
        private static readonly CartProvider _cartProvider = CartProvider.Instance;
        private static readonly DeviceService _deviceService = new();
        private readonly Device[] _devices = _cartProvider.AddToCart(_deviceService.GetAllDevices());
        public Device[] GetAllDevicesAtCart()
        {
            return _devices;
        }
    }
}