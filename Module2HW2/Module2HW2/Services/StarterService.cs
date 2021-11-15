using System;
using Module2HW2.Enums;
using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class StarterService
    {
        private static readonly DeviceProvider _deviceProvider = new();
        private readonly Device[] _devices = _deviceProvider.GetAllDevices();
        private readonly DeviceService _deviceService = new();
        private readonly CartService _cartService = new();
        private readonly CartProvider _cartProvider = CartProvider.Instance;
        private readonly OrderProvider _orderProvider = new();
        private readonly NotificationService _notificationService = new();
        private readonly User _user = new("user1", "Andrew", "qweQWE123", "a.kara701@gmail.com", "380676131232");
        public void Run()
        {
            _deviceService.WriteAllDevices();
            _cartProvider.AddToCart(_devices);
            _cartService.WriteItemsInCart();
            var checkId = _orderProvider.CheckId();
            _orderProvider.OrderPrice(_cartService.GetAllDevicesAtCart());
            _orderProvider.OrderConfirmMessage(checkId);
            _cartProvider.ClearCart();
            _notificationService.EmailNotification(_user.GetUserEmail());
            _notificationService.PhoneNotification(_user.GetUserPhone());
        }
    }
}