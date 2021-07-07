using System;
using WeatherStation.PatternObserver;
using WeatherStation.WithEvent;

namespace WeatherStation
{
    class Program
    {
        delegate void MessageHandler(string message);
        static void Main(string[] args)
        {
            // Pattern Observer
            WeatherData weatherData = new WeatherData();
            //PatternObserver.CurrentConditionsReport currentConditions = new PatternObserver.CurrentConditionsReport();
            //weatherData.Register(currentConditions);
            //weatherData.SetMeasurements(12, 12, 12);
            //weatherData.SetMeasurements(12, 12, 12);
            //weatherData.SetMeasurements(12, 12, 12);
            //weatherData.SetMeasurements(12, 12, 12);

            PatternObserver.StatisticReport st = new PatternObserver.StatisticReport();
            weatherData.Register(st);

            weatherData.SetMeasurements(12, 12, 12);
            weatherData.SetMeasurements(15, 15, 12);
            weatherData.SetMeasurements(19, 16, 12);
            weatherData.SetMeasurements(12, 20, 12);

            weatherData.Unregister(st);

            weatherData.SetMeasurements(12, 12, 12);
            weatherData.SetMeasurements(15, 15, 12);
            weatherData.SetMeasurements(19, 16, 12);
            weatherData.SetMeasurements(12, 20, 12);

            st.Display();

            //Event

            //WithEvent.WhetherData weather = new WithEvent.WhetherData();
            //WithEvent.CurrentConditionsReport current = new WithEvent.CurrentConditionsReport(weather);

            //weather.SimulateWheather(12, 12, 12);
            //weather.SimulateWheather(13, 14, 15);
            //weather.SimulateWheather(12, 12, 16);

            //current.Unregister(weather);

            //weather.SimulateWheather(12, 12, 12);
            //weather.SimulateWheather(13, 14, 15);
            //weather.SimulateWheather(12, 12, 16);







            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
