using System;
using System.Collections.Generic;
using System.Text;


namespace SmartHome
{
    public class Oven : Appliance
    {
        public int MaxTemperature { get; }

        public Oven(string brand, string room, int maxTemperature)
            : base(brand, room)
        {
            MaxTemperature = maxTemperature;
        }

        public override string GetInfo()
        {
            return $"{Brand} oven (max {MaxTemperature}°C) in {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} oven starts preheating.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} oven stops heating.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 2.5;
        }
    }
}