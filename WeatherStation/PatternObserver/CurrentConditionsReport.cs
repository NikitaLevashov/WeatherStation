using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.PatternObserver
{
    public class CurrentConditionsReport : IObserver
    {
        private double temperature;
        private double humidity;
        private double pressure;
        public CurrentConditionsReport()
        {
            this.temperature = 0;
            this.humidity = 0;
            this.pressure = 0;
        }
        public void Update(double t, double h, double p)
        {
            this.temperature = t;
            this.humidity = h;
            this.pressure = p;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Current conditions: Temperature - { this.temperature} F, Humidity - { this.humidity} %,  Pressure - {this.pressure} P.");
        }
    }
}
