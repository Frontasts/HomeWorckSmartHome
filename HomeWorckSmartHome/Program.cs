using System;

namespace HomeWorckSmartHome
{
    internal class Program
    {
        static void Main()
        {
            SmartHome smartHome = new SmartHome();

            Console.WriteLine(smartHome.TurnOnLight());
            Console.WriteLine(smartHome.TurnOnLight());
            Console.WriteLine(smartHome.TurnOffLight());
            Console.WriteLine();

            Console.WriteLine(smartHome.TurnOnHeating());
            Console.WriteLine(smartHome.TrySetTemperature(24));
            Console.WriteLine(smartHome.TrySetTemperature(5));
            Console.WriteLine(smartHome.TrySetTemperature(40));
            Console.WriteLine(smartHome.TurnOffHeating());
            Console.WriteLine();

            Console.WriteLine(smartHome.TrySetRoom("Спальня"));
            Console.WriteLine(smartHome.TrySetRoom("Кухня"));
            Console.WriteLine(smartHome.TrySetRoom(""));

            Console.WriteLine();
            Console.WriteLine(smartHome.GetCurrentRoom());
            Console.WriteLine(smartHome.GetTemperature());
            Console.WriteLine(smartHome.GetHeatingStatus());
            Console.WriteLine(smartHome.GetLightStatus());
        }
    }
}