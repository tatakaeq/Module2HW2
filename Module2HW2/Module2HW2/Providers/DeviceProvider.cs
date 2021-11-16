using Module2HW2.Enums;
using Module2HW2.Models;

namespace Module2HW2.Providers
{
    public class DeviceProvider
    {
        private readonly Device[] _devices =
        {
            new() { Id = 1, Name = "Samsung Odyssey G5", Category = CategoryEnum.Monitor, Price = 8300, Currency = CurrencyEnum.UAN },
            new() { Id = 2, Name = "Razer Kraken X Mercury", Category = CategoryEnum.Headphones, Price = 1300, Currency = CurrencyEnum.UAN },
            new() { Id = 3, Name = "Logitech G Pro X Superlight", Category = CategoryEnum.Mouse, Price = 4999, Currency = CurrencyEnum.UAN },
            new() { Id = 4, Name = "SteelSeries Apex Pro", Category = CategoryEnum.Keyboard, Price = 7499, Currency = CurrencyEnum.UAN },
            new() { Id = 5, Name = "Dell S2721DGFA", Category = CategoryEnum.Monitor, Price = 14200, Currency = CurrencyEnum.UAN },
            new() { Id = 6, Name = "Sennheiser HD 458", Category = CategoryEnum.Headphones, Price = 3999, Currency = CurrencyEnum.UAN },
            new() { Id = 7, Name = "HyperX Pulsefire Haste", Category = CategoryEnum.Mouse, Price = 1399, Currency = CurrencyEnum.UAN },
            new() { Id = 8, Name = "HyperX Alloy Origins 60", Category = CategoryEnum.Keyboard, Price = 2999, Currency = CurrencyEnum.UAN },
            new() { Id = 9, Name = "Asus VG249Q", Category = CategoryEnum.Monitor, Price = 5888, Currency = CurrencyEnum.UAN },
            new() { Id = 10, Name = "Huawei Freebuds 4", Category = CategoryEnum.Headphones, Price = 4449, Currency = CurrencyEnum.UAN },
            new() { Id = 11, Name = "Razer Viper Ultimate", Category = CategoryEnum.Mouse, Price = 4499, Currency = CurrencyEnum.UAN },
            new() { Id = 12, Name = "Logitech G Pro GX", Category = CategoryEnum.Keyboard, Price = 3187, Currency = CurrencyEnum.UAN }
        };

        public Device[] GetAllDevices()
        {
            return _devices;
        }
    }
}