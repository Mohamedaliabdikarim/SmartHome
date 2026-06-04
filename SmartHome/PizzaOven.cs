using System;
using System.Collections.Generic;
using System.Text;


namespace SmartHome
{
    public class PizzaOven : Oven
    {
        public PizzaOven(string brand, string room, int maxTemperature)
            : base(brand, room, maxTemperature)
        {
        }

        // Försök att override:a TurnOn() - detta ger kompileringsfel!
        // public override void TurnOn()
        // {
        //     Console.WriteLine("Pizza oven starts at extra high temperature.");
        // }

        // ==================== DEL 12 ====================
        // 1. Vad säger kompilatorn?
        //    "cannot override inherited member Oven.TurnOn() because it is sealed"
        //    PizzaOven får inte override:a TurnOn() eftersom den är sealed i Oven.

        // 2. Varför får PizzaOven inte override:a TurnOn()?
        //    För att Oven har markerat TurnOn() med sealed override.
        //    sealed stoppar vidare override i subklasser.

        // 3. När kan det vara rimligt att använda sealed override?
        //    När man vill garantera att en metod alltid beter sig på ett visst sätt.
        //    Till exempel säkerhetskritisk kod eller affärslogik som inte får ändras.

        // 4. Vad kan PizzaOven fortfarande göra?
        //    PizzaOven kan override:a andra metoder som inte är sealed.
        //    Till exempel GetInfo(), TurnOff() och GetDailyEnergyUsage().

        public override string GetInfo()
        {
            return $"{Brand} pizza oven (max {MaxTemperature}°C) in {Room}";
        }

        public override double GetDailyEnergyUsage()
        {
            return 3.5;
        }
    }
}
