using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Refrigerator
    {
        public string Brand { get; }
        public double Temperature { get; }

        public Refrigerator(string brand, double temperature)
        {
            Brand = brand;
            Temperature = temperature;
        }

        public void StartCooling()
        {
            Console.WriteLine($"{Brand} refrigerator starts cooling.");
        }

        public void StopCooling()
        {
            Console.WriteLine($"{Brand} refrigerator stops cooling.");
        }

        public void PrintCoolingEnergy()
        {
            Console.WriteLine($"{Brand} refrigerator uses 3.6 kWh per day.");
        }
    }
}