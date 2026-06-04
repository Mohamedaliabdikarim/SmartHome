namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHomeController controller = new SmartHomeController();

            controller.AddDevice(new Washer("LG", "Laundry room", 7.0));
            controller.AddDevice(new Refrigerator("Samsung", "Kitchen", 4.0));
            controller.AddDevice(new Oven("Electrolux", "Kitchen", 250));
            controller.AddDevice(new RobotVacuum("Xiaomi", "Living room", 85.0));
            controller.AddDevice(new CoffeeMachine("Nespresso", "Kitchen", 4));
            controller.AddDevice(new AirConditioner("Daikin", "Bedroom", 22));

            Console.WriteLine("=== Status Report ===");
            controller.PrintStatusReport();
            Console.WriteLine();

            Console.WriteLine("=== Turning On All ===");
            controller.TurnOnAll();
            Console.WriteLine();

            double totalEnergy = controller.GetTotalDailyEnergyUsage();
            Console.WriteLine($"Total daily energy usage: {totalEnergy} kWh");
            Console.WriteLine();

            Console.WriteLine("=== Turning Off All ===");
            controller.TurnOffAll();
            Console.WriteLine();

            Console.WriteLine("=== Scheduling Schedulable Devices ===");
            controller.ScheduleAllSchedulableDevices(DateTime.Now.AddHours(2));
            Console.WriteLine();

            Console.WriteLine("=== Schedulable Devices ===");
            List<ISchedulable> schedulableDevices = controller.GetSchedulableDevices();
            foreach (ISchedulable schedulable in schedulableDevices)
            {
                Console.WriteLine($"Next run: {schedulable.NextRun:HH:mm}");
            }
            Console.WriteLine();

            Console.WriteLine("=== Find Device By Brand ===");
            Appliance foundDevice = controller.FindDeviceByBrand("LG");
            if (foundDevice != null)
            {
                foundDevice.TurnOn();
                if (foundDevice is ISchedulable schedulable)
                {
                    schedulable.Schedule(DateTime.Now.AddHours(3));
                }
            }

            // ==================== REFLEKTION DEL 1 ====================
            // 1. Varför behövde du kontrollera vilken typ varje objekt hade?
            //    För att listan är List<object> och kompilatorn vet inte vilken typ det är.
            //    Vi måste casta till rätt typ för att få tillgång till metoderna.

            // 2. Vad händer om du lägger till en ny klass CoffeeMachine?
            //    Vi måste ändra BÅDE RunMorningRoutine() och ReportAllEnergy() manuellt.

            // 3. Vilka metoder måste du ändra om du lägger till CoffeeMachine?
            //    RunMorningRoutine() och ReportAllEnergy() i Program.cs.

            // 4. Vad är problemet med att listan är List<object>?
            //    Kompilatorn ger inget fel om vi glömmer en typ.
            //    Vi kan lägga till vad som helst i listan utan kontroll.

            // 5. Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
            //    Den apparaten hoppas helt enkelt över utan felmeddelande.

            // ==================== REFLEKTION DEL 2 ====================
            // När jag lade till CoffeeMachine behövde jag ändra:
            // 1. Skapa ny klass CoffeeMachine.cs
            // 2. Lägga till i Main() i Program.cs
            // 3. Lägga till if-kontroll i RunMorningRoutine()
            // 4. Lägga till if-kontroll i ReportAllEnergy()
            // Totalt 3 ställen i Program.cs + 1 ny fil = 4 ändringar.

            // ==================== REFLEKTION DEL 5 ====================
            // 1. Varför fungerar device.TurnOn() trots att device har typen Appliance?
            //    För att TurnOn() är virtual i Appliance och override i subklasserna.
            //    C# anropar rätt metod baserat på objektets verkliga typ vid runtime.

            // 2. Vilken metod körs om objektet egentligen är en RobotVacuum?
            //    RobotVacuum.TurnOn() körs, inte Appliance.TurnOn().

            // 3. Vad blev bättre jämfört med List<object>?
            //    Vi behöver inga if-kontroller eller casting.
            //    Kompilatorn vet att alla objekt i listan är Appliance.
            //    Om vi lägger till en ny apparat behöver vi inte ändra loopen.

            // ==================== REFLEKTION DEL 9 ====================
            // 1. Varför kan vi inte anropa Schedule() direkt på en variabel av typen Appliance?
            //    För att Appliance inte implementerar ISchedulable.
            //    Kompilatorn känner bara till vad Appliance erbjuder.

            // 2. Varför fungerar det efter att vi castar till ISchedulable?
            //    För att vi då berättar för kompilatorn att objektet är ISchedulable.
            //    Kompilatorn vet nu att Schedule() finns tillgänglig.

            // 3. Vad betyder det att RobotVacuum både är en Appliance och en ISchedulable?
            //    RobotVacuum ärver från Appliance och implementerar ISchedulable.
            //    Det betyder att den kan användas som båda typerna.

            // 4. Varför ska inte Schedule() ligga direkt i Appliance?
            //    För att inte alla apparater kan schemaläggas.
            //    Refrigerator och Oven ska inte kunna schemaläggas.

            // 5. Vad är skillnaden mellan arv och interface i det här exemplet?
            //    Arv: Washer ärver egenskaper och metoder från Appliance (är en apparat).
            //    Interface: Washer implementerar ISchedulable (kan schemaläggas).
            //    Arv = vad något ÄR. Interface = vad något KAN GÖRA.
        }
    }
}