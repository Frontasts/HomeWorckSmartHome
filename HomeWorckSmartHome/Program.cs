using System;

namespace HomeWorckEncapsulation
{
    internal class Program
    {
        static void Main()
        {
            SmartHome smartHome = new SmartHome();

            Console.WriteLine(smartHome.GetStatus());
            Console.WriteLine();

            Console.WriteLine(smartHome.TurnOnLight());
            Console.WriteLine(smartHome.TurnOnLight());
            Console.WriteLine(smartHome.TurnOffLight());
            Console.WriteLine();

            Console.WriteLine(smartHome.TurnOnHeating());
            Console.WriteLine(smartHome.SetTemperature(24));
            Console.WriteLine(smartHome.SetTemperature(5));
            Console.WriteLine(smartHome.SetTemperature(40));
            Console.WriteLine(smartHome.TurnOffHeating());
            Console.WriteLine();

            Console.WriteLine(smartHome.SwitchRoom("Спальня"));
            Console.WriteLine(smartHome.SwitchRoom("Кухня"));
            Console.WriteLine(smartHome.SwitchRoom(""));
            Console.WriteLine();

            Console.WriteLine(smartHome.GetStatus());
        }
    }
	
    public class SmartHome
    {
        private bool lightIsOn;
        private bool heatingIsOn;
        private int temperature;
        private string currentRoom;

        public SmartHome()
        {
            lightIsOn = false;
            heatingIsOn = false;
            temperature = 20;
            currentRoom = "Гостиная";
        }

        public bool GetLightStatus()
        {
            return lightIsOn;
        }

        public bool GetHeatingStatus()
        {
            return heatingIsOn;
        }

        public int GetTemperature()
        {
            return temperature;
        }

        public string GetCurrentRoom()
        {
            return currentRoom;
        }

        public string TurnOnLight()
        {
            string result;
			
            if (lightIsOn)
            {
                result = "Свет уже включен";
            }
            else
            {
                lightIsOn = true;
                result = "Свет включен";
            }
			
            return result;
        }

        public string TurnOffLight()
        {
            string result;
			
            if (lightIsOn == false)
            {
                result = "Свет уже выключен";
            }
            else
            {
                lightIsOn = false;
                result = "Свет выключен";
            }
			
            return result;
        }

        public string TurnOnHeating()
        {
            string result;
			
            if (heatingIsOn)
            {
                result = "Отопление уже включено";
            }
            else
            {
                heatingIsOn = true;
                result = $"Отопление включено. Текущая температура: {temperature}°C";
            }
			
            return result;
        }

        public string TurnOffHeating()
        {
            string result;
			
            if (heatingIsOn == false)
            {
                result = "Отопление уже выключено";
            }
            else
            {
                heatingIsOn = false;
                result = "Отопление выключено";
            }
			
            return result;
        }

        public string SetTemperature(int newTemperature)
        {
            string result;
			
            if (newTemperature < 10)
            {
                result = "Ошибка: температура слишком низкая (минимум 10°C)";
            }
            else if (newTemperature > 35)
            {
                result = "Ошибка: температура слишком высокая (максимум 35°C)";
            }
            else
            {
                temperature = newTemperature;
				
                if (heatingIsOn)
                {
                    result = $"Температура установлена: {temperature}°C. Отопление работает.";
                }
                else
                {
                    result = $"Температура установлена: {temperature}°C. Включите отопление для нагрева.";
                }
            }
			
            return result;
        }

        public string SwitchRoom(string roomName)
        {
            string result;
			
            if (string.IsNullOrWhiteSpace(roomName))
            {
                result = "Ошибка: название комнаты не может быть пустым";
            }
            else
            {
                string oldRoom = currentRoom;
                currentRoom = roomName;
                result = $"Переключение: {oldRoom} -> {currentRoom}";
            }
			
            return result;
        }

        public string GetStatus()
        {
            string lightStatus = lightIsOn ? "Включен" : "Выключен";
            string heatingStatus = heatingIsOn ? "Включено" : "Выключено";
            string result = $"=== Статус Умного Дома ===\n" +
                            $"Комната: {currentRoom}\n" +
                            $"Свет: {lightStatus}\n" +
                            $"Отопление: {heatingStatus}\n" +
                            $"Температура: {temperature}°C";
            return result;
        }
    }
}