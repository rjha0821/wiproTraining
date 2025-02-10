using System;

namespace DesignPatternsDemo
{
    public class WeatherDisplay : IObserver
    {
        private string _name;

        public WeatherDisplay(string name)
        {
            _name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} Display: Temperature is now {temperature}°C");
        }
    }
}
