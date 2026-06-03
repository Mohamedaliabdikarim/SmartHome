namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> devices = new List<object>();

            devices.Add(new Washer("LG", 7.0));
            devices.Add(new Refrigerator("Samsung", 4.0));
            devices.Add(new Oven("Electrolux", 250));
            devices.Add(new RobotVacuum("Xiaomi", 85.0));
            devices.Add(new CoffeeMachine("Nespresso", 4)); // NY

            RunMorningRoutine(devices);
            Console.WriteLine();
            ReportAllEnergy(devices);
        }

        static void RunMorningRoutine(List<object> devices)
        {
            foreach (object device in devices)
            {
                if (device is Washer washer)
                {
                    washer.StartWash();
                    washer.StopWash();
                }
                else if (device is Refrigerator fridge)
                {
                    fridge.StartCooling();
                    fridge.StopCooling();
                }
                else if (device is Oven oven)
                {
                    oven.StartHeating();
                    oven.StopHeating();
                }
                else if (device is RobotVacuum vacuum)
                {
                    vacuum.StartCleaning();
                    vacuum.StopCleaning();
                }
                else if (device is CoffeeMachine coffee) // NY
                {
                    coffee.StartBrewing();
                    coffee.StopBrewing();
                }
            }
        }

        static void ReportAllEnergy(List<object> devices)
        {
            foreach (object device in devices)
            {
                if (device is Washer washer)
                    washer.PrintWashEnergy();
                else if (device is Refrigerator fridge)
                    fridge.PrintCoolingEnergy();
                else if (device is Oven oven)
                    oven.PrintHeatingEnergy();
                else if (device is RobotVacuum vacuum)
                    vacuum.PrintCleaningEnergy();
                else if (device is CoffeeMachine coffee) // NY
                    coffee.PrintBrewingEnergy();
            }
        }
    }
}





//////// ==================== REFLEKTION DEL 1 ====================
//////// 1. Varför behövde du kontrollera vilken typ varje objekt hade?
////////    För att listan är List<object> och kompilatorn vet inte vilken typ det är.
////////    Vi måste casta till rätt typ för att få tillgång till metoderna.

//////// 2. Vad händer om du lägger till en ny klass CoffeeMachine?
////////    Vi måste ändra BÅDE RunMorningRoutine() och ReportAllEnergy() manuellt.

//////// 3. Vilka metoder måste du ändra om du lägger till CoffeeMachine?
////////    RunMorningRoutine() och ReportAllEnergy() i Program.cs.

//////// 4. Vad är problemet med att listan är List<object>?
////////    Kompilatorn ger inget fel om vi glömmer en typ.
////////    Vi kan lägga till vad som helst i listan utan kontroll.

//////// 5. Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
////////    Den apparaten hoppas helt enkelt över utan felmeddelande.

//////// ==================== REFLEKTION DEL 2 ====================
//////// När jag lade till CoffeeMachine behövde jag ändra:
//////// 1. Skapa ny klass CoffeeMachine.cs
//////// 2. Lägga till i Main() i Program.cs
//////// 3. Lägga till if-kontroll i RunMorningRoutine()
//////// 4. Lägga till if-kontroll i ReportAllEnergy()
//////// Totalt 3 ställen i Program.cs + 1 ny fil = 4 ändringar.s + 1 ny fil = 4 endringer.