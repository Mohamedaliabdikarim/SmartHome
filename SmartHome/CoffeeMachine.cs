using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class CoffeeMachine
    {
        public string Brand { get; }
        public int CupsPerBrew { get; }

        public CoffeeMachine(string brand, int cupsPerBrew)
        {
            Brand = brand;
            CupsPerBrew = cupsPerBrew;
        }

        public void StartBrewing()
        {
            Console.WriteLine($"{Brand} coffee machine starts brewing.");
        }

        public void StopBrewing()
        {
            Console.WriteLine($"{Brand} coffee machine stops brewing.");
        }

        public void PrintBrewingEnergy()
        {
            Console.WriteLine($"{Brand} coffee machine uses 0.3 kWh per brew.");
        }
    }
}