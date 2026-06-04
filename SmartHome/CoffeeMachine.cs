using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class CoffeeMachine : Appliance, ISchedulable
    {
        public int CupsPerBrew { get; }
        public DateTime NextRun { get; set; }

        public CoffeeMachine(string brand, string room, int cupsPerBrew)
            : base(brand, room)
        {
            CupsPerBrew = cupsPerBrew;
        }

        public override string GetInfo()
        {
            return $"{Brand} coffee machine ({CupsPerBrew} cups per brew) in {Room}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} coffee machine starts brewing.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} coffee machine stops brewing.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 0.3;
        }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"{Brand} coffee machine scheduled for {NextRun:HH:mm}.");
        }
    }
}