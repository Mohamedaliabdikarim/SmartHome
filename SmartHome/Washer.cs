using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Washer
    {
        public string Brand { get; }
        public double CapacityKg { get; }

        public Washer(string brand, double capacityKg)
        {
            Brand = brand;
            CapacityKg = capacityKg;
        }

        public void StartWash()
        {
            Console.WriteLine($"{Brand} washer starts washing.");
        }

        public void StopWash()
        {
            Console.WriteLine($"{Brand} washer stops washing.");
        }

        public void PrintWashEnergy()
        {
            Console.WriteLine($"{Brand} washer uses 1.2 kWh per wash.");
        }
    }
}