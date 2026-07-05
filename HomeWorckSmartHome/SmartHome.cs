namespace HomeWorckSmartHome
{
    public class SmartHome
    {
        private bool _lightIsOn;
        private bool _heatingIsOn;
        private int _temperature;
        private string _currentRoom;

        public SmartHome()
        {
            _lightIsOn = false;
            _heatingIsOn = false;
            _temperature = 20;
            _currentRoom = "Гостиная";
        }

        public bool TurnOnLight()
        {
            if (_lightIsOn)
            {
                return false;
            }

            _lightIsOn = true;
            return true;
        }

        public bool TurnOffLight()
        {
            if (_lightIsOn == false)
            {
                return false;
            }

            _lightIsOn = false;
            return true;
        }

        public bool TurnOnHeating()
        {
            if (_heatingIsOn)
            {
                return false;
            }

            _heatingIsOn = true;
            return true;
        }

        public bool TurnOffHeating()
        {
            if (_heatingIsOn == false)
            {
                return false;
            }

            _heatingIsOn = false;
            return true;
        }

        public bool TrySetTemperature(int newTemperature)
        {
            if (newTemperature < 10 || newTemperature > 35)
            {
                return false;
            }

            _temperature = newTemperature;
            return true;
        }

        public bool TrySetRoom(string roomName)
        {
            if (string.IsNullOrWhiteSpace(roomName))
            {
                return false;
            }

            _currentRoom = roomName;
            return true;
        }

        public bool GetLightStatus()
        {
            return _lightIsOn;
        }

        public bool GetHeatingStatus()
        {
            return _heatingIsOn;
        }

        public int GetTemperature()
        {
            return _temperature;
        }

        public string GetCurrentRoom()
        {
            return _currentRoom;
        }
    }
}