using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class RobotVacuum : Appliance
    {
        public double BatteryLevel { get; }

        public RobotVacuum(string brand, string room, double batteryLevel)
            : base(brand, room)
        {
            BatteryLevel = batteryLevel;
        }

        public override string GetInfo()
        {
            return $"{Brand} robot vacuum (battery: {BatteryLevel}%) in {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} robot vacuum starts cleaning.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} robot vacuum stops cleaning.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 0.4;
        }
    }
}