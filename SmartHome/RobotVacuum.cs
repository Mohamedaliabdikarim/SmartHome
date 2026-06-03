using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class RobotVacuum
    {
        public string Brand { get; }
        public double BatteryLevel { get; }

        public RobotVacuum(string brand, double batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }

        public void StartCleaning()
        {
            Console.WriteLine($"{Brand} robot vacuum starts cleaning.");
        }

        public void StopCleaning()
        {
            Console.WriteLine($"{Brand} robot vacuum stops cleaning.");
        }

        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses 0.4 kWh per cleaning.");
        }
    }
}
