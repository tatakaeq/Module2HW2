using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class OrderService
    {
        public double GetOrderCost(Device[] devicesAtCart)
        {
            var s = 0.0d;
            foreach (var device in devicesAtCart)
            {
                s += device.Price;
            }

            return s;
        }

        public Device[] ConfirmOrder(Device[] devicesFromCart)
        {
            return devicesFromCart;
        }
    }
}