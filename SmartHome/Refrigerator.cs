using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Refrigerator : Appliance
    {
        public double Temperature { get; }

        public Refrigerator(string brand, string room, double temperature)
            : base(brand, room)
        {
            Temperature = temperature;
        }

        public override string GetInfo()
        {
            return $"{Brand} refrigerator ({Temperature}°C) in {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} refrigerator starts cooling.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} refrigerator stops cooling.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 3.6;
        }
    }
}