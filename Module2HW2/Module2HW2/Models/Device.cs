using Module2HW2.Enums;

namespace Module2HW2.Models
{
    public class Device
    {
        public Device(int id, string name, string category, double price, CurrencyEnum currency)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Currency = currency;
        }

        private int Id { get; set; }

        private string Name { get; set; }

        private string Category { get; set; }

        private double Price { get; set; }

        private CurrencyEnum Currency { get; set; }

        public double GetDevicePrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}, {Category}, {Price}{Currency}";
        }
    }
}