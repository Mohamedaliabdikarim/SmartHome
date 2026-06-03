using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Appliance
    {
        public string Brand { get; }
        public string Room { get; }
        public bool IsOn { get; protected set; }

        public Appliance(string brand, string room)
        {
            Brand = brand;
            Room = room;
            IsOn = false;
        }

        public virtual string GetInfo()
        {
            return $"{Brand} in {Room}";
        }

        public virtual void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} is turned on.");
        }

        public virtual void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} is turned off.");
        }

        public virtual double GetDailyEnergyUsage()
        {
            return 0;
        }
    }
}