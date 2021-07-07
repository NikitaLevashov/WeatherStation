using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.PatternObserver
{
    public class StatisticReport : IObserver
    {
        private double temperature;
        private double humidity;
        private double pressure;

        List<(double temperature, double humidity, double pressure)> listStatistics;
        public StatisticReport()
        {
            listStatistics = new List<(double temperature, double humidity, double pressure)>();
        }
        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            listStatistics.Add((temperature, humidity, pressure));
        }
        public void Display()
        {
            foreach(var t in listStatistics)
            {
                Console.WriteLine($"Current conditions: Temperature - { t.temperature} F, Humidity - { t.humidity} %,  Pressure - {t.pressure} P.");
            }
        }
    }
}
