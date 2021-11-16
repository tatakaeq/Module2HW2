using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class NotificationService
    {
        private readonly EmailNotificationService _emailNotificationProvider = new();
        private readonly PhoneNotificationService _phoneNotificationProvider = new();
        private readonly OrderInfoNotificationService _orderInfoNotificationService = new();
        public void EmailNotification(string email, int orderNumber)
        {
            _emailNotificationProvider.NotifyUserByEmail(email, orderNumber);
        }

        public void PhoneNotification(string phoneNumber, int orderNumber)
        {
            _phoneNotificationProvider.NotifyUserByPhone(phoneNumber, orderNumber);
        }

        public void GetOrderInfo(int orderNumber, double orderCost, Device[] devices)
        {
            _orderInfoNotificationService.GetOrderProcessingInfo(devices, orderNumber);
            _orderInfoNotificationService.GetComfirmedOrderInfo(orderNumber, orderCost);
        }
    }
}