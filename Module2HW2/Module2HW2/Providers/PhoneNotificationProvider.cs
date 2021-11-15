using System;

namespace Module2HW2.Providers
{
    public class PhoneNotificationProvider
    {
        public void NotifyUserByPhone(string phoneNumber)
        {
            Console.WriteLine($"Please wait for call to your phone number {phoneNumber} from our specialist to get all the delivery info. Have a great day!");
        }
    }
}