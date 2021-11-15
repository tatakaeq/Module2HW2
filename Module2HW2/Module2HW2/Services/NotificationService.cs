using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class NotificationService
    {
        private readonly EmailNotificationProvider _emailNotificationProvider = new();
        private readonly PhoneNotificationProvider _phoneNotificationProvider = new();
        public void EmailNotification(string email)
        {
            _emailNotificationProvider.NotifyUserByEmail(email);
        }

        public void PhoneNotification(string phoneNumber)
        {
            _phoneNotificationProvider.NotifyUserByPhone(phoneNumber);
        }
    }
}