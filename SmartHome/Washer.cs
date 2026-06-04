using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Washer : Appliance, ISchedulable
    {
        public double CapacityKg { get; }
        public DateTime NextRun { get; set; }

        public Washer(string brand, string room, double capacityKg)
            : base(brand, room)
        {
            CapacityKg = capacityKg;
        }

        public override string GetInfo()
        {
            return $"{Brand} washer ({CapacityKg} kg) in {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} washer starts a washing program.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} washer stops washing.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 1.2;
        }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} washer scheduled for {NextRun:HH:mm}.");
        }
    }
}