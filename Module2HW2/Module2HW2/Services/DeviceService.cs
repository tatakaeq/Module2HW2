using System;
using System.Text;
using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class DeviceService
    {
        private static readonly DeviceProvider _deviceProvider = new();
        private readonly Device[] _devices = _deviceProvider.GetAllDevices();
        private StringBuilder _allDevices = new StringBuilder();
        public Device[] GetAllDevices()
        {
            return _devices;
        }

        public void WriteAllDevices()
        {
            _allDevices.AppendLine("List of available products:");
            foreach (var device in _devices)
            {
                _allDevices.AppendLine(device.ToString());
            }

            Console.WriteLine(_allDevices);
        }
    }
}