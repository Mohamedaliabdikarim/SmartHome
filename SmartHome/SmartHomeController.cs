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

        // // Del 9: Fel version - kompilerar inte eftersom Appliance inte har Schedule()()
        // public void ScheduleAllDevicesWrong(DateTime time)
        // {
        //     foreach (Appliance device in _devices)
        //     {
        //         device.Schedule(time); // Appliance har ingen Schedule() metod!
        //     }
        // }

        // Varför kompilerar inte ScheduleAllDevicesWrong()?
        // För att Schedule() inte finns i Appliance-klassen.
        // Kompilatorn känner bara till Appliance-typen, inte ISchedulable.
        // Även om objektet egentligen är en Washer vet inte kompilatorn det här.

        public void ScheduleAllSchedulableDevices(DateTime time)
        {
            foreach (Appliance device in _devices)
            {
                if (device is ISchedulable schedulable)
                {
                    schedulable.Schedule(time);
                }
            }
        }

        internal List<ISchedulable> GetSchedulableDevices()
        {
            List<ISchedulable> result = new List<ISchedulable>();
            foreach (Appliance device in _devices)
            {
                if (device is ISchedulable schedulable)
                {
                    result.Add(schedulable);
                }
            }
            return result;
        }

        public Appliance FindDeviceByBrand(string brand)
        {
            foreach (Appliance device in _devices)
            {
                if (device.Brand == brand)
                {
                    return device;
                }
            }
            return null;
        }
    }
}