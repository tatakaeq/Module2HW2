using System;
using Module2HW2.Models;
using Module2HW2.Providers;

namespace Module2HW2.Services
{
    public class StarterService
    {
        private static readonly DeviceProvider _deviceProvider = new DeviceProvider();

        // private int _count;
        private readonly Device[] _devices = _deviceProvider.GetAllDevices();
        public void Run()
        {
            foreach (Device d in _devices)
            {
                Console.WriteLine(d.ToString());
            }
        }
    }
}