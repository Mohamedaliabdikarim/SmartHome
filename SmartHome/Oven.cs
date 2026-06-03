using System;
using System.Collections.Generic;
using System.Text;


namespace SmartHome
{
    public class Oven
    {
        public string Brand { get; }
        public int MaxTemperature { get; }

        public Oven(string brand, int maxTemperature)
        {
            Brand = brand;
            MaxTemperature = maxTemperature;
        }

        public void StartHeating()
        {
            Console.WriteLine($"{Brand} oven starts heating.");
        }

        public void StopHeating()
        {
            Console.WriteLine($"{Brand} oven stops heating.");
        }

        public void PrintHeatingEnergy()
        {
            Console.WriteLine($"{Brand} oven uses 2.5 kWh per hour.");
        }
    }
}