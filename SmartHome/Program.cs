namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> devices = new List<object>();

            // Opprett apparater og legg til i listen
            devices.Add(new Washer("LG", 7.0));
            devices.Add(new Refrigerator("Samsung", 4.0));
            devices.Add(new Oven("Electrolux", 250));
            devices.Add(new RobotVacuum("Xiaomi", 85.0));

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
            }
        }
    }
}