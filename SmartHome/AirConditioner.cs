using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class AirConditioner : Appliance
    {
        public int TargetTemperature { get; }

        public AirConditioner(string brand, string room, int targetTemperature)
            : base(brand, room)
        {
            TargetTemperature = targetTemperature;
        }

        public override string GetInfo()
        {
            return $"{Brand} air conditioner (target: {TargetTemperature}°C) in {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} air conditioner starts cooling to {TargetTemperature}°C.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} air conditioner turns off.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 2.0;
        }
    }
}