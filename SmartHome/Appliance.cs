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


    // ==================== DEL 10 TEST A ====================
    // Vad händer om man tar bort virtual från TurnOn() i Appliance?
    // Kompilatorn ger ett fel i subklasserna där override används:
    // "cannot override inherited member because it is not marked virtual, abstract or override"
    // Det betyder att override kräver att basklassen har virtual.
}