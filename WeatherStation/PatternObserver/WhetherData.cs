using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.PatternObserver
{
    public class WeatherData : IObservable
    {
        private List<IObserver> observers;

        private double temperature;
        private double humidity;
        private double pressure;
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
  
        public void MeasurementsChanged()
        {  
            Notify();
        }
        public void SetMeasurements(double t1, double t2, double t3)
        {
            this.temperature = t1;
            this.humidity = t2;
            this.pressure = t3;
            MeasurementsChanged();
        }

        public void Register(IObserver o)
        {
            observers.Add(o);
        }

        public void Unregister(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
    }
}
