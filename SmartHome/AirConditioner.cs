using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class AirConditioner : Appliance, ISchedulable
    {
        public int TargetTemperature { get; }
        public DateTime NextRun { get; set; }

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

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} air conditioner scheduled for {NextRun:HH:mm}.");
        }
    }
}