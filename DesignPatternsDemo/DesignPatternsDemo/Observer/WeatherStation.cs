using System;
using System.Collections.Generic;

namespace DesignPatternsDemo
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new();
        private float _temperature;

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }

        public void SetTemperature(float temperature)
        {
            Console.WriteLine($"WeatherStation: New temperature update: {temperature}°C");
            _temperature = temperature;
            NotifyObservers();
        }
    }
}
