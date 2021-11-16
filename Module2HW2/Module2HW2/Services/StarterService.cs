using System;
using Module2HW2.Enums;
using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class StarterService
    {
        private readonly DeviceService _deviceService = new();
        private readonly CartProvider _cartProvider = CartProvider.Instance;
        private readonly OrderProvider _orderProvider = new();
        private readonly NotificationService _notificationService = new();
        private readonly OrderService _orderService = new();
        private readonly UserProvider _userProvider = new();
        public void Run()
        {
            var user = _userProvider.GetUser();
            var devices = _deviceService.GetAllDevices();
            var devicesAtCart = _cartProvider.AddToCart(devices);
            var confirmedOrder = _orderService.ConfirmOrder(devicesAtCart);
            var checkId = _orderProvider.CheckId();
            var orderFullPrice = _orderService.GetOrderCost(devicesAtCart);
            _notificationService.GetOrderInfo(checkId, orderFullPrice, confirmedOrder);
            _notificationService.EmailNotification(user.Email, checkId);
            _notificationService.PhoneNotification(user.PhoneNumber, checkId);
            _cartProvider.ClearCart();
        }
    }
}