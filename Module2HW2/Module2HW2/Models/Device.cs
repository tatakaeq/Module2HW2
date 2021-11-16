using Module2HW2.Enums;

namespace Module2HW2.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryEnum Category { get; set; }
        public double Price { get; set; }
        public CurrencyEnum Currency { get; set; }
    }
}