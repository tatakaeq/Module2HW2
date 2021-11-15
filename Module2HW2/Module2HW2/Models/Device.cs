using Module2HW2.Enums;

namespace Module2HW2.Models
{
    public class Device
    {
        private int _id;
        private string _name;
        private string _category;
        private double _price;
        private CurrencyEnum _currency;

        public Device(int id, string name, string category, double price, CurrencyEnum currency)
        {
            _id = id;
            _name = name;
            _price = price;
            _currency = currency;
            _category = category;
        }
    }
}