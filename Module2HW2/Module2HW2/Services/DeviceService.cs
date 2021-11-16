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
        public Device[] GetAllDevices()
        {
            return _devices;
        }
    }
}