using Module2HW2.Enums;
using Module2HW2.Models;

namespace Module2HW2.Providers
{
    public class DeviceProvider
    {
        private readonly Device[] _devices =
        {
            new Device(1, "Samsung Odyssey G5", "Monitor", 8300, CurrencyEnum.UAN),
            new Device(2, "Razer Kraken X Mercury", "Headphones", 1300, CurrencyEnum.UAN),
            new Device(3, "Logitech G Pro X Superlight", "Mouse", 4999, CurrencyEnum.UAN),
            new Device(4, "SteelSeries Apex Pro", "Keyboard", 7499, CurrencyEnum.UAN),
            new Device(5, "Dell S2721DGFA", "Monitor", 14200, CurrencyEnum.UAN),
            new Device(6, "Sennheiser HD 458", "Headphones", 3999, CurrencyEnum.UAN),
            new Device(7, "HyperX Pulsefire Haste", "Mouse", 1399, CurrencyEnum.UAN),
            new Device(8, "HyperX Alloy Origins 60", "Keyboard", 2999, CurrencyEnum.UAN),
            new Device(9, "Asus VG249Q", "Monitor", 5888, CurrencyEnum.UAN),
            new Device(10, "Huawei Freebuds 4", "Headphones", 4449, CurrencyEnum.UAN),
            new Device(11, "Razer Viper Ultimate", "Mouse", 4499, CurrencyEnum.UAN),
            new Device(12, "Logitech G Pro GX", "Keyboard", 3187, CurrencyEnum.UAN)
        };

        public Device[] GetAllDevices()
        {
            return _devices;
        }
    }
}