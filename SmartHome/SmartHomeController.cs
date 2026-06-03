using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>();

        public void AddDevice(Appliance device)
        {
            _devices.Add(device);
        }

        public void TurnOnAll()
        {
            foreach (Appliance device in _devices)
            {
                device.TurnOn();
            }
        }

        public void TurnOffAll()
        {
            foreach (Appliance device in _devices)
            {
                device.TurnOff();
            }
        }

        public void PrintStatusReport()
        {
            foreach (Appliance device in _devices)
            {
                string status = device.IsOn ? "ON" : "OFF";
                Console.WriteLine($"{device.GetInfo()} - Status: {status}");
            }
        }

        public double GetTotalDailyEnergyUsage()
        {
            double total = 0;
            foreach (Appliance device in _devices)
            {
                total += device.GetDailyEnergyUsage();
            }
            return total;
        }
    }
}